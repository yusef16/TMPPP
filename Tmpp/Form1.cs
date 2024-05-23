using System.Data;
using System.Net;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;

namespace Tmpp
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=YUSEF;Initial Catalog=tmpp;Integrated Security=True;Encrypt=False";
        List<string> concat = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Get_coach_list();
            load_data_abonamente();

            CurrentUser currentUser = CurrentUser.Instance;
            string user = currentUser.GetCurrentUser();
            MessageBox.Show(user);
            load_data();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Receptionist WHERE Username = @User";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@User", user);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read(); // Citește primul rând 
                        bool isAdmin = Convert.ToBoolean(reader["IsAdmin"]);


                        if (isAdmin == true)
                        {
                            button_receptionist.Visible = true;
                        }
                        else
                        {
                            button_receptionist.Visible = false;
                        }

                    }
                }



            }



        }



        public void load_data()
        {
            string query = "SELECT * FROM Receptionist";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }

            dataGridView_receptionist.DataSource = dataTable;

        }

        public void load_data_abonamente()
        {
            string query = "SELECT * FROM Abonamente";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }

            dataGridView_abonamente.DataSource = dataTable;

        }


        public void Get_coach_list()
        {




            string query = "SELECT Nume FROM Antrenori";
            string query1 = "SELECT Prenume From Antrenori";

            List<string> dataListNume = new List<string>();
            List<string> dataListPrenume = new List<string>();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string data = reader["Nume"].ToString();
                        dataListNume.Add(data);
                    }
                }


                SqlCommand command1 = new SqlCommand(query1, connection);

                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string data = reader["Prenume"].ToString();
                        dataListPrenume.Add(data);
                    }
                }
            }

            int c = dataListNume.Count;



            for (int i = 0; i < c; i++)
            {
                string concatenated = dataListNume[i] + ' ' + dataListPrenume[i];
                concat.Add(concatenated);
            }

            //for (int i = 0; i < c; i++)
            //{
            //  MessageBox.Show(concat[i]);
            //}



        }







        private void Members_main_btn_Click(object sender, EventArgs e)
        {


            Memberships_p.Visible = false;
            Coach_p.Visible = false;
            Inscriere_p.Visible = false;
            panel_search.Visible = false;
            panel_r.Visible = false;

            //Members_p.BringToFront();
            Members_p.Visible = true;

        }

        private void Coach_main_btn_Click(object sender, EventArgs e)
        {




            Memberships_p.Visible = false;
            Members_p.Visible = false;
            Inscriere_p.Visible = false;
            panel_r.Visible = false;
            panel_search.Visible = false;

            //Members_p.BringToFront();
            Coach_p.Visible = true;
        }

        private void button_Memberships_Click(object sender, EventArgs e)
        {


            Members_p.Visible = false;
            Coach_p.Visible = false;
            Inscriere_p.Visible = false;
            panel_search.Visible = false;
            panel_r.Visible = false;

            Memberships_p.BringToFront();

            Memberships_p.Visible = true;


        }


        private void button_membership_subscription_Click(object sender, EventArgs e)
        {
            foreach (string item in concat)
            {
                comboBox_antrenor_inscriere.Items.Add(item);
            }

            Members_p.Visible = false;
            Coach_p.Visible = false;
            Memberships_p.Visible = false;
            panel_r.Visible = false;
            panel_search.Visible = false;

            //Inscriere_p.BringToFront();
            Inscriere_p.Visible = true;


        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Members_p.Visible = false;
            Coach_p.Visible = false;
            Memberships_p.Visible = false;
            Inscriere_p.Visible = false;
            panel_r.Visible = false;

            //panel_search.BringToFront();
            panel_search.Visible = true;
        }


        private void button_receptionist_Click(object sender, EventArgs e)
        {
            Members_p.Visible = false;
            Coach_p.Visible = false;
            Memberships_p.Visible = false;
            Inscriere_p.Visible = false;
            panel_search.Visible = false;

            //panel_r.BringToFront();
            panel_r.Visible = true;
        }




        // butnoul de adaugare membri
        private void Save_btn_members_Click(object sender, EventArgs e)
        {

            if (textBox_Lastname.Text == "" || textBox_name.Text == "" || textBox_phonenumber.Text == "" || comboBox_genre.Text == "" || textBox_email.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                Members_builder members_Builder = new Members_builder();
                Members members = members_Builder
                    .Nume(textBox_Lastname.Text)
                    .Prenume(textBox_name.Text)
                    .Nr_telefon(textBox_phonenumber.Text)
                    .Gen(comboBox_genre.Text)
                    .Email(textBox_email.Text)
                    .Build();


                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string query = "INSERT INTO Membri (Nume, Prenume, Telefon, Gen, Email) VALUES (@Nume,@Prenume,@Nrtelefon,@Gen,@Email)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Nume", members.Nume);
                    command.Parameters.AddWithValue("@Prenume", members.Prenume);
                    command.Parameters.AddWithValue("@Nrtelefon", members.Nrtelefon);
                    command.Parameters.AddWithValue("@Gen", members.Gen);
                    command.Parameters.AddWithValue("@Email", members.Email);


                    try
                    {

                        SqlDataReader reader = command.ExecuteReader();
                        MessageBox.Show("Datele s-au inregistrat");
                        connection.Close();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"SQL Error: {ex.Message}, Number: {ex.Number}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error: {ex.Message}");
                    }





                }
            }


        }


        // butonul de adaugare Abonamente
        private void button_save_Membership_Click(object sender, EventArgs e)
        {

            if (Durata_combo.Text == "" || comboBox_tip.Text == "" || textBox_pretAbonamente.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string query = "INSERT INTO Abonamente (Tipabonament, Durata, Pret) VALUES (@Tip,@Durata,@Pret)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Tip", comboBox_tip.Text);
                    command.Parameters.AddWithValue("@Durata", Durata_combo.Text);
                    command.Parameters.AddWithValue("@Pret", textBox_pretAbonamente.Text);



                    try
                    {

                        SqlDataReader reader = command.ExecuteReader();
                        MessageBox.Show("Datele s-au inregistrat");
                        connection.Close();
                        load_data_abonamente();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"SQL Error: {ex.Message}, Number: {ex.Number}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error: {ex.Message}");
                    }

                }

            }



        }





        // butonul de adaugare antrenori
        private void Save_btn_coach_Click(object sender, EventArgs e)
        {

            if (textBox_lastnameCoach.Text == "" || textBox_nameCoach.Text == "" || textBox_phoneCoach.Text == "" || textBox_emailCoach.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {





                using (SqlConnection connection = new SqlConnection(connectionString))
                {







                    connection.Open();
                    string query = "INSERT INTO Antrenori (Nume, Prenume, Email,Telefon) VALUES (@Nume,@Prenume,@Email,@Nrtelefon)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Nume", textBox_lastnameCoach.Text);
                    command.Parameters.AddWithValue("@Prenume", textBox_nameCoach.Text);
                    command.Parameters.AddWithValue("@Nrtelefon", textBox_phoneCoach.Text);
                    command.Parameters.AddWithValue("@Email", textBox_emailCoach.Text);


                    try
                    {

                        SqlDataReader reader = command.ExecuteReader();
                        MessageBox.Show("Datele s-au inregistrat");
                        connection.Close();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"SQL Error: {ex.Message}, Number: {ex.Number}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error: {ex.Message}");
                    }

                }

            }

        }

        private void panel_r_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_save_receptionist_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_save_receptionist_Click_1(object sender, EventArgs e)
        {
            if (textBox_nume_receptionist.Text == "" || textBox_prenume_receptionist.Text == "" || textBox_username_receptionist.Text == "" || textBox_parola_receptionist.Text == "" || textBox_nrtelefon_receptionist.Text == "" || textBox1_email_receptionist.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string query = "INSERT INTO Receptionist (Nume, Prenume, Username,Parola,Telefon,Email,IsAdmin) VALUES (@Nume,@Prenume,@Username,@Parola,@Telefon,@Email,@IsAdmin)";
                    SqlCommand command = new SqlCommand(query, connection);

                    int admin = 0;

                    if (checkBox_isadmin.Checked)
                    { admin = 1; }


                    command.Parameters.AddWithValue("@Nume", textBox_nume_receptionist.Text);
                    command.Parameters.AddWithValue("@Prenume", textBox_prenume_receptionist.Text);
                    command.Parameters.AddWithValue("@Username", textBox_username_receptionist.Text);
                    command.Parameters.AddWithValue("@Parola", textBox_parola_receptionist.Text);
                    command.Parameters.AddWithValue("@Telefon", textBox_nrtelefon_receptionist.Text);
                    command.Parameters.AddWithValue("@Email", textBox1_email_receptionist.Text);
                    command.Parameters.AddWithValue("@IsAdmin", admin);


                    try
                    {

                        SqlDataReader reader = command.ExecuteReader();
                        MessageBox.Show("Datele s-au inregistrat");
                        connection.Close();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"SQL Error: {ex.Message}, Number: {ex.Number}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }


        List<int> abonamente = new List<int>();
        public void getMembershipsList()
        {
            string query = "SELECT COUNT(*) FROM Abonamente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int rowCount = (int)command.ExecuteScalar();

                for (int i = 0; i < rowCount; i++)
                {
                    abonamente.Add(i);
                }

                Console.WriteLine($"Total rows in the table: {rowCount}");
            }



        }

        private void button1_Click(object sender, EventArgs e) // inscriere membri
        {

            if (comboBox_nume_prenume_membri.Text == "" || comboBox1_abonamente.Text == "" || textBox_pret_inscriere.Text == "" || comboBox1_gen_inscriere.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string query = "INSERT INTO Inscriei (MembruID, AbonamentID,AntrenorID,Pret) VALUES (@MembruId,@Ab,@Antr,@Pret)";
                    SqlCommand command = new SqlCommand(query, connection);

                    int pret = int.Parse(textBox_pret_inscriere.Text);
                    string gen = comboBox1_gen_inscriere.Text;
                    int pret_redus;

                    if (comboBox1_gen_inscriere.Text == "F")
                    {
                        WomenDiscountStrategy discount = new WomenDiscountStrategy();
                        pret_redus = discount.ApplyDiscount(pret);
                        MessageBox.Show(pret_redus.ToString());
                    }
                    else
                    {
                        NoDiscountStrategy noDiscount = new NoDiscountStrategy();
                        pret_redus = noDiscount.ApplyDiscount(pret);
                        MessageBox.Show(pret_redus.ToString());
                    }




                    command.Parameters.AddWithValue("@MembruId", comboBox_nume_prenume_membri.Text);
                    command.Parameters.AddWithValue("@Ab", comboBox1_abonamente.Text);
                    command.Parameters.AddWithValue("@Antr", textBox_username_receptionist.Text);
                    command.Parameters.AddWithValue("@Pret", pret_redus);


                    try
                    {

                        SqlDataReader reader = command.ExecuteReader();
                        MessageBox.Show("Datele s-au inregistrat");
                        connection.Close();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"SQL Error: {ex.Message}, Number: {ex.Number}");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }



        }

        //Save to excell
        private void button1_save_date_excel_Click(object sender, EventArgs e)
        {

            string tableName = "Membri";
            string excelFilePath = "C:\\Users\\yusef16\\Desktop\\sem 6\\TMPP\\1.xlsx";

            ITableAdapter tableAdapter = new SqlTableAdapter(connectionString);
            tableAdapter.ConvertTableToExcel(tableName, excelFilePath);

            MessageBox.Show("Fisierul s-a creat");
        }

        // Search button cautare membru
        private void button_cautare_Click(object sender, EventArgs e)
        {
            if (textBox_cautare_nume.Text == "" || textBox_cautare_prenume.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                string query = "Select * From Membri Where Nume = @Nume AND Prenume = @Prenume";

                string nume = textBox_cautare_nume.Text;
                string prenume = textBox_cautare_prenume.Text;

                List<string> date = new List<string>();

                date.Add(nume);
                date.Add(prenume);

                SearchTemplate search = new NameSearch();
                DataTable dt = search.Search(query, connectionString, date);

                dataGridView_cautare_rezultat.DataSource = dt;
                date.Clear();

            }

        }

        // cautare antrenor
        private void button_cautare_antrenor_Click(object sender, EventArgs e)
        {
            if (textBox_cautare_nume.Text == "" || textBox_cautare_prenume.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                string query = "Select * From Antrenori Where Nume = @Nume AND Prenume = @Prenume";

                string nume = textBox_cautare_nume.Text;
                string prenume = textBox_cautare_prenume.Text;

                List<string> date = new List<string>();

                date.Add(nume);
                date.Add(prenume);

                SearchTemplate search = new CoachSearch();
                DataTable dt = search.Search(query, connectionString, date);

                dataGridView_cautare_rezultat.DataSource = dt;
                date.Clear();

            }
        }

        // cautare abonamente
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        // cautare abonamente
        private void button_cautare_abonamente_Click(object sender, EventArgs e)
        {
            if (textBox_tip_abonament.Text == "")
            {
                MessageBox.Show("Completeaza campul cu tipul de abonamente");
            }
            else
            {
                string query = "Select * From Abonamente Where Tipabonament = @tip";

                string tip = textBox_tip_abonament.Text;


                List<string> date = new List<string>();

                date.Add(tip);


                SearchTemplate search = new MembershipSearch();
                DataTable dt = search.Search(query, connectionString, date);

                dataGridView_cautare_rezultat.DataSource = dt;
                date.Clear();

            }
        }

        private void button_membri_excel_membri_Click(object sender, EventArgs e)
        {
            string tableName = "Membri";
            string excelFilePath = "C:\\Users\\yusef16\\Desktop\\sem 6\\TMPP\\1.xlsx";

            ITableAdapter tableAdapter = new SqlTableAdapter(connectionString);
            tableAdapter.ConvertTableToExcel(tableName, excelFilePath);

            MessageBox.Show("Fisierul s-a creat");
        }
    }
}
