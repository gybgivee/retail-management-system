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
    public partial class divmem : Form
    {
        int n = 0;
        public divmem()
        {
            InitializeComponent();
        }

        private void datestart_ValueChanged(object sender, EventArgs e)
        {
            global.startdate.set(DateTime.Parse(datestart.Text));
        }

        private void dateend_ValueChanged(object sender, EventArgs e)
        {
            global.enddate.set(DateTime.Parse(dateend.Text));
        }

        private void divmem_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Today;
            DateTime end = DateTime.Today;
            start = global.startdate.get();
            end = global.enddate.get();

            String pdcode = "";
            String pddate = "";
            String pdst = "";
            String pdend = "";

            String pdprofit = "";
            String pdpay = "";
            String emid = "";
            String mid = "";

            String dbins = "SELECT * FROM paydivmem  WHERE PDMdate BETWEEN @start AND @end";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@start", start);
            ins.Parameters.AddWithValue("@end", end);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                //EMid


                pdcode = reader.GetString("PDMcode");
                pddate = reader.GetString("PDMdate");
                pdst = reader.GetString("PDMstart");
                pdend = reader.GetString("PDMend");
                pdprofit = reader.GetString("PDMbill");
                pdpay = reader.GetString("PDMpay");
                emid = reader.GetString("EMid");
                mid = reader.GetString("Mid");

                n++;
                ListViewItem showorder = new ListViewItem(pdcode);
                showorder.SubItems.Add(pddate);
                showorder.SubItems.Add(pdst);
                showorder.SubItems.Add(pdend);
                showorder.SubItems.Add(pdprofit);
                showorder.SubItems.Add(pdpay);
                showorder.SubItems.Add(emid);
                showorder.SubItems.Add(mid);
                listdiv.Items.Add(showorder);


            }

            connectdb.Close();




        }
    }
}
