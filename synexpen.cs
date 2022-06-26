﻿using System;
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
    public partial class synexpen : Form
    {
        int n = 0;
        String excodeempty = "";
        String exdetail = "";
        String exname = "";
        double expay = 0;
        public synexpen()
        {
            InitializeComponent();
        }
        private void synexpen_Load(object sender, EventArgs e)
        {
            DateTime thisday = DateTime.Today;
            String nowday = thisday.ToString("d");

            txt_date.Text = nowday;
            global.dateday.set(nowday);
            txt_date.ReadOnly = true;
            selectemname();
            selectexcode();
        }
        void selectexcode()
        {
            String ex = "";
            String excode = "";
            int exint = 0;
            int exc = 0;


            String dbins = "SELECT EXcode FROM expen";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {

                excode = reader.GetString("EXcode");


            }

            exint = int.Parse(excode) + 1;

            txt_bill.Text = exint.ToString();
            txt_bill.ReadOnly = true;
            global.orcodeinc.setinc(exint);
            connectdb.Close();


        }
        void selectemname()
        {
            String emtype = "Sn";
            String dbins = "SELECT* FROM employee WHERE Emtype = @emtype ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@emtype", emtype);


            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();



            while (reader.Read())
            {
                emnames.Items.Add(reader.GetString("Emname"));


            }


            connectdb.Close();

        }
        void selectemid()
        {

            String emname = global.emname.get();
            String emid = "";
            String dbins = "SELECT * FROM employee where Emname = @emname ";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            ins.Parameters.AddWithValue("@emname", emname);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                emid = reader.GetString("EMid");


            }
            global.emid.set(emid);

            connectdb.Close();



        }

        private void addbill_Click(object sender, EventArgs e)
        {


            String emid = "";
            String emname = "";
            String exdetail = "";
            double expay = 0;

            if (emname != null)
            {



                emname = global.emname.get();
                exdetail = global.exdetail.get();
                expay = global.expay.get();

                n++;
                ListViewItem showorder = new ListViewItem(n.ToString());
                showorder.SubItems.Add(expenname.SelectedItem.ToString());
                showorder.SubItems.Add(txt_detail.Text);
                showorder.SubItems.Add(txt_payexpen.Text);
                showorder.SubItems.Add(txt_bill.Text);

                listexpe.Items.Add(showorder);


            }
            else if (emname == null)
            {
                MessageBox.Show("Please Fill the employee name");

            }
            txt_bill.Text = string.Empty;
            emnames.Text = string.Empty;
            emnames.Items.Clear();
            expenname.Text = string.Empty;
            txt_payexpen.Text = string.Empty;
            txt_detail.Text = string.Empty;
            txt_bill.Text = string.Empty;
            global.orcodeinc.setinc(global.orcodeinc.get() + 1);
            int excodet = global.orcodeinc.get();
            txt_bill.Text = excodet.ToString();
            selectemname();

        }

        private void btnsaved_Click(object sender, EventArgs e)
        {

            insertexpen();
        }

        private void emnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.emname.set(emnames.SelectedItem.ToString());
            selectemid();
        }

        private void expenname_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.exname.set(emnames.SelectedItem.ToString());
        }

        private void txt_detail_TextChanged(object sender, EventArgs e)
        {
            global.exdetail.set(txt_detail.Text);
        }
        void insertexpen()
        {

            int excode = 0;
            int excoden = 0;
            String emid = "";
            String exname = "";
            String exdetail = "";

            String emidn = "";
            String exnamen = "";
            String exdetailn = "";
            double expay = 0;
            double expayn = 0;
            int n = listexpe.Items.Count;
            ListViewItem item = new ListViewItem();
            int count = 0;
            DateTime thisday = DateTime.Today;
            String nowday = thisday.ToString("d");

            emid = global.emid.get();
            String dbins = "INSERT INTO expen(EXcode,EXdate,EXname,EXdetail,EXpay,EMid)VALUES(@excode,@nowday,@exname,@exdetail,@expay,@emid)";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            connectdb.Open();

            for (int i = 0; i < n; i++)
            {

                item = listexpe.Items[i];

                count = i;
                exname = item.SubItems[1].Text;
                global.exname.set(exname);
                exnamen = global.exname.get();

                exdetail = item.SubItems[2].Text;
                global.exdetail.set(exdetail);
                exdetailn = global.exdetail.get();

                expay = Double.Parse(item.SubItems[3].Text);
                global.expay.set(expay);
                expay = global.expay.get();

                excode = int.Parse(item.SubItems[4].Text);
                global.orcodeinc.setinc(excode);
                excoden = global.orcodeinc.get();




                ins.Parameters.AddWithValue("@excode", excodeempty);
                ins.Parameters.AddWithValue("@nowday", thisday);
                ins.Parameters.AddWithValue("@exname", exnamen);
                ins.Parameters.AddWithValue("@exdetail", exdetailn);
                ins.Parameters.AddWithValue("@expay", expayn);
                ins.Parameters.AddWithValue("@emid", emid);



                ins.ExecuteNonQuery();




            }
            MessageBox.Show("Successfully");

            connectdb.Close();




        }

        private void listex_doubleclick(object sender, EventArgs e)
        {
            int n = listexpe.Items.Count;
            for (int i = 0; i < n; i++)
            {

                if (listexpe.Items[i].Selected)
                {
                    listexpe.Items[i].BackColor = Color.Red;
                    listexpe.Items[i].Remove();

                }

            }
        }

       
    }
}

