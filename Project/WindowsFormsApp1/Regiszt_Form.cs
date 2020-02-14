using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Regiszt_Form : MetroForm
    {

        public Regiszt_Form()
        {
            InitializeComponent();
        }

        private void Regiszt_Click(object sender, EventArgs e)
        {

            try
            {
                Sql  felhaszcheck =  new  Sql("SELECT felhasz FROM users WHERE felhasz='" + UserName.Text + "'");

                Sql emailcheck = new Sql("SELECT felhasz FROM users WHERE email='" + email.Text + "'");


                if (felhaszcheck.rdr.HasRows == true)
                {
                    MessageBox.Show("Felhasználónév foglalt");
                }
                else
                {
                    if(emailcheck.rdr.HasRows == true)
                    {
                        MessageBox.Show("Email cím foglalt");
                    }
                    else
                    {
                        if (Username_error.Visible || email_error.Visible || jelszóagain_error.Visible || jelszó_error.Visible || vezeték_error.Visible
                            || kereszt_error.Visible || string.IsNullOrWhiteSpace(UserName.Text) || string.IsNullOrWhiteSpace(email.Text) || 
                            string.IsNullOrWhiteSpace(Vezetéknév.Text) || string.IsNullOrWhiteSpace(Keresztnév.Text) || 
                            string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(Password2.Text))
                        {
                            MessageBox.Show("Javítsd a hibákat!");
                        }
                        else
                        {
                            try
                            {

                                Sql insert = new Sql("INSERT INTO users VALUES ('', '" + UserName.Text + "', '" + email.Text + "', '" + Vezetéknév.Text + "', '" + Keresztnév.Text + "', SHA1('" + Password.Text + "'))");


                                MessageBox.Show("Sikeres regisztráció");

                                NewForm form = new NewForm("Regiszt_Form", new WindowsFormsApp1.Login_Form());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }




        private void Login_Linklabel_Click(object sender, EventArgs e)
        {
              NewForm login = new NewForm("Regiszt_Form", new WindowsFormsApp1.Login_Form());

        }


        private void Regiszt_Form_Load(object sender, EventArgs e)
        {
            
        }
       

        private void UserName_KeyUp(object sender, KeyEventArgs e)
        {

            ellenőrzés.Ellenőrző(Username_error, "Túl rövid", UserName.Text.Length < 5);
          
        }
        Ellenőr ellenőrzés = new Ellenőr();
        
        private void Password_KeyUp(object sender, KeyEventArgs e)
        {

            ellenőrzés.Ellenőrző(jelszóagain_error, "Nem azonos a két jelszó", Password.Text != Password2.Text);

            ellenőrzés.Ellenőrző(jelszó_error, "Túl rövid", Password.Text.Length < 5);

        }
        private void Password2_KeyUp(object sender, KeyEventArgs e)
        {

            ellenőrzés.Ellenőrző(jelszóagain_error, "Nem azonos a két jelszó", Password.Text != Password2.Text);
        }

        private void email_KeyUp(object sender, KeyEventArgs e)
        {

            ellenőrzés.Ellenőrző(email_error, "Nem érvényes email cím", !email.Text.Contains('@') || !email.Text.Contains('.'));
        }
    }
    
}


