namespace Tmpp
{
    partial class Logare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_username_log = new TextBox();
            textBox_password_log = new TextBox();
            panel_log = new Panel();
            button_login = new Button();
            label_password_log = new Label();
            label_username_log = new Label();
            panel_log.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_username_log
            // 
            textBox_username_log.Location = new Point(121, 71);
            textBox_username_log.Name = "textBox_username_log";
            textBox_username_log.Size = new Size(234, 31);
            textBox_username_log.TabIndex = 0;
            // 
            // textBox_password_log
            // 
            textBox_password_log.Location = new Point(241, 243);
            textBox_password_log.Name = "textBox_password_log";
            textBox_password_log.PasswordChar = '*';
            textBox_password_log.Size = new Size(234, 31);
            textBox_password_log.TabIndex = 1;
            // 
            // panel_log
            // 
            panel_log.BackColor = Color.DarkSalmon;
            panel_log.Controls.Add(button_login);
            panel_log.Controls.Add(label_password_log);
            panel_log.Controls.Add(label_username_log);
            panel_log.Controls.Add(textBox_username_log);
            panel_log.Location = new Point(120, 74);
            panel_log.Name = "panel_log";
            panel_log.Size = new Size(493, 301);
            panel_log.TabIndex = 2;
            // 
            // button_login
            // 
            button_login.Location = new Point(167, 234);
            button_login.Name = "button_login";
            button_login.Size = new Size(128, 46);
            button_login.TabIndex = 3;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label_password_log
            // 
            label_password_log.AutoSize = true;
            label_password_log.Location = new Point(121, 123);
            label_password_log.Name = "label_password_log";
            label_password_log.Size = new Size(87, 25);
            label_password_log.TabIndex = 2;
            label_password_log.Text = "Password";
            // 
            // label_username_log
            // 
            label_username_log.AutoSize = true;
            label_username_log.Location = new Point(121, 24);
            label_username_log.Name = "label_username_log";
            label_username_log.Size = new Size(91, 25);
            label_username_log.TabIndex = 1;
            label_username_log.Text = "Username";
            // 
            // Logare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(778, 444);
            Controls.Add(textBox_password_log);
            Controls.Add(panel_log);
            Name = "Logare";
            Text = "Logare";
            panel_log.ResumeLayout(false);
            panel_log.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_username_log;
        private TextBox textBox_password_log;
        private Panel panel_log;
        private Label label_password_log;
        private Label label_username_log;
        private Button button_login;
    }
}