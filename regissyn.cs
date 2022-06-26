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
    public partial class regissyn : Form
    {
        public regissyn()
        {
            InitializeComponent();

        }
        private void regissyn_Load(object sender, EventArgs e)
        {
            int id = 0;
            selectemid();
            id = int.Parse(global.emid.get());
            id = id + 1;
            txt_id.Text = id.ToString();
            txt_id.ReadOnly = true;

        }

        private void RegisOK_Click(object sender, EventArgs e)
        {
            try
            {
                String id, name, gender, contact, salary, user, password, passagain;
                String emtype = "";
                double empay = 0;
                id = txt_id.Text;
                name = txt_name.Text;
                gender = Combo_gen.Text;
                contact = txt_address.Text;
                empay = double.Parse(txt_pay.Text);
                emtype = global.emtype.get();
                salary = txt_salary.Text;
                user = txt_user.Text;
                password = txt_Pass.Text;
                passagain = txt_PassAg.Text;

                String dbins = "INSERT INTO employee(EMid,EMname,EMgen,EMcontact,EMpay,EMsalary,EMuser,EMpass,EMtype)VALUES(@id,@name,@gender,@contact,@pay,@salary,@user,@password,@type)";

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
                MessageBox.Show("Successfully");
                Mainsp nextForm = new Mainsp();
                nextForm.Show();
                this.Hide();
            }
         
            catch {
                MessageBox.Show("Please try again! Username and Password are incorrect");
                Mainsp nextForm = new Mainsp();
                nextForm.Show();
                this.Hide();

            }
        }
        void selectemid()
        {
            String emname = global.emname.get();
            String emid = "";
            String dbins = "SELECT EMid FROM employee ORDER BY EMid ASC";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            ins.Parameters.AddWithValue("@emname", emname);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                emid = reader.GetString("Emid");


            }
            global.emid.set(emid);

            connectdb.Close();



        }

        private void em_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //คณะกรรมการ  หัวหน้าคณะกรรมการ
            if (em_type.SelectedItem.ToString() == "คณะกรรมการ")
            {

                global.emtype.set("Sn");

            }
            else if (em_type.SelectedItem.ToString() == "หัวหน้าคณะกรรมการ")
            {


                global.emtype.set("SP");
            }
        }

        private void Combo_gen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
