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

       



        private void button_save_Membership_Click(object sender, EventArgs e)
        {

        }
    }
}
