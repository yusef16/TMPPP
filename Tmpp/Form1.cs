using System.Data;
using System.Net;
using System.Data.SqlClient;

namespace Tmpp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        string connectionString = "Data Source=YUSEF;Initial Catalog=tmpp;Integrated Security=True;Encrypt=False";


        private void Members_main_btn_Click(object sender, EventArgs e)
        {


            Memberships_p.Visible = false;

            Coach_p.Visible = false;

            Inscriere_p.Visible = false;


            //Memberships_p.Hide();
            //Coach_p.Hide();
            Members_p.BringToFront();
            Members_p.Visible = true;

        }

        private void Coach_main_btn_Click(object sender, EventArgs e)
        {


            Memberships_p.Visible = false;
            Members_p.Visible = false;
            Inscriere_p.Visible = false;


            //Memberships_p.Hide();
            //Members_p.Hide();
            Coach_p.Visible = true;
        }

        private void button_Memberships_Click(object sender, EventArgs e)
        {


            Members_p.Visible = false;
            Coach_p.Visible = false;
            Inscriere_p.Visible = false;


            //Members_p.Hide();
            //Coach_p.Hide();
            Memberships_p.Visible = true;

        }


        private void button_membership_subscription_Click(object sender, EventArgs e)
        {


            Members_p.Visible = false;
            Coach_p.Visible = false;
            Memberships_p.Visible = false;

            Inscriere_p.BringToFront();
            Inscriere_p.Visible = true;


        }

        private void button_search_Click(object sender, EventArgs e)
        {

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
                    string query = "INSERT INTO Antrenori (Tipabonamet, Durata, Pret) VALUES (@Tip,@Durata,@Pret)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Tip", textBox_lastnameCoach.Text);
                    command.Parameters.AddWithValue("@Durata", textBox_nameCoach.Text);
                    command.Parameters.AddWithValue("@Pret", textBox_phoneCoach.Text);
                    


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





        // butonul de adaugare antrenori
        private void Save_btn_coach_Click(object sender, EventArgs e)
        {

            if(textBox_lastnameCoach.Text == "" || textBox_nameCoach.Text == "" || textBox_phoneCoach.Text == "" || textBox_emailCoach.Text == "")
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



    }
}
