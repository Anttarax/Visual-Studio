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

    public partial class Login_Form : MetroForm
    {


        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Sql select = new Sql("SELECT felhasz FROM users WHERE felhasz='" + Felhasz.Text + "'AND jelszo= SHA1('" + Jelszo.Text + "')");

                
                if (select.rdr.HasRows == true)
                {
                    MessageBox.Show("Sikeres bejelentkezés");

                    NewForm form = new NewForm("Login_Form", new WindowsFormsApp1.Form3());
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév / jelszó!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    
        private void Regist_Linklabel_Click(object sender, EventArgs e)
        {

            NewForm form = new NewForm("Login_Form", new WindowsFormsApp1.Regiszt_Form());

        }
    }
}
