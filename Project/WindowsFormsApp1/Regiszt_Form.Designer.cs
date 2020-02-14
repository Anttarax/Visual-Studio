namespace WindowsFormsApp1
{
    partial class Regiszt_Form
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
            this.UserName = new MetroFramework.Controls.MetroTextBox();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.Vezetéknév = new MetroFramework.Controls.MetroTextBox();
            this.Keresztnév = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroTextBox();
            this.Password2 = new MetroFramework.Controls.MetroTextBox();
            this.Regiszt = new MetroFramework.Controls.MetroButton();
            this.Login_Linklabel = new MetroFramework.Controls.MetroLink();
            this.Username_error = new System.Windows.Forms.Label();
            this.vezeték_error = new System.Windows.Forms.Label();
            this.kereszt_error = new System.Windows.Forms.Label();
            this.jelszó_error = new System.Windows.Forms.Label();
            this.jelszóagain_error = new System.Windows.Forms.Label();
            this.email_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            // 
            // 
            // 
            this.UserName.CustomButton.Image = null;
            this.UserName.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.UserName.CustomButton.Name = "";
            this.UserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserName.CustomButton.TabIndex = 1;
            this.UserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserName.CustomButton.UseSelectable = true;
            this.UserName.CustomButton.Visible = false;
            this.UserName.Lines = new string[0];
            this.UserName.Location = new System.Drawing.Point(189, 158);
            this.UserName.MaxLength = 32767;
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.PromptText = "Felhasználónév";
            this.UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserName.SelectedText = "";
            this.UserName.SelectionLength = 0;
            this.UserName.SelectionStart = 0;
            this.UserName.ShortcutsEnabled = true;
            this.UserName.Size = new System.Drawing.Size(120, 23);
            this.UserName.TabIndex = 11;
            this.UserName.UseSelectable = true;
            this.UserName.WaterMark = "Felhasználónév";
            this.UserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.UserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserName_KeyUp);
            // 
            // email
            // 
            // 
            // 
            // 
            this.email.CustomButton.Image = null;
            this.email.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.email.CustomButton.Name = "";
            this.email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email.CustomButton.TabIndex = 1;
            this.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email.CustomButton.UseSelectable = true;
            this.email.CustomButton.Visible = false;
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(189, 187);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PromptText = "Email cím";
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.ShortcutsEnabled = true;
            this.email.Size = new System.Drawing.Size(120, 23);
            this.email.TabIndex = 12;
            this.email.UseSelectable = true;
            this.email.WaterMark = "Email cím";
            this.email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.email_KeyUp);
            // 
            // Vezetéknév
            // 
            // 
            // 
            // 
            this.Vezetéknév.CustomButton.Image = null;
            this.Vezetéknév.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.Vezetéknév.CustomButton.Name = "";
            this.Vezetéknév.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Vezetéknév.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Vezetéknév.CustomButton.TabIndex = 1;
            this.Vezetéknév.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Vezetéknév.CustomButton.UseSelectable = true;
            this.Vezetéknév.CustomButton.Visible = false;
            this.Vezetéknév.Lines = new string[0];
            this.Vezetéknév.Location = new System.Drawing.Point(189, 216);
            this.Vezetéknév.MaxLength = 32767;
            this.Vezetéknév.Name = "Vezetéknév";
            this.Vezetéknév.PasswordChar = '\0';
            this.Vezetéknév.PromptText = "Vezetéknév";
            this.Vezetéknév.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Vezetéknév.SelectedText = "";
            this.Vezetéknév.SelectionLength = 0;
            this.Vezetéknév.SelectionStart = 0;
            this.Vezetéknév.ShortcutsEnabled = true;
            this.Vezetéknév.Size = new System.Drawing.Size(120, 23);
            this.Vezetéknév.TabIndex = 13;
            this.Vezetéknév.UseSelectable = true;
            this.Vezetéknév.WaterMark = "Vezetéknév";
            this.Vezetéknév.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Vezetéknév.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Keresztnév
            // 
            // 
            // 
            // 
            this.Keresztnév.CustomButton.Image = null;
            this.Keresztnév.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.Keresztnév.CustomButton.Name = "";
            this.Keresztnév.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Keresztnév.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Keresztnév.CustomButton.TabIndex = 1;
            this.Keresztnév.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Keresztnév.CustomButton.UseSelectable = true;
            this.Keresztnév.CustomButton.Visible = false;
            this.Keresztnév.Lines = new string[0];
            this.Keresztnév.Location = new System.Drawing.Point(189, 245);
            this.Keresztnév.MaxLength = 32767;
            this.Keresztnév.Name = "Keresztnév";
            this.Keresztnév.PasswordChar = '\0';
            this.Keresztnév.PromptText = "Keresztnév";
            this.Keresztnév.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Keresztnév.SelectedText = "";
            this.Keresztnév.SelectionLength = 0;
            this.Keresztnév.SelectionStart = 0;
            this.Keresztnév.ShortcutsEnabled = true;
            this.Keresztnév.Size = new System.Drawing.Size(120, 23);
            this.Keresztnév.TabIndex = 14;
            this.Keresztnév.UseSelectable = true;
            this.Keresztnév.WaterMark = "Keresztnév";
            this.Keresztnév.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Keresztnév.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Password
            // 
            // 
            // 
            // 
            this.Password.CustomButton.Image = null;
            this.Password.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.Password.CustomButton.Name = "";
            this.Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password.CustomButton.TabIndex = 1;
            this.Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password.CustomButton.UseSelectable = true;
            this.Password.CustomButton.Visible = false;
            this.Password.Lines = new string[0];
            this.Password.Location = new System.Drawing.Point(189, 274);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PromptText = "Jelszó";
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(120, 23);
            this.Password.TabIndex = 15;
            this.Password.UseSelectable = true;
            this.Password.WaterMark = "Jelszó";
            this.Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_KeyUp);
            // 
            // Password2
            // 
            // 
            // 
            // 
            this.Password2.CustomButton.Image = null;
            this.Password2.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.Password2.CustomButton.Name = "";
            this.Password2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Password2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password2.CustomButton.TabIndex = 1;
            this.Password2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password2.CustomButton.UseSelectable = true;
            this.Password2.CustomButton.Visible = false;
            this.Password2.Lines = new string[0];
            this.Password2.Location = new System.Drawing.Point(189, 303);
            this.Password2.MaxLength = 32767;
            this.Password2.Name = "Password2";
            this.Password2.PasswordChar = '*';
            this.Password2.PromptText = "Jelszó megerősítése";
            this.Password2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password2.SelectedText = "";
            this.Password2.SelectionLength = 0;
            this.Password2.SelectionStart = 0;
            this.Password2.ShortcutsEnabled = true;
            this.Password2.Size = new System.Drawing.Size(120, 23);
            this.Password2.TabIndex = 16;
            this.Password2.UseSelectable = true;
            this.Password2.WaterMark = "Jelszó megerősítése";
            this.Password2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Password2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password2_KeyUp);
            // 
            // Regiszt
            // 
            this.Regiszt.Location = new System.Drawing.Point(189, 332);
            this.Regiszt.Name = "Regiszt";
            this.Regiszt.Size = new System.Drawing.Size(120, 29);
            this.Regiszt.TabIndex = 17;
            this.Regiszt.Text = "Regisztráció";
            this.Regiszt.UseSelectable = true;
            this.Regiszt.Click += new System.EventHandler(this.Regiszt_Click);
            // 
            // Login_Linklabel
            // 
            this.Login_Linklabel.Location = new System.Drawing.Point(113, 117);
            this.Login_Linklabel.Name = "Login_Linklabel";
            this.Login_Linklabel.Size = new System.Drawing.Size(278, 35);
            this.Login_Linklabel.TabIndex = 18;
            this.Login_Linklabel.Text = "Már regisztrált? Ide kattintva bejelentkezhet.";
            this.Login_Linklabel.UseSelectable = true;
            this.Login_Linklabel.Click += new System.EventHandler(this.Login_Linklabel_Click);
            // 
            // Username_error
            // 
            this.Username_error.AutoSize = true;
            this.Username_error.Location = new System.Drawing.Point(315, 168);
            this.Username_error.Name = "Username_error";
            this.Username_error.Size = new System.Drawing.Size(35, 13);
            this.Username_error.TabIndex = 19;
            this.Username_error.Text = "label1";
            this.Username_error.Visible = false;
            // 
            // vezeték_error
            // 
            this.vezeték_error.AutoSize = true;
            this.vezeték_error.Location = new System.Drawing.Point(315, 226);
            this.vezeték_error.Name = "vezeték_error";
            this.vezeték_error.Size = new System.Drawing.Size(35, 13);
            this.vezeték_error.TabIndex = 20;
            this.vezeték_error.Text = "label1";
            this.vezeték_error.Visible = false;
            // 
            // kereszt_error
            // 
            this.kereszt_error.AutoSize = true;
            this.kereszt_error.Location = new System.Drawing.Point(315, 255);
            this.kereszt_error.Name = "kereszt_error";
            this.kereszt_error.Size = new System.Drawing.Size(35, 13);
            this.kereszt_error.TabIndex = 21;
            this.kereszt_error.Text = "label1";
            this.kereszt_error.Visible = false;
            // 
            // jelszó_error
            // 
            this.jelszó_error.AutoSize = true;
            this.jelszó_error.Location = new System.Drawing.Point(315, 284);
            this.jelszó_error.Name = "jelszó_error";
            this.jelszó_error.Size = new System.Drawing.Size(35, 13);
            this.jelszó_error.TabIndex = 22;
            this.jelszó_error.Text = "label1";
            this.jelszó_error.Visible = false;
            // 
            // jelszóagain_error
            // 
            this.jelszóagain_error.AutoSize = true;
            this.jelszóagain_error.Location = new System.Drawing.Point(315, 313);
            this.jelszóagain_error.Name = "jelszóagain_error";
            this.jelszóagain_error.Size = new System.Drawing.Size(35, 13);
            this.jelszóagain_error.TabIndex = 23;
            this.jelszóagain_error.Text = "label1";
            this.jelszóagain_error.Visible = false;
            // 
            // email_error
            // 
            this.email_error.AutoSize = true;
            this.email_error.Location = new System.Drawing.Point(315, 197);
            this.email_error.Name = "email_error";
            this.email_error.Size = new System.Drawing.Size(35, 13);
            this.email_error.TabIndex = 24;
            this.email_error.Text = "label1";
            this.email_error.Visible = false;
            // 
            // Regiszt_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 451);
            this.Controls.Add(this.email_error);
            this.Controls.Add(this.jelszóagain_error);
            this.Controls.Add(this.jelszó_error);
            this.Controls.Add(this.kereszt_error);
            this.Controls.Add(this.vezeték_error);
            this.Controls.Add(this.Username_error);
            this.Controls.Add(this.Login_Linklabel);
            this.Controls.Add(this.Regiszt);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Keresztnév);
            this.Controls.Add(this.Vezetéknév);
            this.Controls.Add(this.email);
            this.Controls.Add(this.UserName);
            this.MaximizeBox = false;
            this.Name = "Regiszt_Form";
            this.Resizable = false;
            this.Text = "Regisztráció";
            this.Load += new System.EventHandler(this.Regiszt_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox UserName;
        private MetroFramework.Controls.MetroTextBox email;
        private MetroFramework.Controls.MetroTextBox Vezetéknév;
        private MetroFramework.Controls.MetroTextBox Keresztnév;
        private MetroFramework.Controls.MetroTextBox Password;
        private MetroFramework.Controls.MetroTextBox Password2;
        private MetroFramework.Controls.MetroButton Regiszt;
        private MetroFramework.Controls.MetroLink Login_Linklabel;
        private System.Windows.Forms.Label Username_error;
        private System.Windows.Forms.Label vezeték_error;
        private System.Windows.Forms.Label kereszt_error;
        private System.Windows.Forms.Label jelszó_error;
        private System.Windows.Forms.Label jelszóagain_error;
        private System.Windows.Forms.Label email_error;
    }
}