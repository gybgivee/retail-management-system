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
    public partial class paydivm : Form
    {
        int n = 0;
        int success = 1;
        String pdcodeempty = "";
      
        String pdname = "";
        double pdpay = 0;
        public paydivm()
        {
            InitializeComponent();
        }


        private void paydivm_Load(object sender, EventArgs e)
        {
            DateTime thisday = DateTime.Today;
            String nowday = thisday.ToString("d");
            selectincome();
            txt_date.Text = nowday;
            global.dateday.set(nowday);
            txt_date.ReadOnly = true;
            selectemname();
            selectpdmcode();
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
            mid = txt_memid.Text;
            MessageBox.Show(txt_memid.Text);
            String buy = "";
            MessageBox.Show(startdate.ToString());
            MessageBox.Show(enddate.ToString());

            String dbins = "SELECT * FROM bill WHERE  Mid = @mid  " +" AND "+ " Bdate BETWEEN @startdate  AND   @enddate";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            
            ins.Parameters.AddWithValue("@startdate", startdate);
            ins.Parameters.AddWithValue("@enddate", enddate);
            ins.Parameters.AddWithValue("@mid", mid);

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
            txt_allbuy.Text = all.ToString();
                       
        }
        void selectpdmcode()
        {
            String pd = "";
            String pdcode = "0";
            int pdint = 0;
            int pdc = 0;
            String start = "";
            String end = "";



            String dbins = "SELECT * FROM paydivmem";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                //global.startdate.set(DateTime.Parse(datestart.Text));
                pdcode = reader.GetString("PDMcode");
                


            }

            pdint = int.Parse(pdcode);
              pdint =   pdint + 1;
            
            txt_bill.Text = pdint.ToString();
            txt_bill.ReadOnly = true;
            global.orcodeinc.setinc(pdint);
            connectdb.Close();


        }
        void selectemname()
        {
            String emtype = "Em";
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
        void selectemid()
        {

            String emname = global.emname.get();
            String emid = "";
            String dbins = "SELECT * FROM employee where EMname = @emname ";

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
        void selectpdmdate()
        {


            DateTime startnew= global.startdate.get();
            DateTime endnew= global.enddate.get();

            String starts = "";
            String ends = "";
            String mid = "";
            mid = txt_memid.Text;


            String dbins = "SELECT * FROM paydivmem WHERE Mid = @mid";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@mid",mid);

            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                //global.startdate.set(DateTime.Parse(datestart.Text));
               
                starts = reader.GetString("PDMstart");
                ends = reader.GetString("PDMend");
                if(startnew == DateTime.Parse(starts) && endnew == DateTime.Parse(ends))
                {
                    success = 0;
                }


            }

           
            global.startdateold.set(DateTime.Parse(starts));
            global.enddateold.set(DateTime.Parse(ends));
            
        }

        private void btn_adddiv(object sender, EventArgs e)
        {
            double alldiv = 0;
            double allbill = 0;
            double mpay = 0;

            double pdpay = 0;
           DateTime std = DateTime.Today;
            DateTime end = DateTime.Today;
            String mid = "";
            String mname = "";
            String emname = "";
            emname = global.emname.get();
            
           
          
            if (emname != null)
            {




                mname = global.mname.get();
                allbill = global.allpay.get();
                alldiv = global.paydiv.get();
                mpay = global.mpay.get();
                std = global.startdate.get();
                end = global.enddate.get();
                
                n++;
                ListViewItem showorder = new ListViewItem(n.ToString());
                showorder.SubItems.Add(mname);
                showorder.SubItems.Add(allbill.ToString());
                showorder.SubItems.Add(alldiv.ToString());
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

            
            
           
           
        }
        void selectMname()
        {
            String mid;
            mid = txt_memid.Text;
            
            String mname = "";
            String mpay = "";
            double mp = 0;
            

            String dbins = "SELECT * FROM member WHERE Mid = @mid";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@mid", mid);
            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                mname = reader.GetString("Mname");
                mpay = reader.GetString("Mpay");

            }
            global.mname.set(mname);
           
            mp = double.Parse(mpay);
            global.mpay.set(mp);
            connectdb.Close();







        }

        private void save_click(object sender, EventArgs e)
        {
            DateTime enddateold = global.enddateold.get();
            DateTime enddatenew = global.enddate.get();

            if (notbetween(enddatenew, enddateold))
           {
                insertdiv();
                updateincome();
                selectincome();
                MessageBox.Show("");
            }
            else
            {

                MessageBox.Show("ปันผลในวันที่"+global.startdate.get().ToString()+"ถึงวันที่"+ global.enddate.get().ToString()+"ถูกจ่ายให้สมาชิกรหัส"+txt_memid.Text+"ไปเรียบร้อยเเล้ว");
            }

            String income = "";
            double incomes = 0;
            double total = 0;
            String pay = "";
            pay = txt_payexpen.Text;
            income = global.oldvaluein.get();
            txt_allpay.Text = txt_payexpen.Text;
            incomes = double.Parse(income);
            txt_allre.Text = incomes.ToString();


            MessageBox.Show("จำนวนเงินที่จ่าย " + pay+"บาท"+ "   "+"จำนวนเงินที่คงเหลือ " + income + "บาท");
           
            divname.Text = string.Empty;
            txt_payexpen.Text = string.Empty;
            txt_allbuy.Text = string.Empty;
            txt_bill.Text = string.Empty;
            txt_memid.Text = string.Empty;
            txt_memname.Text = string.Empty;
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
        void insertdiv()
        {

            int pdcode = 0;
            
            String emid = "";
            DateTime std = DateTime.Today;
            DateTime end = DateTime.Today;
            std = global.startdate.get();
            end = global.enddate.get();
            double pdpay = 0;
            double pdbill = 0;
            String mid = "";
           

            int n = listdiv.Items.Count;
            ListViewItem item = new ListViewItem();
            int count = 0;
            DateTime thisday = DateTime.Today;
            String nowday = thisday.ToString("d");

           
            String dbins = "INSERT INTO paydivmem(PDMcode,PDMdate,PDMstart,PDMend,PDMbill,PDMpay,EMid,Mid)VALUES(@pdcode,@nowday,@pdst,@pde,@pdbill,@pdpay,@emid,@mid)";
          
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            connectdb.Open();

            for (int i = 0; i < n; i++)
            {
                //(@pdcode,@nowday,@pdst,@pde,@pdbill,@pdpay

                item = listdiv.Items[i];

                count = i;
                emid = global.emid.get();
                mid = global.mid.get();
                pdbill = double.Parse(item.SubItems[2].Text);
                pdpay = double.Parse(item.SubItems[3].Text);
                //DateTime.ParseExact(item.SubItems[4].Text, "dd/MM/yyyy", null);
                std = global.startdate.get();
                end =global.enddate.get();



                //VALUES(@pdcode,@nowday,@pdst,@pde,@pdbill,@pdpay,@emid,@mid)


                ins.Parameters.AddWithValue("@pdcode", pdcodeempty);
                ins.Parameters.AddWithValue("@nowday", thisday);
                ins.Parameters.AddWithValue("@pdst", std);
                ins.Parameters.AddWithValue("@pde", end);
                ins.Parameters.AddWithValue("@pdbill", pdbill);
                ins.Parameters.AddWithValue("@pdpay",pdpay);
                ins.Parameters.AddWithValue("@emid", emid);
                ins.Parameters.AddWithValue("@mid", txt_memid.Text);

                

                ins.ExecuteNonQuery();




            }
            MessageBox.Show("Successfully");
            global.paydivcode.set(txt_bill.Text);

            connectdb.Close();




        }

        private void listpaydivm_doubleclick(object sender, EventArgs e)
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

        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {
            
           global.startdate.set(DateTime.Parse(datestart.Text));
        }

        private void dateTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            global.enddate.set(DateTime.Parse(dateend.Text));

            
        }

        private void txt_memid_TextChanged(object sender, EventArgs e)
        {
            String midnew = "";
            midnew = txt_memid.Text;
            global.mid.set(midnew);
            int ch = 0;
            try
            {

                selectMname();
                String mname = global.mname.get();
                txt_memname.Text = mname;
                ch = 1;
            }

            catch
            {
                if (ch == 1) {
                    MessageBox.Show("รหัสสมาชิกไม่ถูกต้อง กรุณากรอกใหม่");
                }
               
            }

           
          
        }

        private void txt_payexpen_TextChanged(object sender, EventArgs e)
        {
            double paydiv = 0;
            double mpay = 0;
            double allpay = 0;
            mpay = global.mpay.get();
            allpay = global.allpay.get();
            paydiv = mpay * allpay;
            global.paydiv.set(paydiv);


        }

        

        private void txtallbuy_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_memname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_searchclick(object sender, EventArgs e)
        {
            if(success == 1) {
                selectbill();
                double rediv = 0;
                double mpay = 0;
                double allpay = 0;
                mpay = global.mpay.get();
                allpay = global.allpay.get();
                txt_allbuy.Text = allpay.ToString();
                rediv = allpay * mpay;
                txt_payexpen.Text = rediv.ToString();
            }

            
            
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

            catch { MessageBox.Show("Error"); }
          






        }
        void selectincome()
        {
           
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
        public static bool notbetween(DateTime input,DateTime max)
        {

            return (input >= max);


        }

        private void txt_bill_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Mainem nextForm = new Mainem();
            nextForm.Show();
            this.Hide();
        }

        private void txt_allpay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_allre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

