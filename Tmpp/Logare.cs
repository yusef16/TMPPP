using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tmpp
{
    public partial class Logare : Form
    {
        public Logare()
        {
            InitializeComponent();
        }


        string connectionString = "Data Source=YUSEF;Initial Catalog=tmpp;Integrated Security=True;Encrypt=False";

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username_log.Text == "" || textBox_password_log.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                string username = textBox_username_log.Text;
                string password = textBox_password_log.Text;


                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string query = "SELECT * FROM Receptionist WHERE Username = @username AND Parola = @parola";
                    SqlCommand command = new SqlCommand(query, connection);


                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@parola", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Utilizatorul a fost găsit, autentificarea a reușit
                            MessageBox.Show("Logare reușită.");
                            CurrentUser currentUser = CurrentUser.Instance;
                            currentUser.SetCurrentUser(username);
                            Form1 instance = new Form1();
                            instance.Show();
                            this.Hide();


                        }
                        else
                        {
                            // Utilizatorul nu a fost găsit, autentificarea a eșuat
                            MessageBox.Show("Nume de utilizator sau parolă incorecte.");
                        }

                    }



                    


                }
            }
        }
    }
}
