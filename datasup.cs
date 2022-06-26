using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace $safeprojectname$
{
    public partial class datasup : Form
    {
        public datasup()
        {

            InitializeComponent();
            int order = 0;
            String dbins = " SELECT DISTINCT supplier.SUPcode,supplier.SUPname,supplier.SUPcontact,typepro.TPname,product.Pname FROM supplier,product,typepro,supdetail WHERE supplier.SUPcode=supdetail.SUPcode AND supdetail.TPcode = Product.TPcode AND supdetail.Pcode = Product.Pcode AND typepro.TPcode = product.TPcode GROUP BY SUPcode,supdetail.TPcode,supdetail.Pcode ";
            MySqlConnection connectdb = new MySqlConnection("host=localhost;user=dba;password=2559;database=projectdb;CharSet=utf8;");

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            ins = new MySqlCommand(dbins, connectdb);
            int n = 0;
            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            order = 1;

            while (reader.Read())
            {
                

                
                ListViewItem showsup = new ListViewItem(order.ToString());
                
                showsup.SubItems.Add(reader.GetString("Pname"));
                showsup.SubItems.Add(reader.GetString("TPname"));
                showsup.SubItems.Add(reader.GetString("SUPcode"));
                showsup.SubItems.Add(reader.GetString("SUPname"));
                showsup.SubItems.Add(reader.GetString("SUPcontact"));
                listviewsup.Items.Add(showsup);

                order = order + 1;
                n++;


            }
            Globals.set(n);
            connectdb.Close();




        }
        public static class Globals
        {

            public static int countloop = 0; // Unmodifiable

            public static void set(int newInt)
            {
                countloop = newInt;
            }

            public static int get()
            {
                return countloop;
            }




        }

        private void listviewsup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            supdetail nextForm = new supdetail();
            nextForm.Show();
        }

        private void datasup_Load(object sender, EventArgs e)
        {

        }
    }
}
