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
    public partial class product : Form
    {
       
        public product()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try {
                String type, detail;


                type = type_find.Text;
                detail = txt_find.Text;


                String dbins = " SELECT typepro.TPcode,TPname,product.Pcode,pname,Pamount,SUPcost,Pprice FROM typepro,product,supdetail Where TypePro.TPcode = Product.TPcode AND Product.Pcode=supdetail.Pcode AND Product.TPcode= supdetail.TPcode ";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);
                //SELECT* FROM Contacts WHERE Name like @person + '%'    '" + @person + 


                if (type == "Product Name")
                {
                    dbins = " SELECT typepro.TPcode,typepro.TPname,product.Pcode,pname,Pamount,supdetail.SUPcost,Pprice FROM typepro,product,supdetail Where TypePro.TPcode = Product.TPcode AND Product.Pcode=supdetail.Pcode AND Product.TPcode= supdetail.TPcode AND Pname LIKE   '%" + @detail + "%' ";
                }
                if (type == "Retail Price")
                {
                    dbins = " SELECT typepro.TPcode,typepro.TPname,product.Pcode,pname,Pamount,supdetail.SUPcost,Pprice FROM typepro,product,supdetail Where TypePro.TPcode = Product.TPcode AND Product.Pcode=supdetail.Pcode AND Product.TPcode= supdetail.TPcode AND Pprice = @detail";

                }

                ins = new MySqlCommand(dbins, connectdb);


                ins.Parameters.AddWithValue("@detail", detail);



                connectdb.Open();
                MySqlDataReader reader = ins.ExecuteReader();

                while (reader.Read())
                {

                    ListViewItem showproduct = new ListViewItem(reader.GetString("TPcode"));
                    showproduct.SubItems.Add(reader.GetString("TPname"));
                    showproduct.SubItems.Add(reader.GetString("Pcode"));
                    showproduct.SubItems.Add(reader.GetString("Pname"));
                    showproduct.SubItems.Add(reader.GetString("Pamount"));
                    showproduct.SubItems.Add(reader.GetString("SUPcost"));
                    showproduct.SubItems.Add(reader.GetString("Pprice"));
                    listviewpro.Items.Add(showproduct);

                }
                connectdb.Close();
            }
            catch
            {
                MessageBox.Show("Sorry,No Match Found");
            }
        }

        private void product_Load(object sender, EventArgs e)
        {

        }

        private void listviewpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
