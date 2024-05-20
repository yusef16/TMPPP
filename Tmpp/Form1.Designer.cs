namespace Tmpp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Members_t = new Label();
            Members_p = new Panel();
            comboBox_genre = new ComboBox();
            label3 = new Label();
            Save_btn_members = new Button();
            textBox_email = new TextBox();
            Email = new Label();
            textBox_phonenumber = new TextBox();
            label_phonenumber = new Label();
            textBox_name = new TextBox();
            textBox_Lastname = new TextBox();
            Name_members = new Label();
            Lastname_members = new Label();
            Memberships_p = new Panel();
            label_pret = new Label();
            label_durata = new Label();
            button_save_Membership = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label_numeabonament = new Label();
            label5 = new Label();
            Inscriere_p = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            Coach_p = new Panel();
            Save_btn_coach = new Button();
            textBox_phoneCoach = new TextBox();
            textBox_emailCoach = new TextBox();
            textBox_nameCoach = new TextBox();
            textBox_lastnameCoach = new TextBox();
            label_phonenumbercoach = new Label();
            label_email = new Label();
            label_namecoach = new Label();
            Lastname_Coach = new Label();
            Coach_t = new Label();
            Members_main_btn = new Button();
            Coach_main_btn = new Button();
            button_Memberships = new Button();
            button_membership_subscription = new Button();
            button_search = new Button();
            comboBox_antrenor_inscriere = new ComboBox();
            label7 = new Label();
            Members_p.SuspendLayout();
            Memberships_p.SuspendLayout();
            Inscriere_p.SuspendLayout();
            Coach_p.SuspendLayout();
            SuspendLayout();
            // 
            // Members_t
            // 
            Members_t.AutoSize = true;
            Members_t.Location = new Point(577, 31);
            Members_t.Name = "Members_t";
            Members_t.Size = new Size(74, 25);
            Members_t.TabIndex = 0;
            Members_t.Text = "Membri";
            // 
            // Members_p
            // 
            Members_p.Controls.Add(comboBox_genre);
            Members_p.Controls.Add(label3);
            Members_p.Controls.Add(Save_btn_members);
            Members_p.Controls.Add(textBox_email);
            Members_p.Controls.Add(Email);
            Members_p.Controls.Add(textBox_phonenumber);
            Members_p.Controls.Add(label_phonenumber);
            Members_p.Controls.Add(textBox_name);
            Members_p.Controls.Add(textBox_Lastname);
            Members_p.Controls.Add(Name_members);
            Members_p.Controls.Add(Lastname_members);
            Members_p.Controls.Add(Members_t);
            Members_p.Location = new Point(17, 113);
            Members_p.Name = "Members_p";
            Members_p.Size = new Size(1346, 709);
            Members_p.TabIndex = 1;
            // 
            // comboBox_genre
            // 
            comboBox_genre.FormattingEnabled = true;
            comboBox_genre.Items.AddRange(new object[] { "M", "F" });
            comboBox_genre.Location = new Point(725, 159);
            comboBox_genre.Name = "comboBox_genre";
            comboBox_genre.Size = new Size(309, 33);
            comboBox_genre.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(722, 108);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 12;
            label3.Text = "Gen";
            // 
            // Save_btn_members
            // 
            Save_btn_members.Location = new Point(542, 513);
            Save_btn_members.Name = "Save_btn_members";
            Save_btn_members.Size = new Size(181, 73);
            Save_btn_members.TabIndex = 11;
            Save_btn_members.Text = "Save";
            Save_btn_members.UseVisualStyleBackColor = true;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(722, 278);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(312, 31);
            textBox_email.TabIndex = 8;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(722, 226);
            Email.Name = "Email";
            Email.Size = new Size(54, 25);
            Email.TabIndex = 7;
            Email.Text = "Email";
            // 
            // textBox_phonenumber
            // 
            textBox_phonenumber.Location = new Point(142, 379);
            textBox_phonenumber.Name = "textBox_phonenumber";
            textBox_phonenumber.Size = new Size(338, 31);
            textBox_phonenumber.TabIndex = 6;
            // 
            // label_phonenumber
            // 
            label_phonenumber.AutoSize = true;
            label_phonenumber.Location = new Point(142, 318);
            label_phonenumber.Name = "label_phonenumber";
            label_phonenumber.Size = new Size(93, 25);
            label_phonenumber.TabIndex = 5;
            label_phonenumber.Text = "Nr_telefon";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(142, 257);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(338, 31);
            textBox_name.TabIndex = 4;
            // 
            // textBox_Lastname
            // 
            textBox_Lastname.Location = new Point(142, 153);
            textBox_Lastname.Name = "textBox_Lastname";
            textBox_Lastname.Size = new Size(338, 31);
            textBox_Lastname.TabIndex = 3;
            // 
            // Name_members
            // 
            Name_members.AutoSize = true;
            Name_members.Location = new Point(142, 211);
            Name_members.Name = "Name_members";
            Name_members.Size = new Size(72, 25);
            Name_members.TabIndex = 2;
            Name_members.Text = "Preume";
            // 
            // Lastname_members
            // 
            Lastname_members.AutoSize = true;
            Lastname_members.Location = new Point(142, 107);
            Lastname_members.Name = "Lastname_members";
            Lastname_members.Size = new Size(60, 25);
            Lastname_members.TabIndex = 1;
            Lastname_members.Text = "Nume";
            // 
            // Memberships_p
            // 
            Memberships_p.Controls.Add(label_pret);
            Memberships_p.Controls.Add(label_durata);
            Memberships_p.Controls.Add(button_save_Membership);
            Memberships_p.Controls.Add(textBox1);
            Memberships_p.Controls.Add(textBox2);
            Memberships_p.Controls.Add(textBox4);
            Memberships_p.Controls.Add(label_numeabonament);
            Memberships_p.Controls.Add(label5);
            Memberships_p.Location = new Point(12, 113);
            Memberships_p.Name = "Memberships_p";
            Memberships_p.Size = new Size(1334, 700);
            Memberships_p.TabIndex = 10;
            // 
            // label_pret
            // 
            label_pret.AutoSize = true;
            label_pret.Location = new Point(212, 348);
            label_pret.Name = "label_pret";
            label_pret.Size = new Size(43, 25);
            label_pret.TabIndex = 11;
            label_pret.Text = "Pret";
            // 
            // label_durata
            // 
            label_durata.AutoSize = true;
            label_durata.Location = new Point(212, 226);
            label_durata.Name = "label_durata";
            label_durata.Size = new Size(65, 25);
            label_durata.TabIndex = 10;
            label_durata.Text = "Durata";
            // 
            // button_save_Membership
            // 
            button_save_Membership.Location = new Point(560, 516);
            button_save_Membership.Name = "button_save_Membership";
            button_save_Membership.Size = new Size(112, 34);
            button_save_Membership.TabIndex = 9;
            button_save_Membership.Text = "Save";
            button_save_Membership.UseVisualStyleBackColor = true;
            button_save_Membership.Click += button_save_Membership_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 392);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 275);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(212, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 31);
            textBox4.TabIndex = 5;
            // 
            // label_numeabonament
            // 
            label_numeabonament.AutoSize = true;
            label_numeabonament.Location = new Point(212, 104);
            label_numeabonament.Name = "label_numeabonament";
            label_numeabonament.Size = new Size(148, 25);
            label_numeabonament.TabIndex = 1;
            label_numeabonament.Text = "Tipul_abonament";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(577, 31);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 0;
            label5.Text = "Abonamente";
            // 
            // Inscriere_p
            // 
            Inscriere_p.Controls.Add(label7);
            Inscriere_p.Controls.Add(comboBox_antrenor_inscriere);
            Inscriere_p.Controls.Add(label1);
            Inscriere_p.Controls.Add(label2);
            Inscriere_p.Controls.Add(button1);
            Inscriere_p.Controls.Add(textBox5);
            Inscriere_p.Controls.Add(textBox6);
            Inscriere_p.Controls.Add(textBox7);
            Inscriere_p.Controls.Add(label4);
            Inscriere_p.Controls.Add(label6);
            Inscriere_p.Location = new Point(20, 110);
            Inscriere_p.Name = "Inscriere_p";
            Inscriere_p.Size = new Size(1337, 706);
            Inscriere_p.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 348);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 11;
            label1.Text = "Pret";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 226);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 10;
            label2.Text = "Durata";
            // 
            // button1
            // 
            button1.Location = new Point(560, 516);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(212, 392);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(225, 31);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(212, 275);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(225, 31);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(212, 153);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(224, 31);
            textBox7.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 104);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 1;
            label4.Text = "Nume_abonament";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(577, 31);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 0;
            label6.Text = "Inscriere membri";
            // 
            // Coach_p
            // 
            Coach_p.Controls.Add(Save_btn_coach);
            Coach_p.Controls.Add(textBox_phoneCoach);
            Coach_p.Controls.Add(textBox_emailCoach);
            Coach_p.Controls.Add(textBox_nameCoach);
            Coach_p.Controls.Add(textBox_lastnameCoach);
            Coach_p.Controls.Add(label_phonenumbercoach);
            Coach_p.Controls.Add(label_email);
            Coach_p.Controls.Add(label_namecoach);
            Coach_p.Controls.Add(Lastname_Coach);
            Coach_p.Controls.Add(Coach_t);
            Coach_p.Location = new Point(20, 104);
            Coach_p.Name = "Coach_p";
            Coach_p.Size = new Size(1346, 712);
            Coach_p.TabIndex = 2;
            // 
            // Save_btn_coach
            // 
            Save_btn_coach.Location = new Point(539, 440);
            Save_btn_coach.Name = "Save_btn_coach";
            Save_btn_coach.Size = new Size(112, 34);
            Save_btn_coach.TabIndex = 9;
            Save_btn_coach.Text = "Save";
            Save_btn_coach.UseVisualStyleBackColor = true;
            // 
            // textBox_phoneCoach
            // 
            textBox_phoneCoach.Location = new Point(685, 293);
            textBox_phoneCoach.Name = "textBox_phoneCoach";
            textBox_phoneCoach.Size = new Size(225, 31);
            textBox_phoneCoach.TabIndex = 8;
            // 
            // textBox_emailCoach
            // 
            textBox_emailCoach.Location = new Point(685, 153);
            textBox_emailCoach.Name = "textBox_emailCoach";
            textBox_emailCoach.Size = new Size(225, 31);
            textBox_emailCoach.TabIndex = 7;
            // 
            // textBox_nameCoach
            // 
            textBox_nameCoach.Location = new Point(212, 285);
            textBox_nameCoach.Name = "textBox_nameCoach";
            textBox_nameCoach.Size = new Size(224, 31);
            textBox_nameCoach.TabIndex = 6;
            // 
            // textBox_lastnameCoach
            // 
            textBox_lastnameCoach.Location = new Point(212, 153);
            textBox_lastnameCoach.Name = "textBox_lastnameCoach";
            textBox_lastnameCoach.Size = new Size(224, 31);
            textBox_lastnameCoach.TabIndex = 5;
            // 
            // label_phonenumbercoach
            // 
            label_phonenumbercoach.AutoSize = true;
            label_phonenumbercoach.Location = new Point(685, 234);
            label_phonenumbercoach.Name = "label_phonenumbercoach";
            label_phonenumbercoach.Size = new Size(68, 25);
            label_phonenumbercoach.TabIndex = 4;
            label_phonenumbercoach.Text = "Telefon";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(685, 107);
            label_email.Name = "label_email";
            label_email.Size = new Size(54, 25);
            label_email.TabIndex = 3;
            label_email.Text = "Email";
            // 
            // label_namecoach
            // 
            label_namecoach.AutoSize = true;
            label_namecoach.Location = new Point(212, 220);
            label_namecoach.Name = "label_namecoach";
            label_namecoach.Size = new Size(82, 25);
            label_namecoach.TabIndex = 2;
            label_namecoach.Text = "Prenume";
            // 
            // Lastname_Coach
            // 
            Lastname_Coach.AutoSize = true;
            Lastname_Coach.Location = new Point(212, 98);
            Lastname_Coach.Name = "Lastname_Coach";
            Lastname_Coach.Size = new Size(60, 25);
            Lastname_Coach.TabIndex = 1;
            Lastname_Coach.Text = "Nume";
            // 
            // Coach_t
            // 
            Coach_t.AutoSize = true;
            Coach_t.Location = new Point(577, 31);
            Coach_t.Name = "Coach_t";
            Coach_t.Size = new Size(86, 25);
            Coach_t.TabIndex = 0;
            Coach_t.Text = "Antrenori";
            // 
            // Members_main_btn
            // 
            Members_main_btn.Location = new Point(67, 43);
            Members_main_btn.Name = "Members_main_btn";
            Members_main_btn.Size = new Size(112, 34);
            Members_main_btn.TabIndex = 2;
            Members_main_btn.Text = "Membri";
            Members_main_btn.UseVisualStyleBackColor = true;
            Members_main_btn.Click += Members_main_btn_Click;
            // 
            // Coach_main_btn
            // 
            Coach_main_btn.Location = new Point(242, 43);
            Coach_main_btn.Name = "Coach_main_btn";
            Coach_main_btn.Size = new Size(112, 34);
            Coach_main_btn.TabIndex = 3;
            Coach_main_btn.Text = "Antrenori";
            Coach_main_btn.UseVisualStyleBackColor = true;
            Coach_main_btn.Click += Coach_main_btn_Click;
            // 
            // button_Memberships
            // 
            button_Memberships.Location = new Point(416, 43);
            button_Memberships.Name = "button_Memberships";
            button_Memberships.Size = new Size(149, 34);
            button_Memberships.TabIndex = 4;
            button_Memberships.Text = "Abonamente";
            button_Memberships.UseVisualStyleBackColor = true;
            button_Memberships.Click += button_Memberships_Click;
            // 
            // button_membership_subscription
            // 
            button_membership_subscription.Location = new Point(644, 43);
            button_membership_subscription.Name = "button_membership_subscription";
            button_membership_subscription.Size = new Size(112, 34);
            button_membership_subscription.TabIndex = 11;
            button_membership_subscription.Text = "Inscriere";
            button_membership_subscription.UseVisualStyleBackColor = true;
            button_membership_subscription.Click += button_membership_subscription_Click;
            // 
            // button_search
            // 
            button_search.Location = new Point(863, 43);
            button_search.Name = "button_search";
            button_search.Size = new Size(112, 34);
            button_search.TabIndex = 12;
            button_search.Text = "Cautare";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // comboBox_antrenor_inscriere
            // 
            comboBox_antrenor_inscriere.FormattingEnabled = true;
            comboBox_antrenor_inscriere.Location = new Point(741, 147);
            comboBox_antrenor_inscriere.Name = "comboBox_antrenor_inscriere";
            comboBox_antrenor_inscriere.Size = new Size(182, 33);
            comboBox_antrenor_inscriere.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(745, 102);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 13;
            label7.Text = "Antrenor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 844);
            Controls.Add(button_search);
            Controls.Add(button_membership_subscription);
            Controls.Add(button_Memberships);
            Controls.Add(Coach_main_btn);
            Controls.Add(Members_main_btn);
            Controls.Add(Coach_p);
            Controls.Add(Memberships_p);
            Controls.Add(Members_p);
            Controls.Add(Inscriere_p);
            Name = "Form1";
            Text = "Gym";
            Members_p.ResumeLayout(false);
            Members_p.PerformLayout();
            Memberships_p.ResumeLayout(false);
            Memberships_p.PerformLayout();
            Inscriere_p.ResumeLayout(false);
            Inscriere_p.PerformLayout();
            Coach_p.ResumeLayout(false);
            Coach_p.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Members_t;
        private Panel Members_p;
        private Panel Coach_p;
        private Label Coach_t;
        private Button Members_main_btn;
        private Button Coach_main_btn;
        private Label Name_members;
        private Label Lastname_members;
        private TextBox textBox_phonenumber;
        private Label label_phonenumber;
        private TextBox textBox_name;
        private TextBox textBox_Lastname;
        private TextBox textBox_email;
        private Label Email;
        private Button Save_btn_members;
        private TextBox textBox_nameCoach;
        private TextBox textBox_lastnameCoach;
        private Label label_phonenumbercoach;
        private Label label_email;
        private Label label_namecoach;
        private Label Lastname_Coach;
        private Button Save_btn_coach;
        private TextBox textBox_phoneCoach;
        private TextBox textBox_emailCoach;
        private Panel Memberships_p;
        private Button button_save_Membership;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label_durata;
        private Label label_pret;
        private Label label3;
        private Label label_numeabonament;
        private Label label5;
        private Button button_Memberships;
        private Panel Inscriere_p;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label4;
        private Label label6;
        private Button button_membership_subscription;
        private ComboBox comboBox_genre;
        private Button button_search;
        private Label label7;
        private ComboBox comboBox_antrenor_inscriere;
    }
}
