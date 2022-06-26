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
    public partial class addproduct : Form
    {
        int n = 0;
        public addproduct()
        {
            InitializeComponent();
        }
        private void addproduct_Load(object sender, EventArgs e)
        {
            selectnametp();
        }
        void selectPcode()
        {
            String pname = "";
            string pcode = "";
            pname = global.pname.get();
            String dbins = "SELECT * FROM product ORDER BY Pcode ASC ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                pcode = reader.GetString("Pcode");


            }
            global.pcode.set(pcode);
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
              

            }
            global.tpcode.set(tpcode);
           
            connectdb.Close();

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

        private void btn_addpro_Click(object sender, EventArgs e)
        {  

            String pname="";
            String pcode = "";
            String tpcode = "";
            
            n++;

            ListViewItem showorder = new ListViewItem(n.ToString());
            showorder.SubItems.Add(txt_proname.Text);
            showorder.SubItems.Add(tpname.SelectedItem.ToString());
            showorder.SubItems.Add(txt_pcode.Text);
            showorder.SubItems.Add(txt_tpcode.Text);
            listsupdetail.Items.Add(showorder);


            tpname.Text = string.Empty;
            txt_proname.Text = string.Empty;
            txt_pcode.Text = string.Empty;
            txt_tpcode.Text = string.Empty;


        }

     
      
        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
               
                
                String pcode = "";
                String pname = "";
                int pprice = 0;
                int pamount = 0;
                String tpcode = "";
                ListViewItem item = new ListViewItem();
                int n = listsupdetail.Items.Count;
                MessageBox.Show(n.ToString());
                String dbins = "INSERT INTO product(Pcode,TPcode,Pname,Pprice,Pamount)VALUES(@pcode,@tpcode,@pname,@pprice,@pamount)";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);
                //  String nowday = ;
                //@pcode,@tpcode,@pname,@pprice,@pamount
                MySqlCommand ins = new MySqlCommand(dbins, connectdb);
               
               
                for (int i = 0; i < n; i++)
                {
                    dbins = "INSERT INTO product(Pcode,TPcode,Pname,Pprice,Pamount)VALUES(@pcode,@tpcode,@pname,@pprice,@pamount)";
                    connectdb = new MySqlConnection(Connect.conins);
                    ins = new MySqlCommand(dbins, connectdb);
                    connectdb.Open();
                    item = listsupdetail.Items[i];
                    pname = item.SubItems[1].Text;
                    pcode = item.SubItems[3].Text;
                    tpcode = item.SubItems[4].Text;


                    ins.Parameters.AddWithValue("@pcode", pcode);
                    ins.Parameters.AddWithValue("@tpcode", tpcode);
                    ins.Parameters.AddWithValue("@pname", pname);
                    ins.Parameters.AddWithValue("@pprice", pprice);
                    ins.Parameters.AddWithValue("@pamount", pamount);
  

                    ins.ExecuteNonQuery();

                    MessageBox.Show("Added Products Successfully");
                    connectdb.Close();
                }
               
            }
            catch
            {
                MessageBox.Show("Error!, Please try again");


            }


        }

        private void tpname_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.tpname.set(tpname.SelectedItem.ToString());
            selectTPcode();
            txt_tpcode.Text = global.tpcode.get();
        }

        private void txt_proname_TextChanged(object sender, EventArgs e)
        {
            String pcode = "";
            int pc = 0;
            selectPcode();
            pcode = global.pcode.get();
            pc = int.Parse(pcode);
            pc = pc + 1;
            txt_pcode.Text = pc.ToString();

        }

        private void listsupdetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainem1 nextForm = new mainem1();
            nextForm.Show();
            this.Hide();
        }

        
    }
}
