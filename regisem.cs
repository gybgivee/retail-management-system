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
    public partial class regisem : Form
    {
        public regisem()
        {
            InitializeComponent();
        }
        private void regis_Load(object sender, EventArgs e)
        {
            selectemid();

            

        }

        private void RegisOK_Click(object sender, EventArgs e)
        {
            try
            {
                String name, gender, contact, salary, user, password, passagain, emtype;
                double empay = 0;
                String id = "";
                id = txt_id.Text;
                emtype = "Em";
                name = txt_name.Text;
                gender = Combo_gen.Text;
                contact = txt_address.Text;
                empay = double.Parse(txt_pay.Text);
                salary = txt_salary.Text;
                user = txt_user.Text;
                password = txt_Pass.Text;
                passagain = txt_PassAg.Text;


                String dbins = "INSERT INTO employee(EMid,EMname,EMgen,EMcontact,EMpay,EMsalary,EMuser,EMPass,EMtype)VALUES(@id,@name,@gender,@contact,@pay,@salary,@user,@password,@type)";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);
                ins.Parameters.AddWithValue("@id", id);
                ins.Parameters.AddWithValue("@name", name);
                ins.Parameters.AddWithValue("@gender", gender);
                ins.Parameters.AddWithValue("@contact", contact);
                ins.Parameters.AddWithValue("@pay", empay);
                ins.Parameters.AddWithValue("@salary", salary);
                ins.Parameters.AddWithValue("@user", user);
                ins.Parameters.AddWithValue("@type", emtype);


                if (passagain == password)
                {
                    ins.Parameters.AddWithValue("@password", password);
                }






                connectdb.Open();

                ins.ExecuteNonQuery();




                connectdb.Close();
                MessageBox.Show("Added Employee Successfully");
                Mainsyn nextForm = new Mainsyn();
                nextForm.Show();
                this.Hide();
            }

            catch {
                MessageBox.Show("Please Try again! Username and Password are incorrect");
                Mainsyn nextForm = new Mainsyn();
                nextForm.Show();
                this.Hide();
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Combo_gen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void selectemid()
        {
           try
            {
                String em = "";
                String emid = "";
                String emtype = "Em";
                String dbins = "SELECT EMid FROM employee ORDER BY EMid ASC ";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);

                ins.Parameters.AddWithValue("@emtype", emtype);


                connectdb.Open();

                MySqlDataReader reader = ins.ExecuteReader();

                while (reader.Read())
                {
                    emid = reader.GetString("EMid");

                }
                connectdb.Close();

                global.emid.set(emid);
                MessageBox.Show(emid);
            }
           
            catch {
               
            }



        }

       
    }
}
