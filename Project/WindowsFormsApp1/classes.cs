using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;


class Sql
{

    public  MySqlConnection conn = new MySqlConnection("server=localhost;database=project1;uid=root;pwd=;");
    public MySqlDataReader rdr;
    public MySqlCommand cmd;


    public Sql(string command)
    {
        
        conn.Open();

        cmd = new MySqlCommand(command, conn);
        rdr = cmd.ExecuteReader();
    }

}

class NewForm
{

    public NewForm(string bezár, Form name)
    {
        Thread th;
        Application.OpenForms[bezár].Close();
        th = new Thread(opennewform);
        th.SetApartmentState(ApartmentState.STA);
        th.Start();
        
         void opennewform()
        {
            
            Application.Run(name);
            
        }
    }
    
}

class Ellenőr
{

    /*  public Ellenőr(Label label_neve, string szöveg, bool feltétel)
      {
          if (feltétel)
          {
              label_neve.Text = szöveg;
              label_neve.Visible = true;
          }
          else
          {

              label_neve.Visible = false;
          }


      }*/
    public bool testt = true;
    public void Ellenőrző(Label label_neve, string szöveg, bool feltétel)
    {
        if (feltétel)
        {
            label_neve.Text = szöveg;
            label_neve.Visible = true;
        }
        else
        {

            label_neve.Visible = false;
            testt = false;
        }

        
    }
}
