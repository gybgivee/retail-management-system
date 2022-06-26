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
    public partial class subdiv : Form
    {
        int allamount = 0;
        int amount = 0;
        double allpay = 0;
        int n = 0;
        public subdiv()
        {
            InitializeComponent();
        }
        private void subdiv_Load(object sender, EventArgs e)
        {
            DateTime thisday = DateTime.Today;
            String nowday = thisday.ToString("d");

            txt_date.Text = nowday;
            global.dateday.set(nowday);
            txt_date.ReadOnly = true;
            selectemname();
            selectsubdivcode();
        }
        void selectsubdivcode()
        {

            String subdiv = "";
            String sdcode = "";
            int sdint = 0;
            int sdc = 0;


            String dbins = "SELECT * FROM subdiv";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {

                sdcode = reader.GetString("SDcode");


            }
            sdc = int.Parse(sdcode);
            global.sdcode.setinc(sdc);

            sdint =  sdc + 1;
            
            txt_bill.Text = sdint.ToString();
            txt_bill.ReadOnly = true;
            sdint = int.Parse(sdcode);
           
            connectdb.Close();


        }
        void selectMname()
        {
            String mid="";
            String mamount="";
            String mvalue = "";
            int mc = 0;
            int mv = 0;
            mid = global.mid.get();
            global.mid.set(mid);
            String mname = "";

            String dbins = "SELECT * FROM member WHERE Mid = @mid";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@mid", mid);
            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                mname = reader.GetString("Mname");
                mamount = reader.GetString("MshAmount");
                mvalue = reader.GetString("MshValue");
            }
            txt_memname.Text = mname;
            mc = int.Parse(mamount);
            global.mname.set(mname);
            global.mshamount.set(mc);
            global.mshvalue.set(mv);
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

        private void txt_memname_TextChanged(object sender, EventArgs e)
        {
            txt_memname.ReadOnly = true;
        }

        private void btn_savesubdiv(object sender, EventArgs e)
        {
            
                global.sdcode.setinc(global.sdcode.get() + 1);
                int amountold = 0;
                int success = 1;
                int amountnew = 0;
                amountnew = int.Parse(txt_amount.Text);
                amountold = global.mshamount.get();

                if (amountnew > amountold)
                {

                    MessageBox.Show("จำนวนหุ้นไม่เพียงพอ  ");
                    MessageBox.Show("เหลือหุ้นจำนวน" + amountold.ToString() + "หุ้น");


                    success = 0;
                    txt_amount.Text = String.Empty;

                    txt_value.Text = string.Empty;
                    priceshare.Text = string.Empty;
                   

                }
                if (success == 1)
                {

                    insertsubdiv();
                    updatemshsub();
                    selectmemcheck();
                MessageBox.Show("บันทึกการถอนหุ้นเรียบร้อยเเล้ว");
            }
                
            
           
                MessageBox.Show("บันทึกการถอนหุ้นไม่สำเร็จ กรุณาตรวจสอบจำนวนหุ้นอีกครั้ง");
            

        }
        void insertsubdiv()
        {

            int sdcode = 0;
            String emid = "";
            String mid = "";
           int amountnew = 0;
            int  amountold = 0;
            amountold = global.mshamount.get();
            String sdvalue = "";
            int valuenew = int.Parse(txt_value.Text);
            int valueold = 0;
            int valuetotal = 0;
            valueold = global.mshvalue.get();
            valuetotal = valueold - valuenew;


            DateTime thisday = DateTime.Today;
            
            sdcode = global.sdcode.get();
           
            
            emid = global.emid.get();
            mid = global.mid.get();
            amountnew = int.Parse(txt_amount.Text);
            sdvalue= txt_value.Text;
           

            String dbins = "INSERT INTO subdiv(SDcode,SDdate,SDamount,SDvalue,Mid,EMid)VALUES(@sdcode,@nowday,@sdamount,@sdvalue,@mid,@emid)";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);

            ins.Parameters.AddWithValue("@sdcode", sdcode);
            ins.Parameters.AddWithValue("@nowday", thisday);
            ins.Parameters.AddWithValue("@sdamount",amountnew );
            ins.Parameters.AddWithValue("@sdvalue", valuenew);
            ins.Parameters.AddWithValue("@mid", mid);
            ins.Parameters.AddWithValue("@emid", emid);

            connectdb.Open();
            ins.ExecuteNonQuery();
            //MessageBox.Show("Successfully");
            connectdb.Close();

            //MessageBox.Show("false");








        }

        private void emnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.emname.set(emnames.SelectedItem.ToString());
            selectemid();
            emnames.Enabled = false;
        }

        private void txt_memid_TextChanged(object sender, EventArgs e)
        {
            global.mid.set(txt_memid.Text);
            selectMname();
            txt_memid.ReadOnly = true;


        }
        void updatemshsub()
        {
            int amountnew = 0;
            int amountold = 0;
            int amounttotal = 0;
            amountold = global.mshamount.get();
            amountnew = int.Parse(txt_amount.Text);
            amounttotal = amountold - amountnew;
            String value = "";
            String mid = "";
            int valuenew = int.Parse(txt_value.Text);
            int valueold = 0;
            int valuetotal = 0;
            valueold = global.mshvalue.get();
            valuetotal = valueold - valuenew;

            mid = global.mid.get();
            amountnew = int.Parse(txt_amount.Text);
            value = txt_value.Text;


            String dbins = "UPDATE member SET MshAmount = @amountnew ,MshValue = @value  WHERE Mid = @mid";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);
            //  String nowday = ;

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            connectdb.Open();

            ins.Parameters.AddWithValue("@amountnew", amountnew);
            ins.Parameters.AddWithValue("@value",valuetotal);
            ins.Parameters.AddWithValue("@mid", mid);




            ins.ExecuteNonQuery();




            connectdb.Close();
           



        }

        private void pricesh_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.mshprice.set(int.Parse(priceshare.SelectedItem.ToString()));
         
            int value = 0;
            String sdvalue = "";

            int price = 0;
            price = int.Parse(priceshare.SelectedItem.ToString());
            int amount = int.Parse(txt_amount.Text);

            value = price * amount;
            sdvalue = value.ToString();
            txt_value.Text = sdvalue;
        }

        private void txt_priceag_TextChanged(object sender, EventArgs e)
        {

            txt_priceag.ReadOnly = true;
        }

        private void txt_amnew_TextChanged(object sender, EventArgs e)
        {
            txt_priceag.Text = priceshare.SelectedItem.ToString();
            txt_amnew.ReadOnly = true;
        }
        void selectmemcheck()
        {

            String mid = "";
            mid = global.mid.get();
            String midn = "";
            String mnn = "";
            String mshn = "";
            String mshvn = "";
            int priceag = 0;
            String dbins = "SELECT * FROM member where Mid = @mid ";

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            ins.Parameters.AddWithValue("@mid", mid);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                
                mnn = reader.GetString("Mname");
                mshn = reader.GetString("MshAmount");
                mshvn = reader.GetString("MshValue");


            }
            priceag = int.Parse(mshvn) / int.Parse(mshn);
            txt_midnew.Text = mid;
            txt_mnnew.Text = mnn;
            txt_amnew.Text = mshn;
            txt_priceag.Text = priceag.ToString();
            txt_valuenew.Text = mshvn;


            connectdb.Close();



        }

        private void txt_midnew_TextChanged(object sender, EventArgs e)
        {
            txt_midnew.ReadOnly = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Mainem nextForm = new Mainem();
            nextForm.Show();
            this.Hide();
        }
        private void txt_mnnew_TextChanged(object sender, EventArgs e)
        {
            txt_mnnew.ReadOnly = true;
        }

        private void txt_valuenew_TextChanged(object sender, EventArgs e)
        {
            txt_valuenew.ReadOnly = true;
        }

       
    }
}
