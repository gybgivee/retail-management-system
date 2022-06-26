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
    
    public partial class datamemse : Form
    {
        string findtype = "";
        String dbins = "";
        String search = "";
        int n = 0;
        int showerror = 1;
        public datamemse()
        {
            InitializeComponent();
        }

        private void datamemse_Load(object sender, EventArgs e)
        {

        }

        private void find_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (find_type.SelectedItem.ToString() == "ID")
            {
               
                dbins = "SELECT * FROM member WHERE Mid=@searchs ";

            }
            if (find_type.SelectedItem.ToString() == "Name")
            {

               
                dbins = "SELECT * FROM member WHERE Mname=@searchs ";

            }
            if (find_type.SelectedItem.ToString() == "Gender")
            {

               
                dbins = "SELECT * FROM member WHERE Mgen=@searchs ";

            }
            if (find_type.SelectedItem.ToString() == "Status")
            {

                
                dbins = "SELECT * FROM member WHERE Mstatus=@searchs ";

            }
            if (find_type.SelectedItem.ToString() == "Stock Amount")
            {

                
                dbins = "SELECT * FROM member WHERE MshAmount =@searchs ";

            }

        }

        private void btn__Click(object sender, EventArgs e)
        {
            checkfind();
            if(showerror == 0)
            {
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);
                ins = new MySqlCommand(dbins, connectdb);
                ins.Parameters.AddWithValue("@searchs", search);
                connectdb.Open();
                MySqlDataReader reader = ins.ExecuteReader();

                while (reader.Read())
                {
                    n++;
                    //MidMnameMgenMpayMstatusMshAmountMshValue

                    ListViewItem showorder = new ListViewItem(n.ToString());
                    showorder.SubItems.Add(reader.GetString("Mid"));
                    showorder.SubItems.Add(reader.GetString("Mname"));
                    showorder.SubItems.Add(reader.GetString("Mgen"));

                    showorder.SubItems.Add(reader.GetString("Mstatus"));
                    showorder.SubItems.Add(reader.GetString("MshAmount"));
                    showorder.SubItems.Add(reader.GetString("MshValue"));
                    showorder.SubItems.Add(reader.GetString("Mpay"));
                    listmem.Items.Add(showorder);




                }
                connectdb.Close();
                find_type.Text = string.Empty;
                txt_find.Text = string.Empty;
            }
           
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            search = txt_find.Text;
        }
        void checkfind()
        {
            String finds = "";
            finds = txt_find.Text;

            String mid = "";
            String mname = "";
            //รหัส ชื่อ - นามสกุล
            String dbins = " SELECT * FROM  member ";
            MySqlConnection connectdb = new MySqlConnection("host=localhost;user=dba;password=2559;database=projectdb;CharSet=utf8;");

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            ins = new MySqlCommand(dbins, connectdb);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();



            while (reader.Read())
            {



                mid = reader.GetString("Mid");
                mname = reader.GetString("Mname");


                if (mid == finds || mname == finds)
                {
                    showerror = 0;


                }

            }


            connectdb.Close();
            if (showerror == 1)
            {
                MessageBox.Show("Sorry, There are no match");
                find_per.Text = String.Empty;
                find_type.Text = String.Empty;
                  txt_find.Text = String.Empty;
                mid = "";
                mname = "";
            }


        }

        private void find_per_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (find_per.Text == "All" +
                "")
            {
                txt_find.ReadOnly = true;
            }
        }
    }
}
