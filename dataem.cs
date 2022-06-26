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
    public partial class dataem : System.Windows.Forms.Form
    {
        int showerror = 1;
        public dataem()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            
            String find, findtype, findsearch, finddetail;

            find = find_per.Text;
            findtype = find_type.Text;
            findsearch = find_search.Text;
            finddetail = txt_find.Text;



           

            String dbins = " SELECT * FROM employee ";


            MySqlConnection connectdb = new MySqlConnection("host=localhost;user=dba;password=2559;database=projectdb;CharSet=utf8;");

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            if (find == "เเสดงข้อมูลรายบุคคล")
            {
                if (findsearch == "รหัส")
                {
                    dbins = " SELECT * FROM employee WHERE EMid = @finddetail";
                }
                if (findsearch == "ชื่อ - นามสกุล")
                {
                    dbins = " SELECT * FROM employee WHERE EMname = @finddetail";
                }
                if (findsearch == "เบอร์โทรศัพท์")
                {
                    dbins = " SELECT * FROM employee WHERE EMemail = @finddetail";

                }
                if (findsearch == "สถานะ")
                {
                    dbins = " SELECT * FROM employee WHERE EMstatus = @finddetail";

                }

                ins = new MySqlCommand(dbins, connectdb);
                ins.Parameters.AddWithValue("@finddetail", finddetail);

            }

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();
            
            while (reader.Read())
            {

                if (findtype == "เเสดงข้อมูลพนักงาน")
                {
                    if (reader.GetString("EMtype").StartsWith("Em"))
                    {
                        ListViewItem item1 = new ListViewItem(reader.GetString("EMid"));
                        item1.SubItems.Add(reader.GetString("EMname"));
                        item1.SubItems.Add(reader.GetString("EMcontact"));
                        item1.SubItems.Add(reader.GetString("EMemail"));
                        item1.SubItems.Add(reader.GetString("EMstatus"));
                        listView1.Items.Add(item1);
                    }
                }
                if (findtype == "เเสดงข้อมูลคณะกรรมการ")
                {
                    if (reader.GetString("EMtype").StartsWith("Sn"))
                    {
                        ListViewItem item1 = new ListViewItem(reader.GetString("EMid"));
                        item1.SubItems.Add(reader.GetString("EMname"));
                        item1.SubItems.Add(reader.GetString("EMcontact"));
                        item1.SubItems.Add(reader.GetString("EMemail"));
                        item1.SubItems.Add(reader.GetString("EMstatus"));
                        listView1.Items.Add(item1);
                    }
                }
            }


        }

        private void btn_regis(object sender, EventArgs e)
        {
            regisem nextForm = new regisem();
            nextForm.Show();
        }

        private void btn_find_Click_1(object sender, EventArgs e)
        {
            checkfind();
            if (showerror == 0)
            {
                String find, findtype, findsearch, finddetail;

                find = find_per.Text;
                findtype = find_type.Text;
                findsearch = find_search.Text;
                finddetail = txt_find.Text;





                String dbins = " SELECT * FROM employee ";


                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);

                if (find == "Individual")
                {
                    if (findsearch == "ID")
                    {
                        dbins = " SELECT * FROM employee WHERE EMid = @finddetail";
                    }
                    if (findsearch == "Name")
                    {
                        dbins = " SELECT * FROM employee WHERE EMname = @finddetail";
                    }
                    if (findsearch == "Phone")
                    {
                        dbins = " SELECT * FROM employee WHERE EMpay = @finddetail";

                    }
                    if (findsearch == "Status")
                    {
                        dbins = " SELECT * FROM employee WHERE EMstatus = @finddetail";

                    }

                    ins = new MySqlCommand(dbins, connectdb);
                    ins.Parameters.AddWithValue("@finddetail", finddetail);

                }

                connectdb.Open();
                MySqlDataReader reader = ins.ExecuteReader();

                while (reader.Read())
                {

                    if (findtype == "Employee")
                    {
                        if (reader.GetString("EMType").StartsWith("Em"))
                        {
                            ListViewItem item1 = new ListViewItem(reader.GetString("EmType") + reader.GetString("EMid"));
                            item1.SubItems.Add(reader.GetString("EMname"));
                            item1.SubItems.Add(reader.GetString("EMcontact"));
                            item1.SubItems.Add(reader.GetString("EMpay"));
                            item1.SubItems.Add(reader.GetString("EMstatus"));
                            listView1.Items.Add(item1);
                        }
                    }
                    else if (findtype == "Supervisor")
                    {
                        if (reader.GetString("EMType").StartsWith("Sn"))
                        {
                            ListViewItem item1 = new ListViewItem(reader.GetString("EmType") + reader.GetString("EMid"));
                            item1.SubItems.Add(reader.GetString("EMname"));
                            item1.SubItems.Add(reader.GetString("EMcontact"));

                            item1.SubItems.Add(reader.GetString("EMstatus"));
                            listView1.Items.Add(item1);
                        }

                    }
                    else if (findtype == "Manager")
                    {
                        if (reader.GetString("EMType").StartsWith("SP"))
                        {
                            ListViewItem item1 = new ListViewItem(reader.GetString("EmType") + reader.GetString("EMid"));
                            item1.SubItems.Add(reader.GetString("EMname"));
                            item1.SubItems.Add(reader.GetString("EMcontact"));

                            item1.SubItems.Add(reader.GetString("EMstatus"));
                            listView1.Items.Add(item1);
                        }

                    }
                    else
                    {
                        ListViewItem item1 = new ListViewItem(reader.GetString("EmType") + reader.GetString("EMid"));
                        item1.SubItems.Add(reader.GetString("EMname"));
                        item1.SubItems.Add(reader.GetString("EMcontact"));

                        item1.SubItems.Add(reader.GetString("EMstatus"));
                        listView1.Items.Add(item1);

                    }
                }
                connectdb.Close();

                find_per.Text = String.Empty;
                find_type.Text = String.Empty;
                find_search.Text = String.Empty;
                txt_find.Text = String.Empty;
            }
          
        }

        private void btn_registor_Click(object sender, EventArgs e)
        {
            regisem nextForm = new regisem();
            nextForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Clear();
            find_per.Text = string.Empty;
            //find_per.Items.Clear();
            find_type.Text = string.Empty;
            find_search.Text = string.Empty;
            txt_find.Text = string.Empty;
        }

        private void find_per_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void find_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (find_per.Text == "Individual")
            {
                find_search.Enabled = true;
                txt_find.Enabled = true;
            }

        }

        private void find_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (find_per.Text == "All")
            {
                find_search.Enabled = false;
                txt_find.ReadOnly = true;
            }
        }
        

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            
        }
        void checkfind()
        {
            String finds = "";
            finds = txt_find.Text;
           
            String emid = "";
            String emname = "";
            //รหัส ชื่อ - นามสกุล
            String dbins = " SELECT * FROM  employee ";
            MySqlConnection connectdb = new MySqlConnection("host=localhost;user=dba;password=2559;database=projectdb;CharSet=utf8;");

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            ins = new MySqlCommand(dbins, connectdb);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();



            while (reader.Read())
            {



                emid = reader.GetString("EMid");
                emname = reader.GetString("EMname");


                if (emid == finds || emname == finds)
                {
                    showerror = 0;


                }
                
            }


            connectdb.Close();
            if (showerror == 1)
            {
                MessageBox.Show("Search Fail, No data match");
                find_per.Text = String.Empty;
                find_type.Text = String.Empty;
                find_search.Text = String.Empty;
                txt_find.Text = String.Empty;
                emid = "";
                emname = "";
            }


        }

        private void dataem_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
