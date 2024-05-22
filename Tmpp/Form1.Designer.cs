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
            panel_r = new Panel();
            textBox1_email_receptionist = new TextBox();
            label9 = new Label();
            button_delete_receptionist = new Button();
            textBox_nrtelefon_receptionist = new TextBox();
            label_nrtelefon_receptionist = new Label();
            textBox_username_receptionist = new TextBox();
            label_username_receptionist = new Label();
            dataGridView_receptionist = new DataGridView();
            button_save_receptionist = new Button();
            label_admin = new Label();
            checkBox_isadmin = new CheckBox();
            label_parola_receptionist = new Label();
            textBox_parola_receptionist = new TextBox();
            textBox_prenume_receptionist = new TextBox();
            label8 = new Label();
            textBox_nume_receptionist = new TextBox();
            label_nume_receptionist = new Label();
            label_receptionist = new Label();
            Inscriere_p = new Panel();
            button1_save_date_excel = new Button();
            comboBox1_gen_inscriere = new ComboBox();
            label10 = new Label();
            label2 = new Label();
            textBox_pret_inscriere = new TextBox();
            label1 = new Label();
            comboBox1_abonamente = new ComboBox();
            comboBox_nume_prenume_membri = new ComboBox();
            label7 = new Label();
            comboBox_antrenor_inscriere = new ComboBox();
            button_inscriere = new Button();
            label4 = new Label();
            label6 = new Label();
            panel_search = new Panel();
            textBox_tip_abonament = new TextBox();
            label1_tip_abonament = new Label();
            button_cautare_antrenor = new Button();
            button_cautare = new Button();
            textBox_cautare_prenume = new TextBox();
            textBox_cautare_nume = new TextBox();
            label_prenume_cautare = new Label();
            label_nume_cautare = new Label();
            dataGridView_cautare_rezultat = new DataGridView();
            label_search = new Label();
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
            Memberships_p = new Panel();
            dataGridView_abonamente = new DataGridView();
            Durata_combo = new ComboBox();
            comboBox_tip = new ComboBox();
            label_pret = new Label();
            label_durata = new Label();
            button_save_Membership = new Button();
            textBox_pretAbonamente = new TextBox();
            label_numeabonament = new Label();
            label5 = new Label();
            Members_main_btn = new Button();
            Coach_main_btn = new Button();
            button_Memberships = new Button();
            button_membership_subscription = new Button();
            button_search = new Button();
            panel1 = new Panel();
            button_receptionist = new Button();
            button_cautare_abonamente = new Button();
            Members_p.SuspendLayout();
            panel_r.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_receptionist).BeginInit();
            Inscriere_p.SuspendLayout();
            panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_cautare_rezultat).BeginInit();
            Coach_p.SuspendLayout();
            Memberships_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_abonamente).BeginInit();
            panel1.SuspendLayout();
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
            Members_p.Location = new Point(1568, 60);
            Members_p.Name = "Members_p";
            Members_p.Size = new Size(1340, 700);
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
            Save_btn_members.Click += Save_btn_members_Click;
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
            // panel_r
            // 
            panel_r.Controls.Add(textBox1_email_receptionist);
            panel_r.Controls.Add(label9);
            panel_r.Controls.Add(button_delete_receptionist);
            panel_r.Controls.Add(textBox_nrtelefon_receptionist);
            panel_r.Controls.Add(label_nrtelefon_receptionist);
            panel_r.Controls.Add(textBox_username_receptionist);
            panel_r.Controls.Add(label_username_receptionist);
            panel_r.Controls.Add(dataGridView_receptionist);
            panel_r.Controls.Add(button_save_receptionist);
            panel_r.Controls.Add(label_admin);
            panel_r.Controls.Add(checkBox_isadmin);
            panel_r.Controls.Add(label_parola_receptionist);
            panel_r.Controls.Add(textBox_parola_receptionist);
            panel_r.Controls.Add(textBox_prenume_receptionist);
            panel_r.Controls.Add(label8);
            panel_r.Controls.Add(textBox_nume_receptionist);
            panel_r.Controls.Add(label_nume_receptionist);
            panel_r.Controls.Add(label_receptionist);
            panel_r.Location = new Point(1736, 92);
            panel_r.Name = "panel_r";
            panel_r.Size = new Size(1340, 700);
            panel_r.TabIndex = 15;
            panel_r.Paint += panel_r_Paint;
            // 
            // textBox1_email_receptionist
            // 
            textBox1_email_receptionist.Location = new Point(443, 297);
            textBox1_email_receptionist.Name = "textBox1_email_receptionist";
            textBox1_email_receptionist.Size = new Size(216, 31);
            textBox1_email_receptionist.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(443, 245);
            label9.Name = "label9";
            label9.Size = new Size(54, 25);
            label9.TabIndex = 16;
            label9.Text = "Email";
            label9.Click += label9_Click;
            // 
            // button_delete_receptionist
            // 
            button_delete_receptionist.Location = new Point(684, 617);
            button_delete_receptionist.Name = "button_delete_receptionist";
            button_delete_receptionist.Size = new Size(112, 34);
            button_delete_receptionist.TabIndex = 15;
            button_delete_receptionist.Text = "Delete";
            button_delete_receptionist.UseVisualStyleBackColor = true;
            // 
            // textBox_nrtelefon_receptionist
            // 
            textBox_nrtelefon_receptionist.Location = new Point(443, 160);
            textBox_nrtelefon_receptionist.Name = "textBox_nrtelefon_receptionist";
            textBox_nrtelefon_receptionist.Size = new Size(216, 31);
            textBox_nrtelefon_receptionist.TabIndex = 14;
            // 
            // label_nrtelefon_receptionist
            // 
            label_nrtelefon_receptionist.AutoSize = true;
            label_nrtelefon_receptionist.Location = new Point(464, 108);
            label_nrtelefon_receptionist.Name = "label_nrtelefon_receptionist";
            label_nrtelefon_receptionist.Size = new Size(93, 25);
            label_nrtelefon_receptionist.TabIndex = 13;
            label_nrtelefon_receptionist.Text = "Nr_telefon";
            // 
            // textBox_username_receptionist
            // 
            textBox_username_receptionist.Location = new Point(135, 388);
            textBox_username_receptionist.Name = "textBox_username_receptionist";
            textBox_username_receptionist.Size = new Size(220, 31);
            textBox_username_receptionist.TabIndex = 12;
            // 
            // label_username_receptionist
            // 
            label_username_receptionist.AutoSize = true;
            label_username_receptionist.Location = new Point(133, 351);
            label_username_receptionist.Name = "label_username_receptionist";
            label_username_receptionist.Size = new Size(91, 25);
            label_username_receptionist.TabIndex = 11;
            label_username_receptionist.Text = "Username";
            // 
            // dataGridView_receptionist
            // 
            dataGridView_receptionist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_receptionist.Location = new Point(708, 164);
            dataGridView_receptionist.Name = "dataGridView_receptionist";
            dataGridView_receptionist.RowHeadersWidth = 62;
            dataGridView_receptionist.Size = new Size(579, 347);
            dataGridView_receptionist.TabIndex = 10;
            // 
            // button_save_receptionist
            // 
            button_save_receptionist.Location = new Point(411, 617);
            button_save_receptionist.Name = "button_save_receptionist";
            button_save_receptionist.Size = new Size(112, 34);
            button_save_receptionist.TabIndex = 9;
            button_save_receptionist.Text = "Save";
            button_save_receptionist.UseVisualStyleBackColor = true;
            button_save_receptionist.Click += button_save_receptionist_Click_1;
            // 
            // label_admin
            // 
            label_admin.AutoSize = true;
            label_admin.Location = new Point(458, 386);
            label_admin.Name = "label_admin";
            label_admin.Size = new Size(65, 25);
            label_admin.TabIndex = 8;
            label_admin.Text = "Admin";
            // 
            // checkBox_isadmin
            // 
            checkBox_isadmin.AutoSize = true;
            checkBox_isadmin.Location = new Point(458, 437);
            checkBox_isadmin.Name = "checkBox_isadmin";
            checkBox_isadmin.Size = new Size(91, 29);
            checkBox_isadmin.TabIndex = 7;
            checkBox_isadmin.Text = "Admin";
            checkBox_isadmin.UseVisualStyleBackColor = true;
            // 
            // label_parola_receptionist
            // 
            label_parola_receptionist.AutoSize = true;
            label_parola_receptionist.Location = new Point(133, 452);
            label_parola_receptionist.Name = "label_parola_receptionist";
            label_parola_receptionist.Size = new Size(60, 25);
            label_parola_receptionist.TabIndex = 6;
            label_parola_receptionist.Text = "Parola";
            // 
            // textBox_parola_receptionist
            // 
            textBox_parola_receptionist.Location = new Point(133, 500);
            textBox_parola_receptionist.Name = "textBox_parola_receptionist";
            textBox_parola_receptionist.Size = new Size(216, 31);
            textBox_parola_receptionist.TabIndex = 5;
            // 
            // textBox_prenume_receptionist
            // 
            textBox_prenume_receptionist.Location = new Point(135, 297);
            textBox_prenume_receptionist.Name = "textBox_prenume_receptionist";
            textBox_prenume_receptionist.Size = new Size(222, 31);
            textBox_prenume_receptionist.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(137, 245);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 3;
            label8.Text = "Prenume";
            // 
            // textBox_nume_receptionist
            // 
            textBox_nume_receptionist.Location = new Point(133, 162);
            textBox_nume_receptionist.Name = "textBox_nume_receptionist";
            textBox_nume_receptionist.Size = new Size(222, 31);
            textBox_nume_receptionist.TabIndex = 2;
            // 
            // label_nume_receptionist
            // 
            label_nume_receptionist.AutoSize = true;
            label_nume_receptionist.Location = new Point(135, 104);
            label_nume_receptionist.Name = "label_nume_receptionist";
            label_nume_receptionist.Size = new Size(60, 25);
            label_nume_receptionist.TabIndex = 1;
            label_nume_receptionist.Text = "Nume";
            // 
            // label_receptionist
            // 
            label_receptionist.AutoSize = true;
            label_receptionist.Location = new Point(577, 56);
            label_receptionist.Name = "label_receptionist";
            label_receptionist.Size = new Size(108, 25);
            label_receptionist.TabIndex = 0;
            label_receptionist.Text = "Receptionist";
            // 
            // Inscriere_p
            // 
            Inscriere_p.Controls.Add(button1_save_date_excel);
            Inscriere_p.Controls.Add(comboBox1_gen_inscriere);
            Inscriere_p.Controls.Add(label10);
            Inscriere_p.Controls.Add(label2);
            Inscriere_p.Controls.Add(textBox_pret_inscriere);
            Inscriere_p.Controls.Add(label1);
            Inscriere_p.Controls.Add(comboBox1_abonamente);
            Inscriere_p.Controls.Add(comboBox_nume_prenume_membri);
            Inscriere_p.Controls.Add(label7);
            Inscriere_p.Controls.Add(comboBox_antrenor_inscriere);
            Inscriere_p.Controls.Add(button_inscriere);
            Inscriere_p.Controls.Add(label4);
            Inscriere_p.Controls.Add(label6);
            Inscriere_p.Location = new Point(1626, 365);
            Inscriere_p.Name = "Inscriere_p";
            Inscriere_p.Size = new Size(1340, 700);
            Inscriere_p.TabIndex = 12;
            // 
            // button1_save_date_excel
            // 
            button1_save_date_excel.Location = new Point(707, 558);
            button1_save_date_excel.Name = "button1_save_date_excel";
            button1_save_date_excel.Size = new Size(203, 34);
            button1_save_date_excel.TabIndex = 21;
            button1_save_date_excel.Text = "Excel date membri";
            button1_save_date_excel.UseVisualStyleBackColor = true;
            button1_save_date_excel.Click += button1_save_date_excel_Click;
            // 
            // comboBox1_gen_inscriere
            // 
            comboBox1_gen_inscriere.FormattingEnabled = true;
            comboBox1_gen_inscriere.Items.AddRange(new object[] { "M", "F" });
            comboBox1_gen_inscriere.Location = new Point(209, 421);
            comboBox1_gen_inscriere.Name = "comboBox1_gen_inscriere";
            comboBox1_gen_inscriere.Size = new Size(228, 33);
            comboBox1_gen_inscriere.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(206, 370);
            label10.Name = "label10";
            label10.Size = new Size(43, 25);
            label10.TabIndex = 19;
            label10.Text = "Gen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(651, 245);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 18;
            label2.Text = "Pret";
            // 
            // textBox_pret_inscriere
            // 
            textBox_pret_inscriere.Location = new Point(647, 285);
            textBox_pret_inscriere.Name = "textBox_pret_inscriere";
            textBox_pret_inscriere.Size = new Size(184, 31);
            textBox_pret_inscriere.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 245);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 16;
            label1.Text = "Abonament";
            // 
            // comboBox1_abonamente
            // 
            comboBox1_abonamente.FormattingEnabled = true;
            comboBox1_abonamente.Location = new Point(206, 286);
            comboBox1_abonamente.Name = "comboBox1_abonamente";
            comboBox1_abonamente.Size = new Size(231, 33);
            comboBox1_abonamente.TabIndex = 15;
            // 
            // comboBox_nume_prenume_membri
            // 
            comboBox_nume_prenume_membri.FormattingEnabled = true;
            comboBox_nume_prenume_membri.Location = new Point(211, 162);
            comboBox_nume_prenume_membri.Name = "comboBox_nume_prenume_membri";
            comboBox_nume_prenume_membri.Size = new Size(226, 33);
            comboBox_nume_prenume_membri.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(651, 115);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 13;
            label7.Text = "Antrenor";
            // 
            // comboBox_antrenor_inscriere
            // 
            comboBox_antrenor_inscriere.FormattingEnabled = true;
            comboBox_antrenor_inscriere.Location = new Point(647, 160);
            comboBox_antrenor_inscriere.Name = "comboBox_antrenor_inscriere";
            comboBox_antrenor_inscriere.Size = new Size(182, 33);
            comboBox_antrenor_inscriere.TabIndex = 12;
            // 
            // button_inscriere
            // 
            button_inscriere.Location = new Point(258, 558);
            button_inscriere.Name = "button_inscriere";
            button_inscriere.Size = new Size(112, 34);
            button_inscriere.TabIndex = 9;
            button_inscriere.Text = "Save";
            button_inscriere.UseVisualStyleBackColor = true;
            button_inscriere.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 104);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 1;
            label4.Text = "Nume membru";
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
            // panel_search
            // 
            panel_search.Controls.Add(button_cautare_abonamente);
            panel_search.Controls.Add(textBox_tip_abonament);
            panel_search.Controls.Add(label1_tip_abonament);
            panel_search.Controls.Add(button_cautare_antrenor);
            panel_search.Controls.Add(button_cautare);
            panel_search.Controls.Add(textBox_cautare_prenume);
            panel_search.Controls.Add(textBox_cautare_nume);
            panel_search.Controls.Add(label_prenume_cautare);
            panel_search.Controls.Add(label_nume_cautare);
            panel_search.Controls.Add(dataGridView_cautare_rezultat);
            panel_search.Controls.Add(label_search);
            panel_search.Location = new Point(40, 131);
            panel_search.Name = "panel_search";
            panel_search.Size = new Size(1340, 700);
            panel_search.TabIndex = 18;
            // 
            // textBox_tip_abonament
            // 
            textBox_tip_abonament.Location = new Point(853, 203);
            textBox_tip_abonament.Name = "textBox_tip_abonament";
            textBox_tip_abonament.Size = new Size(150, 31);
            textBox_tip_abonament.TabIndex = 10;
            // 
            // label1_tip_abonament
            // 
            label1_tip_abonament.AutoSize = true;
            label1_tip_abonament.Location = new Point(853, 142);
            label1_tip_abonament.Name = "label1_tip_abonament";
            label1_tip_abonament.Size = new Size(134, 25);
            label1_tip_abonament.TabIndex = 9;
            label1_tip_abonament.Text = "Tip_abonament";
            // 
            // button_cautare_antrenor
            // 
            button_cautare_antrenor.Location = new Point(450, 303);
            button_cautare_antrenor.Name = "button_cautare_antrenor";
            button_cautare_antrenor.Size = new Size(181, 34);
            button_cautare_antrenor.TabIndex = 7;
            button_cautare_antrenor.Text = "Cautare Antrenor";
            button_cautare_antrenor.UseVisualStyleBackColor = true;
            button_cautare_antrenor.Click += button_cautare_antrenor_Click;
            // 
            // button_cautare
            // 
            button_cautare.Location = new Point(154, 303);
            button_cautare.Name = "button_cautare";
            button_cautare.Size = new Size(162, 34);
            button_cautare.TabIndex = 6;
            button_cautare.Text = "Cautare Membru";
            button_cautare.UseVisualStyleBackColor = true;
            button_cautare.Click += button_cautare_Click;
            // 
            // textBox_cautare_prenume
            // 
            textBox_cautare_prenume.Location = new Point(525, 203);
            textBox_cautare_prenume.Name = "textBox_cautare_prenume";
            textBox_cautare_prenume.Size = new Size(150, 31);
            textBox_cautare_prenume.TabIndex = 5;
            // 
            // textBox_cautare_nume
            // 
            textBox_cautare_nume.Location = new Point(166, 211);
            textBox_cautare_nume.Name = "textBox_cautare_nume";
            textBox_cautare_nume.Size = new Size(150, 31);
            textBox_cautare_nume.TabIndex = 4;
            // 
            // label_prenume_cautare
            // 
            label_prenume_cautare.AutoSize = true;
            label_prenume_cautare.Location = new Point(525, 142);
            label_prenume_cautare.Name = "label_prenume_cautare";
            label_prenume_cautare.Size = new Size(82, 25);
            label_prenume_cautare.TabIndex = 3;
            label_prenume_cautare.Text = "Prenume";
            // 
            // label_nume_cautare
            // 
            label_nume_cautare.AutoSize = true;
            label_nume_cautare.Location = new Point(186, 142);
            label_nume_cautare.Name = "label_nume_cautare";
            label_nume_cautare.Size = new Size(60, 25);
            label_nume_cautare.TabIndex = 2;
            label_nume_cautare.Text = "Nume";
            // 
            // dataGridView_cautare_rezultat
            // 
            dataGridView_cautare_rezultat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_cautare_rezultat.Location = new Point(61, 370);
            dataGridView_cautare_rezultat.Name = "dataGridView_cautare_rezultat";
            dataGridView_cautare_rezultat.RowHeadersWidth = 62;
            dataGridView_cautare_rezultat.Size = new Size(1169, 225);
            dataGridView_cautare_rezultat.TabIndex = 1;
            // 
            // label_search
            // 
            label_search.AutoSize = true;
            label_search.Location = new Point(571, 43);
            label_search.Name = "label_search";
            label_search.Size = new Size(72, 25);
            label_search.TabIndex = 0;
            label_search.Text = "Cautare";
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
            Coach_p.Location = new Point(1664, 162);
            Coach_p.Name = "Coach_p";
            Coach_p.Size = new Size(1340, 700);
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
            Save_btn_coach.Click += Save_btn_coach_Click;
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
            // Memberships_p
            // 
            Memberships_p.Controls.Add(dataGridView_abonamente);
            Memberships_p.Controls.Add(Durata_combo);
            Memberships_p.Controls.Add(comboBox_tip);
            Memberships_p.Controls.Add(label_pret);
            Memberships_p.Controls.Add(label_durata);
            Memberships_p.Controls.Add(button_save_Membership);
            Memberships_p.Controls.Add(textBox_pretAbonamente);
            Memberships_p.Controls.Add(label_numeabonament);
            Memberships_p.Controls.Add(label5);
            Memberships_p.Location = new Point(1518, 556);
            Memberships_p.Name = "Memberships_p";
            Memberships_p.Size = new Size(1340, 700);
            Memberships_p.TabIndex = 10;
            // 
            // dataGridView_abonamente
            // 
            dataGridView_abonamente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_abonamente.Location = new Point(749, 159);
            dataGridView_abonamente.Name = "dataGridView_abonamente";
            dataGridView_abonamente.RowHeadersWidth = 62;
            dataGridView_abonamente.Size = new Size(556, 289);
            dataGridView_abonamente.TabIndex = 14;
            // 
            // Durata_combo
            // 
            Durata_combo.FormattingEnabled = true;
            Durata_combo.Items.AddRange(new object[] { "1 luna", "3 luni", "6 luni", "1 an" });
            Durata_combo.Location = new Point(209, 282);
            Durata_combo.Name = "Durata_combo";
            Durata_combo.Size = new Size(228, 33);
            Durata_combo.TabIndex = 13;
            // 
            // comboBox_tip
            // 
            comboBox_tip.FormattingEnabled = true;
            comboBox_tip.Items.AddRange(new object[] { "Part time", "Full time" });
            comboBox_tip.Location = new Point(212, 164);
            comboBox_tip.Name = "comboBox_tip";
            comboBox_tip.Size = new Size(225, 33);
            comboBox_tip.TabIndex = 12;
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
            // textBox_pretAbonamente
            // 
            textBox_pretAbonamente.Location = new Point(212, 392);
            textBox_pretAbonamente.Name = "textBox_pretAbonamente";
            textBox_pretAbonamente.Size = new Size(225, 31);
            textBox_pretAbonamente.TabIndex = 8;
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
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(button_receptionist);
            panel1.Location = new Point(17, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 87);
            panel1.TabIndex = 13;
            // 
            // button_receptionist
            // 
            button_receptionist.Location = new Point(1068, 32);
            button_receptionist.Name = "button_receptionist";
            button_receptionist.Size = new Size(128, 34);
            button_receptionist.TabIndex = 0;
            button_receptionist.Text = "Receptioneri";
            button_receptionist.UseVisualStyleBackColor = true;
            button_receptionist.Click += button_receptionist_Click;
            // 
            // button_cautare_abonamente
            // 
            button_cautare_abonamente.Location = new Point(839, 303);
            button_cautare_abonamente.Name = "button_cautare_abonamente";
            button_cautare_abonamente.Size = new Size(230, 34);
            button_cautare_abonamente.TabIndex = 11;
            button_cautare_abonamente.Text = "Cautare abonamente";
            button_cautare_abonamente.UseVisualStyleBackColor = true;
            button_cautare_abonamente.Click += button_cautare_abonamente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1839, 1145);
            Controls.Add(Members_p);
            Controls.Add(panel_r);
            Controls.Add(Coach_p);
            Controls.Add(Inscriere_p);
            Controls.Add(Memberships_p);
            Controls.Add(button_search);
            Controls.Add(button_membership_subscription);
            Controls.Add(button_Memberships);
            Controls.Add(panel_search);
            Controls.Add(Coach_main_btn);
            Controls.Add(Members_main_btn);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Gym";
            Members_p.ResumeLayout(false);
            Members_p.PerformLayout();
            panel_r.ResumeLayout(false);
            panel_r.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_receptionist).EndInit();
            Inscriere_p.ResumeLayout(false);
            Inscriere_p.PerformLayout();
            panel_search.ResumeLayout(false);
            panel_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_cautare_rezultat).EndInit();
            Coach_p.ResumeLayout(false);
            Coach_p.PerformLayout();
            Memberships_p.ResumeLayout(false);
            Memberships_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_abonamente).EndInit();
            panel1.ResumeLayout(false);
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
        private TextBox textBox_pretAbonamente;
        private Label label_durata;
        private Label label_pret;
        private Label label3;
        private Label label_numeabonament;
        private Label label5;
        private Button button_Memberships;
        private TextBox textBox5;
        private Button button_membership_subscription;
        private ComboBox comboBox_genre;
        private Button button_search;
        private Panel panel1;
        private ComboBox Durata_combo;
        private ComboBox comboBox_tip;
        private DataGridView dataGridView_abonamente;
        private Panel panel_r;
        private CheckBox checkBox_isadmin;
        private Label label_parola_receptionist;
        private TextBox textBox_parola_receptionist;
        private TextBox textBox_prenume_receptionist;
        private Label label8;
        private TextBox textBox_nume_receptionist;
        private Label label_nume_receptionist;
        private Label label_receptionist;
        private Button button_receptionist;
        private TextBox textBox_username_receptionist;
        private Label label_username_receptionist;
        private DataGridView dataGridView_receptionist;
        private Button button_save_receptionist;
        private Label label_admin;
        private Label label_nrtelefon_receptionist;
        private Button button_delete_receptionist;
        private TextBox textBox_nrtelefon_receptionist;
        private TextBox textBox1_email_receptionist;
        private Label label9;
        private Panel panel_search;
        private Label label_search;
        private Panel Inscriere_p;
        private Label label1;
        private ComboBox comboBox1_abonamente;
        private ComboBox comboBox_nume_prenume_membri;
        private Label label7;
        private ComboBox comboBox_antrenor_inscriere;
        private Button button_inscriere;
        private Label label4;
        private Label label6;
        private Label label2;
        private TextBox textBox_pret_inscriere;
        private ComboBox comboBox1_gen_inscriere;
        private Label label10;
        private Button button1_save_date_excel;
        private DataGridView dataGridView_cautare_rezultat;
        private Button button_cautare;
        private TextBox textBox_cautare_prenume;
        private TextBox textBox_cautare_nume;
        private Label label_prenume_cautare;
        private Label label_nume_cautare;
        private Button button_cautare_antrenor;
        private TextBox textBox_tip_abonament;
        private Label label1_tip_abonament;
        private Button button_cautare_abonamente;
    }
}
