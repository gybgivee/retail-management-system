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
    public partial class addsupdetail : Form
    {
        double allpay = 0;
        int n = 0;
        public addsupdetail()
        {
            InitializeComponent();
        }

        private void addsupdetail_Load(object sender, EventArgs e)
        {

            selectsupcode();
            txt_supcode.Text = global.supcode.get();
            txt_supname.Text = global.supname.get();
            txt_supcode.ReadOnly = true;
            txt_supname.ReadOnly = true;
            selectnametp();
            String supname = "";
            supname = global.supname.get();
            int supc = 0;

            txt_supname.Text = supname;

            
        }

        private void btn_addpro_Click(object sender, EventArgs e)
        {

            n++;

            ListViewItem showorder = new ListViewItem(n.ToString());
            showorder.SubItems.Add(namepro.SelectedItem.ToString());
            showorder.SubItems.Add(txt_supcost.Text);
            showorder.SubItems.Add(tpname.Text);
            listsupdetail.Items.Add(showorder);


            tpname.Text = string.Empty;
            namepro.Text = string.Empty;
            namepro.Items.Clear();
            txt_supcost.Text = string.Empty;

        }

        void selectnametp()
        {

            String typeselect = "";

            String dbins = "SELECT * FROM typepro ";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();
            while (reader.Read())
            {
                tpname.Items.Add(reader.GetString("TPname"));


            }


            connectdb.Close();


        }

        void selectTPcode()
        {
            String tpname = "";
            string tpcode = "";
            String tpprofit = "";
            tpname = global.tpname.get();
            String dbins = "SELECT * FROM typepro WHERE TPname = @tpname";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@tpname", tpname);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                tpcode = reader.GetString("TPcode");
                tpprofit = reader.GetString("TPprofit");

            }
            global.tpcode.set(tpcode);
            global.TPprofit.set(tpprofit);
            connectdb.Close();

        }
        void selectnamep()
        {
            String tpname = "";
            String tpcode = "";
            tpcode = global.tpcode.get();
            tpname = global.tpname.get();
            String dbins = "SELECT * FROM product,typepro where typepro.TPname = @typename AND product.TPcode = @typepcode";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            ins.Parameters.AddWithValue("@typename", tpname);
            ins.Parameters.AddWithValue("@typepcode", tpcode);
            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                namepro.Items.Add(reader.GetString("Pname"));


            }

            connectdb.Close();

        }
        void selectPcode()
        {
            String pname = "";
            string pcode = "";
            pname = global.pname.get();
            String dbins = "SELECT Pcode FROM product WHERE pname = @pname";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@pname", pname);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                pcode = reader.GetString("Pcode");


            }
            global.pcode.set(pcode);
            connectdb.Close();

        }

        private void tpname_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.tpname.set(tpname.SelectedItem.ToString());
            selectTPcode();

            selectnamep();

        }

        private void namepro_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.pname.set(namepro.SelectedItem.ToString());
            selectPcode();
        }
        void selectsupcode()
        {
            try
            {
                String supname = "";
                String supcode = "";

                String dbins = "SELECT * FROM supplier ORDER BY SUPcode ASC ";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);




                connectdb.Open();

                MySqlDataReader reader = ins.ExecuteReader();

                while (reader.Read())
                {
                    supcode = reader.GetString("SUPcode");
                    supname = reader.GetString("SUPname");

                }
                connectdb.Close();
                global.supname.set(supname);
                global.supcode.set(supcode);
               

            }

            catch
            {

            }

        }

        private void txt_supcost_TextChanged(object sender, EventArgs e)
        {
            global.supcode.set(txt_supcost.Text);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                String supname = "";
                supname = global.supname.get();
                String supcode = "";
                supcode = global.supcode.get();

                String emptys = "";
                String pname = "";
                string tpname = "";
                string supcost = "";
                String pcode = "";
                String tpcode = "";
                ListViewItem item = new ListViewItem();
                int n = listsupdetail.Items.Count;
               
                String dbins = "INSERT INTO supdetail(SUPcode,TPcode,Pcode,SUPcost)VALUES(@supcode,@tpcode,@pcode,@supcost)";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);
                //  String nowday = ;

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);
                

                connectdb.Open();
                for (int i = 0; i < n; i++)
                {

                    dbins = "INSERT INTO supdetail(SUPcode,TPcode,Pcode,SUPcost)VALUES(@supcode,@tpcode,@pcode,@supcost)";
                    connectdb = new MySqlConnection(Connect.conins);

                    ins = new MySqlCommand(dbins, connectdb);
                   
                    connectdb.Open();

                    item = listsupdetail.Items[i];
                    pcode = global.pcode.get();

                    supcost = item.SubItems[2].Text;
                    

                    selectTPcode();
                    tpcode = global.tpcode.get();
                   
                    ins.Parameters.AddWithValue("@supcode", supcode);
                    ins.Parameters.AddWithValue("@tpcode", tpcode);
                    ins.Parameters.AddWithValue("@pcode", pcode);
                    ins.Parameters.AddWithValue("@supcost", supcost);


                    ins.ExecuteNonQuery();
                    connectdb.Close();


                }
                MessageBox.Show("Added Product list to Supplier, Successfully");
               
            }
            catch
            {


                MessageBox.Show("Sorry, This Product Code already had a supplier");
            }



        }

        private void listsupdetail_doubleclick(object sender, EventArgs e)
        {
            int n = listsupdetail.Items.Count;
            for (int i = 0; i < n; i++)
            {

                if (listsupdetail.Items[i].Selected)
                {
                    listsupdetail.Items[i].BackColor = Color.Red;
                    listsupdetail.Items[i].Remove();

                }

            }
        }
       
       

        private void txt_supname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listsupdetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Would like to add product list later ?");
            mainem1 nextForm = new mainem1();
            nextForm.Show();
            this.Hide();
        }

       
    }

}
