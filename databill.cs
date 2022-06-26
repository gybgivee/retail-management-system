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
    public partial class databill : Form
    {
        int n = 0;
        public databill()
        {
            InitializeComponent();
        }

        private void databill_Load(object sender, EventArgs e)
        {

        }

        private void datestart_ValueChanged(object sender, EventArgs e)
        {
            global.startdate.set(DateTime.Parse(datestart.Text));
        }

        private void dateend_ValueChanged(object sender, EventArgs e)
        {
            global.enddate.set(DateTime.Parse(dateend.Text));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try {
                DateTime start = global.startdate.get();
                DateTime end = global.enddate.get();
                String bcode = "";
                String bdate = "";
                String ball = "";
                String bpay = "";
                String emid = "";
                String mid = "";





                String dbins = "SELECT * FROM bill WHERE Bdate BETWEEN  @start AND @end; ";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);
                //  String nowday = ;

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);
                ins.Parameters.AddWithValue("@start", start);
                ins.Parameters.AddWithValue("@end", end);

                connectdb.Open();

                MySqlDataReader reader = ins.ExecuteReader();

                while (reader.Read())
                {
                    bcode = reader.GetString("Bcode");
                    bdate = reader.GetString("Bdate");
                    ball = reader.GetString("Ball");
                    bpay = reader.GetString("Bpay");
                    emid = reader.GetString("EMid");
                    mid = reader.GetString("Mid");
                    n++;
                    ListViewItem showorder = new ListViewItem(n.ToString());
                    showorder.SubItems.Add(bcode);
                    showorder.SubItems.Add(bdate);
                    showorder.SubItems.Add(ball);
                    showorder.SubItems.Add(bpay);
                    showorder.SubItems.Add(emid);
                    showorder.SubItems.Add(mid);

                    listbill.Items.Add(showorder);



                }
                connectdb.Close();
                
            }
            catch
            {
                MessageBox.Show("Error! Please try again");

            }
        }

        private void listbill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainem1 nextForm = new mainem1();
            nextForm.Show();
        }
    }
}
