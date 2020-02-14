namespace WindowsFormsApp1
{
    partial class Login_Form
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
            this.Felhasz = new MetroFramework.Controls.MetroTextBox();
            this.Jelszo = new MetroFramework.Controls.MetroTextBox();
            this.Regist_Linklabel = new MetroFramework.Controls.MetroLink();
            this.Login_Button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Felhasz
            // 
            // 
            // 
            // 
            this.Felhasz.CustomButton.Image = null;
            this.Felhasz.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.Felhasz.CustomButton.Name = "";
            this.Felhasz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Felhasz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Felhasz.CustomButton.TabIndex = 1;
            this.Felhasz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Felhasz.CustomButton.UseSelectable = true;
            this.Felhasz.CustomButton.Visible = false;
            this.Felhasz.Lines = new string[0];
            this.Felhasz.Location = new System.Drawing.Point(193, 196);
            this.Felhasz.MaxLength = 32767;
            this.Felhasz.Name = "Felhasz";
            this.Felhasz.PasswordChar = '\0';
            this.Felhasz.PromptText = "Felhasználónév";
            this.Felhasz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Felhasz.SelectedText = "";
            this.Felhasz.SelectionLength = 0;
            this.Felhasz.SelectionStart = 0;
            this.Felhasz.ShortcutsEnabled = true;
            this.Felhasz.Size = new System.Drawing.Size(125, 23);
            this.Felhasz.TabIndex = 9;
            this.Felhasz.UseSelectable = true;
            this.Felhasz.WaterMark = "Felhasználónév";
            this.Felhasz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Felhasz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Jelszo
            // 
            // 
            // 
            // 
            this.Jelszo.CustomButton.Image = null;
            this.Jelszo.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.Jelszo.CustomButton.Name = "";
            this.Jelszo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Jelszo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Jelszo.CustomButton.TabIndex = 1;
            this.Jelszo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Jelszo.CustomButton.UseSelectable = true;
            this.Jelszo.CustomButton.Visible = false;
            this.Jelszo.Lines = new string[0];
            this.Jelszo.Location = new System.Drawing.Point(193, 225);
            this.Jelszo.MaxLength = 32767;
            this.Jelszo.Name = "Jelszo";
            this.Jelszo.PasswordChar = '*';
            this.Jelszo.PromptText = "Jelszó";
            this.Jelszo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Jelszo.SelectedText = "";
            this.Jelszo.SelectionLength = 0;
            this.Jelszo.SelectionStart = 0;
            this.Jelszo.ShortcutsEnabled = true;
            this.Jelszo.Size = new System.Drawing.Size(125, 23);
            this.Jelszo.TabIndex = 10;
            this.Jelszo.UseSelectable = true;
            this.Jelszo.WaterMark = "Jelszó";
            this.Jelszo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Jelszo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Regist_Linklabel
            // 
            this.Regist_Linklabel.Location = new System.Drawing.Point(87, 155);
            this.Regist_Linklabel.Name = "Regist_Linklabel";
            this.Regist_Linklabel.Size = new System.Drawing.Size(352, 35);
            this.Regist_Linklabel.TabIndex = 11;
            this.Regist_Linklabel.Text = "Nincs felhasználói fiókja? Ide kattintva regisztrálhat.";
            this.Regist_Linklabel.UseSelectable = true;
            this.Regist_Linklabel.Click += new System.EventHandler(this.Regist_Linklabel_Click);
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(193, 266);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(125, 29);
            this.Login_Button.TabIndex = 12;
            this.Login_Button.Text = "Bejelentkezés";
            this.Login_Button.UseSelectable = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 451);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Regist_Linklabel);
            this.Controls.Add(this.Jelszo);
            this.Controls.Add(this.Felhasz);
            this.MaximizeBox = false;
            this.Name = "Login_Form";
            this.Resizable = false;
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox Felhasz;
        private MetroFramework.Controls.MetroTextBox Jelszo;
        private MetroFramework.Controls.MetroLink Regist_Linklabel;
        private MetroFramework.Controls.MetroButton Login_Button;
    }
}

