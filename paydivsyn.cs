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
    public partial class paydivsyn : Form
    {
        double divpp = 0;
        double remain = 0;
        double paydiv = 0;
        int n = 0;
        double allpay = 0;
        String pdcodeempty = "";
        int success = 1;
        String pdname = "";
        double pdpay = 0;
        public paydivsyn()
        {
            InitializeComponent();
        }

        private void paydivsyn_Load(object sender, EventArgs e)
        {
            DateTime thisday = DateTime.Today;
            String nowday = thisday.ToString("d");
            selectincome();
            txt_date.Text = nowday;
            global.dateday.set(nowday);
            txt_date.ReadOnly = true;
            selectemname();
            selectpdemcode();
        }
        void selectbill()
        {
            double allbuy = 0;
            double all = 0;
            DateTime startdate = DateTime.Today;
            DateTime enddate = DateTime.Today;
            String mid = "";

            startdate = global.startdate.get();
            enddate = global.enddate.get();
            mid = global.mid.get();
            
            String buy = "";
           

            String dbins = "SELECT * FROM bill WHERE " + " Bdate BETWEEN @startdate  AND   @enddate";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);



            ins.Parameters.AddWithValue("@startdate", startdate);
            ins.Parameters.AddWithValue("@enddate", enddate);
           

            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();


            while (reader.Read())
            {

                buy = reader.GetString("Bpay");
                allbuy = double.Parse(buy);
                all = allbuy + all;

            }
            connectdb.Close();
            global.allpay.set(all);
           

        }
        void selectexpen()
        {
            String pay = "";
           
            double all = 0;
            DateTime startdate = DateTime.Today;
            DateTime enddate = DateTime.Today;
            startdate = global.startdate.get();
            enddate = global.enddate.get();
            String dbins = "SELECT * FROM expen WHERE " + " EXdate BETWEEN @startdate  AND   @enddate";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);



            ins.Parameters.AddWithValue("@startdate", startdate);
            ins.Parameters.AddWithValue("@enddate", enddate);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();


            while (reader.Read())
            {

                pay = reader.GetString("EXpay");
                allpay = double.Parse(pay);
                all = allpay + all;

            }
            connectdb.Close();

            global.expenpay.set(all);
            


        }
        void selectproexpen()
        {
            String propay = "";
            double allpay = 0;
            double all = 0;
            DateTime startdate = DateTime.Today;
            DateTime enddate = DateTime.Today;
            startdate = global.startdate.get();
            enddate = global.enddate.get();
            String dbins = "SELECT * FROM proexpen WHERE " + " PEdate BETWEEN @startdate  AND   @enddate";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);



            ins.Parameters.AddWithValue("@startdate", startdate);
            ins.Parameters.AddWithValue("@enddate", enddate);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();


            while (reader.Read())
            {

                propay = reader.GetString("PEpay");
                allpay = double.Parse(propay);
                all = allpay + all;

            }
            connectdb.Close();

            global.expenpro.set(all);
           


        }
        void selectpdemcode()
        {
            String pd = "";
            String pdcode = "";
            int pdint = 0;
            int pdc = 0;
            String startdate = "";
            String enddate = "";

            String dbins = "SELECT * FROM paydivem";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {

                pdcode = reader.GetString("PDEcode");
                startdate = reader.GetString("PDEstart");
                enddate = reader.GetString("PDEend");

            }

            pdint = int.Parse(pdcode) + 1;
            txt_bill.Text = pdint.ToString();
            global.startdateold.set(DateTime.Parse(startdate));
            global.enddateold.set(DateTime.Parse(enddate));
            global.paydivcode.set(pdcode);
            connectdb.Close();


        }
        void selectemname()
        {
            String emtype = "SP";
            String dbins = "SELECT * FROM employee WHERE Emtype = @emtype ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@emtype", emtype);


            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();



            while (reader.Read())
            {
                emnames.Items.Add(reader.GetString("EMname"));


            }

            
            connectdb.Close();

        }
      

        private void adddiv_Click(object sender, EventArgs e)
        {
           
            
            double allbill = 0;
            double allex = 0;
            double allexp = 0;
            double mpay = 0;
            double pdpay = 0;
            double total = 0;
            DateTime std = DateTime.Today;
            DateTime end = DateTime.Today;
            String mid = "";
            String mname = "";
            String emname = "";
            emname = global.emname.get();
            double pay = double.Parse(global.oldvaluein.get());
            


            if (emname != null)
            {




                mname = global.mname.get();
                allbill = global.allpay.get();
                divpp = allbill + divpp;
                allex = global.expenpay.get();
                allexp = global.expenpro.get();
                
                std = global.startdate.get();
                end = global.enddate.get();

                n++;
                ListViewItem showorder = new ListViewItem(n.ToString());
                showorder.SubItems.Add(mname);
                showorder.SubItems.Add(allbill.ToString());               
                showorder.SubItems.Add(std.ToString());
                showorder.SubItems.Add(end.ToString());
                showorder.SubItems.Add(mpay.ToString());
                listdiv.Items.Add(showorder);
               

            }
            else if (emname == null)
            {
                MessageBox.Show("กรุณากรอกชื่อพนักงาน");

            }
            
            

           
            global.orcodeinc.setinc(global.orcodeinc.get() + 1);
            int excodet = global.orcodeinc.get();
            global.alldiv.set(divpp);
            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void emnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.emname.set(emnames.SelectedItem.ToString());
           
        }

        private void divname_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.exname.set(divname.SelectedItem.ToString());
        }
        void insertdiv()
        {

            int pdcode = 0;

            String emid = "";
            String emname = "";
            DateTime std = DateTime.Today;
            DateTime end = DateTime.Today;
            std = global.startdate.get();
            end = global.enddate.get();
            double pdpay = 0;
           
           
            ListViewItem item = new ListViewItem();
            int n = listdiv.Items.Count;
            
            int count = 0;
            DateTime thisday = DateTime.Today;
           
            emid = global.emid.get();
           
            String dbins = "INSERT INTO paydivem(PDEcode,PDEdate,PDEstart,PDEend,PDEprofit,PDEpay,paydivem.EMid)VALUES(@i,@j,@k,@l,@m,@n,@o)";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            connectdb.Open();

            for (int i = 0; i < n; i++)
            {
                dbins = "INSERT INTO paydivem(PDEcode,PDEdate,PDEstart,PDEend,PDEprofit,PDEpay,paydivem.EMid)VALUES(@i,@j,@k,@l,@m,@n,@o)";
                connectdb = new MySqlConnection(Connect.conins);
                connectdb.Open();
                ins = new MySqlCommand(dbins, connectdb);
                item = listdiv.Items[i];
                emname = item.SubItems[1].Text;
                global.divemname.set(emname);
                pdpay = double.Parse(item.SubItems[2].Text);
                emid = global.emid.get();
                std = global.startdate.get();
                end = global.enddate.get();

              

                ins.Parameters.AddWithValue("@i", pdcodeempty);
                ins.Parameters.AddWithValue("@j", thisday);
                ins.Parameters.AddWithValue("@k", std);
                ins.Parameters.AddWithValue("@l", end);
                ins.Parameters.AddWithValue("@m", txt_profit.Text);
                ins.Parameters.AddWithValue("@n", pdpay);
                ins.Parameters.AddWithValue("@o", emid);


            


                ins.ExecuteNonQuery();

                connectdb.Close();


            }
            

           



        }

        private void listdiv_doubleclick(object sender, EventArgs e)
        {
            int n = listdiv.Items.Count;
            for (int i = 0; i < n; i++)
            {

                if (listdiv.Items[i].Selected)
                {
                    listdiv.Items[i].BackColor = Color.Red;
                    listdiv.Items[i].Remove();

                }

            }
        }

        private void datestart_ValueChanged(object sender, EventArgs e)
        {
            global.startdate.set(DateTime.Parse(datestart.Text));
        }

        private void dateend_ValueChanged(object sender, EventArgs e)
        {
            global.enddate.set(DateTime.Parse(dateend.Text));
            
        }

       

        private void txt_allbuy_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void emnames_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            global.divemname.set(emnames.SelectedItem.ToString());
            
            selectemid();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            double allexpen = 0;
            double expen = 0;
            double income = 0;
            double all = 0;
            double divpay = 0;
            double divtotal = 0;
            divpay = global.alldiv.get();
            selectemid();
            selectbill();
            selectexpen();
            selectproexpen();
            
            allexpen = global.expenpay.get() + global.expenpro.get();
            txt_expen.Text = allexpen.ToString();

            
            String allpay = "";
            allpay = global.allpay.get().ToString();
            txt_income.Text = allpay;

            expen = double.Parse(txt_expen.Text);
            income = double.Parse(txt_income.Text);
            all = income - expen;
            txt_profit.Text = all.ToString();
            divtotal = income - divpay;
           
            if (all > 0) {

                selectallem();
            }
            else
            {

                MessageBox.Show("รายจ่ายมากกว่ารายรับ " + all.ToString()+"บาท");
            }
           
        }

        void selectpdemdate()
        {


            DateTime startnew = global.startdate.get();
            DateTime endnew = global.enddate.get();

            String starts = "";
            String ends = "";
            String mid = "";

           
            
            String dbins = "SELECT * FROM paydivem ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
           

            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                //global.startdate.set(DateTime.Parse(datestart.Text));

                starts = reader.GetString("PDEstart");
                ends = reader.GetString("PDEend");
                if (startnew == DateTime.Parse(starts) && endnew == DateTime.Parse(ends))
                {
                    success = 0;
                }


            }
            connectdb.Close();

            global.startdateold.set(DateTime.Parse(starts));
            global.enddateold.set(DateTime.Parse(ends));

        }

        void selectallem()
        {
            
            String emname = "";
            String empay = "";
            double emp = 0;
            double empp = 0;
            String emid = "";

            DateTime std = DateTime.Today;
            DateTime end = DateTime.Today;
            std = global.startdate.get();
            end = global.enddate.get();
            int pdecode = global.orcodeinc.get()+1;
            double recieve = 0;
            double allpay = 0;
            double propay = 0;
            double expay = 0;
            allpay = global.allpay.get();
            expay = global.expenpay.get();
            propay = global.expenpro.get();
          
           
            
            empp = global.mpay.get();

            String dbins = "SELECT * FROM employee ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
          


            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();



            while (reader.Read())
            {
                n++;
                emname =   reader.GetString("EMname");
                empay = reader.GetString("EMpay");
                emid = reader.GetString("EMid");
                empp = double.Parse(empay);
                ListViewItem showorder = new ListViewItem(n.ToString());
                showorder.SubItems.Add(emname);
                recieve = (allpay - (expay + propay)) * empp;
                showorder.SubItems.Add(recieve.ToString());
                showorder.SubItems.Add(std.ToString());
                showorder.SubItems.Add(end.ToString());
                showorder.SubItems.Add(empay.ToString());
                showorder.SubItems.Add(pdecode.ToString());
                listdiv.Items.Add(showorder);
                pdecode++;
               
            }


            connectdb.Close();
            
           


        }
        

        private void txt_payexpen_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void allrecieve_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            DateTime enddateold = global.enddateold.get();
            DateTime enddatenew = global.enddate.get();
            selectpdemdate();
            if (success == 1)
            {
                String inc = "";
                double income = 0;
                double pay = 0;
                double result = 0;
                insertdiv();
                updateincome();
                txt_allpay.Text = txt_profit.Text;
                pay = double.Parse(txt_allpay.Text);
                selectincome();
                inc = global.oldvaluein.get();
                MessageBox.Show(inc);
                income = double.Parse(inc);
                result = income - pay;
                MessageBox.Show(result.ToString());
                txt_allre.Text = result.ToString();
                MessageBox.Show("บันทีกข้อมูลปันผลคณะกรรมการสำเร็จ");
               
            }
            else
            {

                MessageBox.Show("ปันผลในวันที่"+global.startdate.get().ToString()+"ถึงวันที่"+ global.enddate.get().ToString()+"ถูกจ่ายไปเรียบร้อยเเล้ว");
            }


          
          

        }
        void selectemid()
        {



            String emid = "";
            String emname = "";
            emname = global.divemname.get();
            
            String dbins = "SELECT * FROM employee WHERE EMname = @emname";
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

        void updateincome()
        {
            try
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

            catch {  }







        }
        void selectincome()
        {
            DateTime thisday = DateTime.Today;
            String value = "";
            String incode = "";
            String dbins = "SELECT * FROM income ";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
           


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
        public static bool notbetween(DateTime input, DateTime max)
        {

            return (input >= max);


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Mainsp nextForm = new Mainsp();
            nextForm.Show();
            this.Hide();
        }

        private void listdiv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_allre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
