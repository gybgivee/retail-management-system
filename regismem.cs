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
    public partial class regismem : Form
    {
        public regismem()
        {
            InitializeComponent();
        }
        private void regismem_Load(object sender, EventArgs e)
        {
            selectmemid();
            String mid = "";
            int m = 0;
            mid = global.mid.get();
            m = int.Parse(mid)+1;
            txt_id.Text = m.ToString();

        }
        private void RegisOK_Click(object sender, EventArgs e)
        {
            try
            {
                String name, gender, contact;

                String id = "";
                id = txt_id.Text;

                name = txt_name.Text;
                gender = Combo_gen.Text;
                contact = txt_contact.Text;
                String status = "1";
                int low = 0;


                String dbins = "INSERT INTO member(Mid,Mname,Mgen,Mpay,Mstatus,MshAmount,MshValue,Mcontact)VALUES(@id,@name,@gender,@pay,@status,@amount,@value,@contact)";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);
                //@id,@name,@gender,,@pay,@status,@amount,@value,@contact)
                MySqlCommand ins = new MySqlCommand(dbins, connectdb);
                ins.Parameters.AddWithValue("@id", id);
                ins.Parameters.AddWithValue("@name", name);
                ins.Parameters.AddWithValue("@gender", gender);
                ins.Parameters.AddWithValue("@pay", low);
                ins.Parameters.AddWithValue("@status", status);
                ins.Parameters.AddWithValue("@amount", low);
                ins.Parameters.AddWithValue("@value", low);
                ins.Parameters.AddWithValue("@contact", contact);






                connectdb.Open();

                ins.ExecuteNonQuery();




                connectdb.Close();
                MessageBox.Show("Added Member Succesfully");
                txt_id.Text = String.Empty;
                txt_name.Text = String.Empty;
                txt_contact.Text = String.Empty;
                Combo_gen.Text = String.Empty;
                Mainem nextForm = new Mainem();
                nextForm.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Error! Please try again");
                Mainem nextForm = new Mainem();
                nextForm.Show();
                this.Hide();
            }


        }
        void selectmemid()
        {
            try
            {
                String m = "";
                String mid = "";
               
                String dbins = "SELECT Mid FROM member ORDER BY Mid ASC ";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);

               


                connectdb.Open();

                MySqlDataReader reader = ins.ExecuteReader();

                while (reader.Read())
                {
                    mid = reader.GetString("Mid");

                }
                connectdb.Close();

                global.mid.set(mid);
               
            }

            catch
            {

            }



        }

        
    }
}
