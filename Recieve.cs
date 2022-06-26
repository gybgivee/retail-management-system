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
    public partial class Recieve : Form
    {
        double allpay = 0;
        int n = 0;
        int allamount = 0;
        public Recieve()
        {
            InitializeComponent();
        }

        private void Recieve_Load(object sender, EventArgs e)
        {

            DateTime thisday = DateTime.Today;
            String nowday = thisday.ToString("d");
            selectincome();
            txt_date.Text = nowday;
            global.dateday.set(nowday);
            selectemname();
            selectpecode();
            selectnametp();
        }
        void selectpecode()
        {
            String pe = "";
            int peint = 0;

            String dbins = "SELECT PEcode FROM proexpen";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {

                pe = reader.GetString("PEcode");


            }

            peint = int.Parse(pe) + 1;
            pecode.Items.Add(peint);
           
            connectdb.Close();


        }


        void selectsupcode()
        {



            String supcode = "";
            String supname = global.supname.get();
            String dbins = "SELECT * FROM supplier WHERE SUPname = @supname ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            ins.Parameters.AddWithValue("@supname", supname);

            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                supcode = reader.GetString("SUPcode");


            }

            global.supcode.set(supcode);
            connectdb.Close();

        }
        void selectsupname()
        {
            String supname = "";

            String tpname = "";
            String pname = "";

            tpname = global.tpname.get();
            pname = global.pname.get();
            /* SELECT Student_Fname, Student_Lname
             FROM Student
             WHERE Age = (SELECT Age FROM Student WHERE Student_Fname = 'เยาวภา');*/
            String dbins = "SELECT DISTINCT SUPname FROM supplier,supdetail,product,typepro WHERE supplier.SUPcode = (SELECT SUPcode from supdetail WHERE supdetail.TPcode = (SELECT TPcode FROM typepro WHERE TPname = @tpname) AND supdetail.pcode = (SELECT Pcode FROM product WHERE product.Pname = @pname)) AND supdetail.TPcode = (SELECT TPcode FROM typepro WHERE TPname = @tpname) AND supdetail.pcode = (SELECT Pcode FROM product WHERE product.Pname = @pname) ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            ins.Parameters.AddWithValue("@tpname", tpname);
            ins.Parameters.AddWithValue("@pname", pname);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            
            while (reader.Read())
            {
                

                suppname.Items.Add(reader.GetString("SUPname"));


            }



            connectdb.Close();

        }




        void selectemname()
        {
            String emtype = "Em";
            String dbins = "SELECT* FROM employee WHERE Emtype = @emtype ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@emtype", emtype);


            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();



            while (reader.Read())
            {
                emname.Items.Add(reader.GetString("Emname"));


            }


            connectdb.Close();

        }
        void selectemid()
        {
            String emname = global.emname.get();
            String emid = "";
            String dbins = "SELECT Emid FROM employee where Emname = @emname ";

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

        void selectnamep()
        {
            String tpname = "";
            String tpcode = "";
            tpcode = global.tpcode.get();
            tpname = global.tpname.get();
            String dbins = "SELECT Pname FROM product,typepro where typepro.TPname = @typename AND product.TPcode = @typepcode";

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
            String pamount = "";
            int amount=0;
            pname = global.pname.get();
            String dbins = "SELECT * FROM product WHERE pname = @pname";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@pname", pname);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                pcode = reader.GetString("Pcode");
                pamount = reader.GetString("Pamount");

            }
            global.pcode.set(pcode);
            amount = int.Parse(pamount);
            global.pamount.set(amount);
            connectdb.Close();

        }
        void selectsupcost()
        {


            String tpname = "";
            String pname = "";
            String supname = "";
            String cost = "";
            string supcost = "";
            supname = global.supname.get();
            pname = global.pname.get();
            tpname = global.tpname.get();

            String dbins = "SELECT DISTINCT SUPcost FROM supplier,supdetail,product,typepro WHERE supplier.SUPcode = (SELECT SUPcode from supdetail WHERE supdetail.TPcode = (SELECT TPcode FROM typepro WHERE TPname = @tpname) AND supdetail.pcode = (SELECT Pcode FROM product WHERE product.Pname = @pname)) AND supdetail.TPcode = (SELECT TPcode FROM typepro WHERE TPname = @tpname) AND supdetail.pcode = (SELECT Pcode FROM product WHERE product.Pname = @pname) ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("supname", supname);
            ins.Parameters.AddWithValue("tpname", tpname);
            ins.Parameters.AddWithValue("pname", pname);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {

                supcost = reader.GetString("SUPcost");


            }
            global.supcost.set(supcost);






            connectdb.Close();




        }

        private void btn_sayepe(object sender, EventArgs e)
        {
            insertproexpen();
            int or = 0;
            or = int.Parse(global.orcode.get());
            global.orcodeinc.setinc(or);
            insertrecieve();
            updateproduct();
            updateincome();
        }

        private void btn_addpro(object sender, EventArgs e)
        {
           
            String emname = global.emname.get();
            if (emname != null)
            {
                
                double supcost = 0;
                double supall = 0;
                int amount;
                String am = txt_amount.Text;
               
                String sup = "";
                amount = int.Parse(am);
                allamount = amount + allamount;
                sup = global.supcost.get();
                supcost = double.Parse(sup);

                n++;
                ListViewItem showorder = new ListViewItem(n.ToString());
                showorder.SubItems.Add(namepro.SelectedItem.ToString());
                showorder.SubItems.Add(txt_amount.Text);
                showorder.SubItems.Add(supcost.ToString());
                supall = supcost * amount;
                allpay = allpay + supall;
                showorder.SubItems.Add(supall.ToString());
                showorder.SubItems.Add(suppname.Text);
                showorder.SubItems.Add(tpname.Text);
                liststock.Items.Add(showorder);
                /*nametype.Text = String.Empty;
                namepro.Text = String.Empty;
                amountpro.Text = String.Empty;
                */
                global.allpay.set(allpay);
                txt_allam.Text = allamount.ToString();
                txt_allpay.Text = allpay.ToString();
            }
            else if (emname == null)
            {
                MessageBox.Show("กรุณากรอกชื่อพนักงาน");

            }
            
            tpname.Text = string.Empty;
            
            namepro.Text = string.Empty;
            namepro.Items.Clear();
            suppname.Text = string.Empty;
            suppname.Items.Clear();
            txt_amount.Text = String.Empty;
        }

        private void listbuy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void liststock_doubleclick(object sender, EventArgs e)
        {
            int n = liststock.Items.Count;
            for (int i = 0; i < n; i++)
            {

                if (liststock.Items[i].Selected)
                {
                    liststock.Items[i].BackColor = Color.Red;
                    liststock.Items[i].Remove();

                }

            }

        }

        private void suppname_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.tpname.set(tpname.SelectedItem.ToString());
            global.pname.set(namepro.SelectedItem.ToString());
            global.supname.set(suppname.SelectedItem.ToString());


            selectsupcost();
            selectsupcode();
            
        }

        private void emname_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.emname.set(emname.SelectedItem.ToString());
            emname.Enabled = false;

            selectemid();

        }

        private void tpname_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.tpname.set(tpname.SelectedItem.ToString());

            selectTPcode();
            selectnamep();
           
            selectTPprofit();
            
        }

        private void namepro_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.pname.set(namepro.SelectedItem.ToString());
            
            selectsupname();
            selectPcode();
            

        }

        private void pecode_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.orcode.set(pecode.SelectedItem.ToString());
            pecode.Enabled = false;
            
        }
        void insertproexpen()
        {

            try
            {
                int pecode = 0;
                int pe = 0;

                String emid = "";
                int allorder = 0;
                double pay = 0;
                
                pe = global.orcodeinc.get();
                pecode = pe;
                DateTime thisday = DateTime.Today;
                String nowday = thisday.ToString("d");

                allorder = liststock.Items.Count;
                emid = global.emid.get();
                pay = global.allpay.get();

                String dbins = "INSERT INTO proexpen(PEcode,PEdate,PEorder,PEpay,EMid)VALUES(@pecode,@nowday,@allorder,@pay,@emid)";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);

                ins.Parameters.AddWithValue("@pecode", pecode);
                ins.Parameters.AddWithValue("@nowday", thisday);
                ins.Parameters.AddWithValue("@allorder", allorder);
                ins.Parameters.AddWithValue("@pay", pay);
                ins.Parameters.AddWithValue("@emid", emid);


                connectdb.Open();
                ins.ExecuteNonQuery();
                MessageBox.Show("บันทึกใบเสร็จรับสินค้าเรียบร้อยเเล้ว");
                connectdb.Close();
            }
            catch
            {
                MessageBox.Show("บันทึกใบเสร็จรับสินค้าไม่สำเร็จ กรุณาตรวจสอบข้อมูลอีกครั้ง");
            }

        }
        void insertrecieve()
        {
            try
            {
                ListViewItem item = new ListViewItem();
                int order = 0;
                int count = 0;

                double cost = 0;
                String supcost = "";
                String pname = "";
                String tpname = "";
                String supname = "";
                String pec = "";
                int amount = 0;
                int pecode = 0;

                String nowday = "";
                String peamount = "";
                String supcode = "", pcode = "", tpcode = "";
                String pedate = "";
                int n = 0;
                pecode = global.orcodeinc.get();

                DateTime thisday = DateTime.Today;
                nowday = thisday.ToString("d");






                n = liststock.Items.Count;
            

                String dbins = "INSERT INTO recieve(PEcode,PEdate,SUPcode,TPcode,Pcode,REamount)VALUES(@a,@b,@c,@d,@e,@f)";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);
                //  String nowday = ;

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);


                connectdb.Open();

                for (int i = 0; i < n; i++)
                {

                    item = liststock.Items[i];


                    count = i;
                    pname = item.SubItems[1].Text;
                    global.pname.set(pname);

                    peamount = item.SubItems[2].Text;
                    amount = int.Parse(peamount);

                    supname = item.SubItems[5].Text;
                    global.supname.set(supname);

                    tpname = item.SubItems[6].Text;
                    global.tpname.set(tpname);

                    supcode = global.supcode.get();

                    pcode = global.pcode.get();


                    tpcode = global.tpcode.get();



                    ins.Parameters.AddWithValue("@a", pecode);
                    ins.Parameters.AddWithValue("@b", thisday);
                    ins.Parameters.AddWithValue("@c", supcode);
                    ins.Parameters.AddWithValue("@d", tpcode);
                    ins.Parameters.AddWithValue("@e", pcode);
                    ins.Parameters.AddWithValue("@f", amount);


                    ins.ExecuteNonQuery();



                }
                connectdb.Close();
            }
            catch
            {

            }

           
            

        }
        void selectTPprofit()
        {
            string tpcode = global.tpcode.get();
            String tpprofit = "";
            String dbins = "SELECT TPprofit FROM typepro WHERE TPcode = @tpcode";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@tpcode", tpcode);
            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

           

            while (reader.Read())
            {
                tpprofit = reader.GetString("TPprofit");


            }
            global.TPprofit.set(tpprofit);


            connectdb.Close();

        }
        void updateproduct()
        {
            try {
                String supcode = "", supname = "";
                String tpcode = "", tpname = "";
                String pcode = "", pname = "";
                String peamount = "";
                int amount = 0;
                int n = liststock.Items.Count;
                ListViewItem item = new ListViewItem();
                int count = 0;
                String profi = "", supco = "";
                int supcost = 0;
                int amountold = 0;
                double profit = 0, price = 0;


                String dbins = "UPDATE product SET Pamount = @amount, Pprice = @price WHERE TPcode = @tpcode AND Pcode = @pcode; ";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);
                //  String nowday = ;

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);


                connectdb.Open();




                for (int i = 0; i < n; i++)
                {

                    item = liststock.Items[i];

                    count = i;
                    pname = item.SubItems[1].Text;
                    global.pname.set(pname);
                    peamount = item.SubItems[2].Text;
                    amount = int.Parse(peamount);
                    supname = item.SubItems[5].Text;
                    global.supname.set(supname);
                    tpname = item.SubItems[6].Text;
                    global.tpname.set(tpname);
                    supcode = global.supcode.get();
                    pcode = global.pcode.get();
                    tpcode = global.tpcode.get();
                    amountold = global.pamount.get();
                    amount = amountold + amount;
                    profi = global.TPprofit.get();
                    profit = Double.Parse(profi);
                    supco = global.supcost.get();
                    supcost = int.Parse(supco);
                    price = supcost * profit;
                    ins.Parameters.AddWithValue("@amount", amount);
                    ins.Parameters.AddWithValue("@price", price);
                    ins.Parameters.AddWithValue("@tpcode", tpcode);
                    ins.Parameters.AddWithValue("@pcode", pcode);




                    ins.ExecuteNonQuery();



                }
                connectdb.Close();
                MessageBox.Show("update product complete");
            }
            catch
            {
                MessageBox.Show("cannot update product");
            }

        }
        void updateincome()
        {
            DateTime thisday = DateTime.Today;
            double oldv = 0;
                double allpay = 0;
                double newvalue = 0;
                String incode = "";
                String invalue = "";
                String oldvalue = "";
                incode = global.incode.get();
                oldvalue = global.oldvaluein.get();
                oldv = double.Parse(oldvalue);
                allpay = global.allpay.get();
                newvalue = oldv - allpay;

               

                String dbins = "UPDATE income SET INvalue = @newvalue ,INdate = @indate  WHERE INcode = @incode";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);

                ins.Parameters.AddWithValue("@incode", incode);
                ins.Parameters.AddWithValue("@indate", thisday);
                ins.Parameters.AddWithValue("@newvalue", newvalue);

                connectdb.Open();


                ins.ExecuteNonQuery();

                connectdb.Close();
               
           

         

           




        }
        void selectincome()
        {
            DateTime thisday = DateTime.Today;
            String value="";
            String incode = "";
            String dbins = "SELECT * FROM income ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@nowday", thisday);


            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();



            while (reader.Read())
            {
                incode = reader.GetString("INcode");
                value =reader.GetString("INvalue");



            }

            global.oldvaluein.set(value);
            global.incode.set(incode);
            connectdb.Close();

        }


        private void txt_amont_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_date_TextChanged(object sender, EventArgs e)
        {
            txt_date.ReadOnly = true;
        }

        private void txt_allam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
