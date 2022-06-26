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
    public partial class sale : Form
    {
        
        int allamount = 0;
        int amount = 0;
        double allpay = 0;
        int n = 0;
        public sale()
        {
            InitializeComponent();
        }
        private void sale_Load(object sender, EventArgs e)
        {

            DateTime thisday = DateTime.Today;
            String nowday = thisday.ToString("d");
            selectmaxtpsale();
            selectmaxpsale();
            selectproductname();
            selectincome();
            txt_date.Text = nowday;
            global.dateday.set(nowday);
            txt_date.ReadOnly = true;
            selectemname();
            selectbillcode();
            
           
            selectnametp();
            
        }
        void selectbillcode()
        {
            String bill = "";
            String bcode = "";
            int bint = 0;


            String dbins = "SELECT * FROM Bill";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {

                bill = reader.GetString("Bcode");


            }

            bint = int.Parse(bill) + 1;
           
            txt_bill.Text = bint.ToString();
            txt_bill.ReadOnly = true;
            bint = int.Parse(bill);
            global.orcodeinc.setinc(bint);
           
            connectdb.Close();


        }
        
        void selectmaxtpsale()
        {


            String maxp = "";
            String maxtp = "";
            String dbins = "SELECT max(tpcode) FROM billdetail";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);



            connectdb.Open();



            String maxtpcode =  Convert.ToString(ins.ExecuteScalar());
           


            connectdb.Close();
           
            global.tpcode.set(maxtpcode);



        }
        void selectmaxpsale()
        {


           
            String dbins = "SELECT max(pcode) FROM billdetail";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);



            connectdb.Open();



            String maxpcode = Convert.ToString(ins.ExecuteScalar());



            connectdb.Close();

            global.pcode.set(maxpcode);



        }
        void selectproductname()
        {
            String pname = "";
            String tpcode = "";
            String pcode = "";
            tpcode = global.tpcode.get();
            pcode = global.pcode.get();
            String dbins = "SELECT * FROM product where pcode= @pcode AND tpcode = @tpcode";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            ins.Parameters.AddWithValue("@pcode", pcode);
            ins.Parameters.AddWithValue("@tpcode", tpcode);
            
            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
               pname = reader.GetString("Pname");


            }

            connectdb.Close();
            txt_salemax.Text = pname;
            txt_salemax.ReadOnly = true;
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
            String dbins = "SELECT TPcode FROM typepro WHERE TPname = @tpname";
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
            String pprice = "";
            double price = 0;
            String pamount = "";
            int amount = 0;
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
                pprice = reader.GetString("Pprice");
                pamount = reader.GetString("Pamount");
            }
            amount = int.Parse(pamount);
            price = Double.Parse(pprice);
            global.pcode.set(pcode);
            global.pprice.set(price);
            global.pamount.set(amount);
            connectdb.Close();

        }
        void selectMname()
        {
            String mid;
            mid = txt_memid.Text;
            global.mid.set(mid);
            String mname="";
            
                String dbins = "SELECT * FROM member WHERE Mid = @mid";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);
                ins.Parameters.AddWithValue("@mid", mid);
                connectdb.Open();
                MySqlDataReader reader = ins.ExecuteReader();

                while (reader.Read())
                {
                    mname = reader.GetString("Mname");


                }
            global.mname.set(mname);
                connectdb.Close();

           
           
              
           


        }
        void insertbill()
        {

                int bcode = 0;
                String emid = "";
                String mid = "";
                int allorder = 0;
                double bpay = 0;
                
                
                DateTime thisday = DateTime.Today;
                String nowday = thisday.ToString("d");
                bcode = global.orcodeinc.get();
           
                allorder = listsale.Items.Count;
                emid = global.emid.get();
                mid = global.mid.get();
                bpay = global.allpay.get();
           

            String dbins = "INSERT INTO bill(Bcode,Bdate,Ball,Bpay,EMid,Mid)VALUES(@bcode,@nowday,@allorder,@bpay,@emid,@mid)";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);

                ins.Parameters.AddWithValue("@bcode", bcode.ToString());
                ins.Parameters.AddWithValue("@nowday", thisday);
                ins.Parameters.AddWithValue("@allorder", allorder);
                ins.Parameters.AddWithValue("@bpay", bpay.ToString());
                ins.Parameters.AddWithValue("@emid", emid);
                ins.Parameters.AddWithValue("@mid", mid);


                connectdb.Open();
                ins.ExecuteNonQuery();
                
                connectdb.Close();
          
               
           







        }
        void insertbilldetail()
        {
            try
            {
                ListViewItem item = new ListViewItem();
                DateTime thisday = DateTime.Today;
                String nowday = thisday.ToString("d");
                int bcode;
                bcode = global.orcodeinc.get();


                int order = 0;
                int count = 0;
                String pprice = "";
                double price = 0;
                String ppay = "";

                double payam = 0;
                double payall = 0;
                double pay = 0;
                String pname = "";
                String tpname = "";

                String pamount = "";

                int bc = global.orcodeinc.get();

                String pcode = "", tpcode = "";

                int i = 0;





                String dbins = "INSERT INTO billdetail(Bcode,Bdate,TPcode,Pcode,BDamount,BDpay)VALUES(@bcode1,@bdate1,@tpcode1,@pcode1,@pamount1,@ppay1)";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);


                MySqlCommand ins = new MySqlCommand(dbins, connectdb);




                int n = listsale.Items.Count;
                for (i = 0; i < n; i++)
                {


                    dbins = "INSERT INTO billdetail(Bcode,Bdate,TPcode,Pcode,BDamount,BDpay)VALUES(@bcode1,@bdate1,@tpcode1,@pcode1,@pamount1,@ppay1)";
                    connectdb = new MySqlConnection(Connect.conins);
                    ins = new MySqlCommand(dbins, connectdb);
                    connectdb.Open();
                    item = listsale.Items[i];

                    pname = item.SubItems[1].Text;
                    global.pname.set(pname);
                    
                    pamount = item.SubItems[2].Text;
                   
                    ppay = item.SubItems[4].Text;
                    payall = double.Parse(ppay) + pay;
                 
                    tpname = item.SubItems[5].Text;
                    global.tpname.set(tpname);

                    selectPcode();
                    pcode = global.pcode.get();
                    selectTPcode();
                    tpcode = global.tpcode.get();


                    ins.Parameters.AddWithValue("@bcode1", bcode.ToString());
                    ins.Parameters.AddWithValue("@bdate1", thisday);
                    ins.Parameters.AddWithValue("@tpcode1", tpcode);
                    ins.Parameters.AddWithValue("@pcode1", pcode);
                    ins.Parameters.AddWithValue("@pamount1", pamount);
                    ins.Parameters.AddWithValue("@ppay1", ppay);



                    ins.ExecuteNonQuery();

                    connectdb.Close();

                }

                global.allpay.set(payall);
                MessageBox.Show("Succesfully");
                
            }
            catch { MessageBox.Show("Error! Please try again"); } 
           



        }
        void updateproductbill()
        {
            try {
                String tpcode = "", tpname = "";
                String pcode = "", pname = "";
                String peamount = "";
                int amount = 0;
                int n = listsale.Items.Count;
                ListViewItem item = new ListViewItem();
                int count = 0;
                String profi = "", supco = "";
                int supcost = 0;
                int amountold = 0;
                double profit = 0, price = 0;


                String dbins = "UPDATE product SET Pamount = @amount WHERE TPcode = @tpcode AND Pcode = @pcode; ";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);
                //  String nowday = ;

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);


                connectdb.Open();




                for (int i = 0; i < n; i++)
                {

                    item = listsale.Items[i];

                    count = i;
                    pname = item.SubItems[1].Text;
                    global.pname.set(pname);
                    peamount = item.SubItems[2].Text;
                    amount = int.Parse(peamount);

                    tpname = item.SubItems[5].Text;
                    global.tpname.set(tpname);

                    pcode = global.pcode.get();
                    tpcode = global.tpcode.get();
                    amountold = global.pamount.get();
                    if (amountold >= amount)
                    {
                        amount = amountold - amount;
                    }
                    else if (amountold < amount)
                    {

                        MessageBox.Show("Incorrect Data! Please try again");
                    }


                    ins.Parameters.AddWithValue("@amount", amount);
                    ins.Parameters.AddWithValue("@tpcode", tpcode);
                    ins.Parameters.AddWithValue("@pcode", pcode);




                    ins.ExecuteNonQuery();



                }
                connectdb.Close();
                MessageBox.Show("Added");

            }
            catch {
            }



               
         

        }


        private void listsale_doubleclick(object sender, EventArgs e)
        {
            int n = listsale.Items.Count;
            for (int i = 0; i < n; i++)
            {

                if (listsale.Items[i].Selected)
                {
                    listsale.Items[i].BackColor = Color.Red;
                    listsale.Items[i].Remove();

                }

            }

        }

        private void btn_addclick(object sender, EventArgs e)
        {
            int amountcheck = 0;
            int success = 1;
            amountcheck = global.pamount.get();
            if (int.Parse(txt_amount.Text) > amountcheck)
            {
                MessageBox.Show("Exceed Remaining Stock  ");
                MessageBox.Show("Stock Remain" + amount.ToString() + "Unit");
                
            
                success = 0;
            }
            String emname = global.emname.get();
            if (emname != null && success!=0)
            {
                double priceall = 0;
                double price = 0;
                
                String am = "";
                price = global.pprice.get();
                

                n++;
                ListViewItem showorder = new ListViewItem(n.ToString());
                showorder.SubItems.Add(namepro.SelectedItem.ToString());
                showorder.SubItems.Add(txt_amount.Text);
                 am= txt_amount.Text;
                amount = int.Parse(am);
                
                allamount = allamount + amount;

                showorder.SubItems.Add(price.ToString());
                priceall = price * amount;
                allpay = allpay + priceall;
               
                showorder.SubItems.Add(priceall.ToString());
                showorder.SubItems.Add(tpname.Text);
                listsale.Items.Add(showorder);
                
                global.allpay.set(allpay);
                global.allamount.set(allamount);
                String allam = "", allp = "";
                allam = allpay.ToString();
                allp = allamount.ToString();

                txt_allam.Text = allam;
                txt_allpay.Text = allp;
            }
            else if (emname == null)
            {
                MessageBox.Show("Please fill the employee name");

            }

            tpname.Text = string.Empty;
            namepro.Text = string.Empty;
            namepro.Items.Clear();
            txt_amount.Text = String.Empty;
            
    }

        private void btn_save_Click(object sender, EventArgs e)
        {

          
                global.orcodeinc.setinc(global.orcodeinc.get() + 1);
                insertbill();
                insertbilldetail();
                updateproductbill();
                updateincome();

            listsale.Clear();
            txt_allpay.Text = String.Empty;
            txt_allam.Text = String.Empty;
            txt_memid.Text = String.Empty;
            txt_memname.Text = String.Empty;
            emname.Text = String.Empty;


        }

        private void tpname_SelectedIndexChanged(object sender, EventArgs e)
        {
            namepro.Items.Clear();
            global.tpname.set(tpname.SelectedItem.ToString());
            selectTPcode();
            selectnamep();
        }

        private void namepro_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.pname.set(namepro.SelectedItem.ToString());
            selectPcode();
          
        }

        private void emname_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.emname.set(emname.SelectedItem.ToString());
            
            selectemid();
        }

        private void txt_memid_TextChanged(object sender, EventArgs e)
        {
            try
            {

                selectMname();
                String mname = global.mname.get();
                txt_memname.Text = mname;
            }

            catch
            {
                MessageBox.Show("Member ID is incorrect, Please try again");
            }

            
        }

        private void txt_memname_TextChanged(object sender, EventArgs e)
        {
            txt_memname.ReadOnly = true;
        }

        void updateincome()
        {
            try
            {
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
                newvalue = oldv + allpay;


                String dbins = "UPDATE income SET INvalue = @newvalue WHERE INcode = @incode";
                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);

                ins.Parameters.AddWithValue("@incode", incode);
                ins.Parameters.AddWithValue("@newvalue", newvalue);

                connectdb.Open();


                ins.ExecuteNonQuery();

                connectdb.Close();

            }
            catch
            {



            }


        }

        void selectincome()
        {
            DateTime thisday = DateTime.Today;
            String value = "";
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
                value = reader.GetString("INvalue");



            }

            global.oldvaluein.set(value);
            global.incode.set(incode);
            connectdb.Close();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           Mainem nextForm = new Mainem();
            nextForm.Show();
            this.Hide();
        }
    }
}
