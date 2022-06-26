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

namespace $safeprojectname$
{
    public partial class login : System.Windows.Forms.Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void buttonok(object sender, EventArgs e)
        {

            String user, password;
            user = userin.Text;
            password = passin.Text;

            String userout = "", passout = "", tidout = "";


            String dbins = " SELECT * FROM employee Where EMuser=@user";
            //String dbinscheck= " SELECT * FROM employee Where EmUser LIKE Syn% ";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@user", user);//เก็บค่าตัวเเปรที่รับมาจาก textbox ลงในเงื่อไขwhereของselect

            //MySqlCommand inscheck = new MySqlCommand(dbinscheck, connectdb);
            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();
            // MySqlDataReader readerCheck = inscheck.ExecuteReader();



            while (reader.Read())
            {
                userout = reader.GetString("EMuser");
                passout = reader.GetString("EMpass");
                tidout = reader.GetString("EMtype");
                passin.Text = passout;



            }
            connectdb.Close();

            if (userout == user && passout == password)
            {
                MessageBox.Show("PassWord And Password are correct");
                if (tidout.StartsWith("Sn"))
                {
                    MessageBox.Show("Please wait!,Logging into Supervisor System");
                    Mainsyn Nextform = new Mainsyn(); //ต้องadd reference เเละ using from ที่จะใช้ด้วย
                    Nextform.Show();
                    this.Hide();
                }
                else if (tidout.StartsWith("Em"))
                {
                    MessageBox.Show("Please wait!,Logging into Employee System");
                    Mainem Nextform = new Mainem();
                    Nextform.Show();
                    this.Hide();
                }
                else if (tidout.StartsWith("SP"))
                {
                    MessageBox.Show("Please wait!,Logging into Manager System");
                    Mainsp Nextform = new Mainsp();
                    Nextform.Show();
                    this.Hide();

                }


            }

            else
            {
                MessageBox.Show("Fail to Login! Please check your username and password");

            }



            connectdb.Close();

        }

        private void userin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
