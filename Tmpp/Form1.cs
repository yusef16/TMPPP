namespace Tmpp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Members_main_btn_Click(object sender, EventArgs e)
        {
            
            if(Memberships_p.Visible)
            {
                Memberships_p.Hide();
            }

            if(Coach_p.Visible)
            {
                Coach_p.Hide();
            }

            if (Inscriere_p.Visible == true)
            {
                Inscriere_p.Hide();
            }

            //Memberships_p.Hide();
            //Coach_p.Hide();
            Members_p.Show();
        }

        private void Coach_main_btn_Click(object sender, EventArgs e)
        {

            if (Memberships_p.Visible == true)
            {
                Memberships_p.Hide();
            }

            if (Members_p.Visible == true)
            {
                Members_p.Hide();
            }

            if (Inscriere_p.Visible == true)
            {
                Inscriere_p.Hide();
            }

            //Memberships_p.Hide();
            //Members_p.Hide();
            Coach_p.Show();
        }

        private void button_Memberships_Click(object sender, EventArgs e)
        {

            if (Members_p.Visible == true)
            {
                Members_p.Hide();
            }

            if (Coach_p.Visible == true)
            {
                Coach_p.Hide();
            }

            if(Inscriere_p.Visible == true)
            {
                Inscriere_p.Hide();
            }

            //Members_p.Hide();
            //Coach_p.Hide();
            Memberships_p.Show();

        }

        private void button_save_Membership_Click(object sender, EventArgs e)
        {

        }
    }
}
