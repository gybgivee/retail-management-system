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
    public partial class addsup : Form
    {
        string supem = "";
        public addsup()
        {
            InitializeComponent();
        }
        private void addsup_Load(object sender, EventArgs e)
        {
            selectsupcode();
            String supcode = "";
            int supinc = 0;
            supcode = global.supcode.get();
            supinc = int.Parse(supcode);
            supinc = supinc + 1;
            txt_id.Text = supinc.ToString();
        }
        private void RegisOK_Click(object sender, EventArgs e)
        {
            try
            {
                String supname = "";
                String supcontact = "";
                String supcode = "";
                supcode = txt_id.Text;

                supname = txt_name.Text;
                global.supname.set(supname);
                supcontact = txt_contact.Text;
                //employee(EMid,EMname,EMgen,EMcontact,EMpay,EMsalary,EMuser,EMPass,EMtype)VALUES(@id,@name,@g
                String dbins = "INSERT INTO  supplier(SUPcode,SUPname,SUPcontact)VALUES(@supcode,@supname,@supcontact)";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);
                //@supcode,@supname,@supcont
                ins.Parameters.AddWithValue("supcode",supcode );
                ins.Parameters.AddWithValue("supname", supname);
                ins.Parameters.AddWithValue("supcontact", supcontact);

                connectdb.Open();

                ins.ExecuteNonQuery();

                connectdb.Close();
                global.supcode.set(supcode);

                addsupdetail nextForm = new addsupdetail();
                nextForm.Show();
                this.Hide();

                MessageBox.Show("Added Supplier Succesfully");
            }
            catch
            {

                MessageBox.Show("Error!, Please try again");
            }
           

        }

        void selectsupcode()
        {
            try
            {
                
                String supcode = "";
               
                String dbins = "SELECT * FROM supplier ORDER BY SUPcode ASC ";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);

               


                connectdb.Open();

                MySqlDataReader reader = ins.ExecuteReader();

                while (reader.Read())
                {
                    supcode = reader.GetString("SUPcode");

                }
                connectdb.Close();

                global.supcode.set(supcode);
               

            }

            catch
            {

            }

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            global.supname.set(txt_name.Text);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainem1 nextForm = new mainem1();
            nextForm.Show();
            this.Hide();
        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
