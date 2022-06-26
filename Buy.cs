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
    public partial class Buy : Form
    {
        String orcodeemp = "";
        double allpay = 0;
        int n = 0;
        int allamount = 0;
        public Buy()
        {
            InitializeComponent();

            this.Activate();




        }
       
        private void Buy_Load(object sender, EventArgs e)
        {
            DateTime thisday = DateTime.Today;
            String nowday = thisday.ToString("d");
            
            txt_date.Text = nowday;
            global.dateday.set(nowday);
            selectemname();
            selectorcode();
            selectnametp();
            

            
            


        }

        void selectorcode()
        {
            String or = "";
            int orint = 0;

            String dbins = "SELECT ORcode FROM orders";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);


            connectdb.Open();

            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {

                or = reader.GetString("ORcode");


            }
            orint = int.Parse(or) + 1;
            orcode.Items.Add(orint);




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
            //
            String dbins = "SELECT DISTINCT SUPname FROM supplier,supdetail,product,typepro WHERE supplier.SUPcode = (SELECT SUPcode from supdetail WHERE supdetail.TPcode = (SELECT TPcode FROM typepro WHERE TPname = @tpname) AND supdetail.pcode = (SELECT Pcode FROM product WHERE product.Pname = @pname)) AND supdetail.TPcode = (SELECT TPcode FROM typepro WHERE TPname = @tpname) AND supdetail.pcode = (SELECT Pcode FROM product WHERE product.Pname = @pname) GROUP BY supdetail.pcode,supdetail.TPcode,supdetail.supcode "; 
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
            pname = global.pname.get();
            String dbins = "SELECT Pcode FROM product WHERE pname = @pname";
            MySqlConnection connectdb = new MySqlConnection(Connect.conins);

            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
            ins.Parameters.AddWithValue("@pname", pname);

            connectdb.Open();
            MySqlDataReader reader = ins.ExecuteReader();

            while (reader.Read())
            {
                pcode = reader.GetString("Pcode");


            }
            global.pcode.set(pcode);
            connectdb.Close();

        }
        void insertorder()
        {

            try
            {
                int orcode = 0;
                String emid = "";
                String nowday = "";
                int allorder = 0;
                double pay = 0;
                int orc = 0;
                orcode = global.orcodeinc.get();
                orc = orcode;
                DateTime thisday = DateTime.Today;
                String nowday1 = thisday.ToString("d");

                allorder = listbuy.Items.Count;
                emid = global.emid.get();
                pay = global.allpay.get();

                String dbins = "INSERT INTO orders(ORcode,ORdate,ORorder,ORpay,EMid)VALUES(@orcode,@nowday,@allorder,@pay,@emid)";

                MySqlConnection connectdb = new MySqlConnection(Connect.conins);

                MySqlCommand ins = new MySqlCommand(dbins, connectdb);

                ins.Parameters.AddWithValue("@orcode", orcodeemp);
                ins.Parameters.AddWithValue("@nowday", thisday);
                ins.Parameters.AddWithValue("@allorder", allorder);
                ins.Parameters.AddWithValue("@pay", pay);
                ins.Parameters.AddWithValue("@emid", emid);


                connectdb.Open();
                ins.ExecuteNonQuery();
                
                connectdb.Close();
            }
            catch
            {
               
            }







        }

        void insertordetail()
        {
            
            int order = 0;
            int count = 0;
            double cost = 0;
            String supcost = "";
            String pname = "";
            String tpname = "";
            String supname = "";
            String orcode = "";
            int amount = 0;
            int orc = global.orcodeinc.get();
            String oramount = "";
            String supcode ="", pcode = "", tpcode = "";
            int spc = 0,pc=0,tpc=0;
            DateTime thisday = DateTime.Today;
            String nowday1 = thisday.ToString("d");

            String ordate = "";



            ListViewItem item = new ListViewItem();
            int n = listbuy.Items.Count;
           
            String dbins = "INSERT INTO ordetail(ORcode,ORdate,SUPcode,TPcode,Pcode,ORDamount)VALUES(@orc,@ordate,@supcode,@tpcode,@pcode,@ora)";
           MySqlConnection connectdb = new MySqlConnection(Connect.conins);
            //  String nowday = ;
          
            MySqlCommand ins = new MySqlCommand(dbins, connectdb);
           
          
           
            for (int i = 0; i < n ; i++)
            {
                dbins = "INSERT INTO ordetail(ORcode,ORdate,SUPcode,TPcode,Pcode,ORDamount)VALUES(@orc,@ordate,@supcode,@tpcode,@pcode,@ora)";
                connectdb = new MySqlConnection(Connect.conins);
                
                ins = new MySqlCommand(dbins, connectdb);
                connectdb.Open();

                item =listbuy.Items[i];

                
                count = i;
                pname = item.SubItems[1].Text;
                global.pname.set(pname);
               
                oramount = item.SubItems[2].Text;
               
                amount = int.Parse(oramount);
                supname = item.SubItems[5].Text;
                global.supname.set(supname);
                
                tpname = item.SubItems[6].Text;
                global.tpname.set(tpname);
                
                supcode = global.supcode.get();
                spc = int.Parse(supcode);

               
                pcode = global.pcode.get();
                
                
                tpcode = global.tpcode.get();


                
                ins.Parameters.AddWithValue("@orc", global.orcode.get());
                ins.Parameters.AddWithValue("@ordate", thisday);
                ins.Parameters.AddWithValue("@supcode", supcode);
                ins.Parameters.AddWithValue("@tpcode", tpcode);
                ins.Parameters.AddWithValue("@pcode", pcode);
                ins.Parameters.AddWithValue("@ora", oramount);



                ins.ExecuteNonQuery();


                connectdb.Close();
            }
          

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
       
        private void btn_addpro(object sender, EventArgs e)
        {
            String emname = global.emname.get();
            if (emname != null)
            {
                String sup = "";
                double supcost = 0;
                double supall = 0;
                int amount=0;
                amount = int.Parse(txt_amount.Text);
                sup = global.supcost.get();
                supcost = double.Parse(sup);
                allamount = amount + allamount;
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
                listbuy.Items.Add(showorder);
                /*nametype.Text = String.Empty;
                namepro.Text = String.Empty;
                amountpro.Text = String.Empty;
                */
                global.allpay.set(allpay);
                txt_allam.Text = allamount.ToString();
                txt_allpay.Text = allpay.ToString();
            }
            else if (emname== null) {
                MessageBox.Show("Please add the employee name");

            }
            tpname.Text = string.Empty;
            
            namepro.Text = string.Empty;
            namepro.Items.Clear();
            suppname.Text = string.Empty;
            suppname.Items.Clear();
            txt_amount.Text = String.Empty;
        }

        private void btn_savepro(object sender, EventArgs e)
        {
           
                insertorder();
                int or = 0;
                or = int.Parse(global.orcode.get());
                global.orcodeinc.setinc(or);
                insertordetail();
                MessageBox.Show("Added Order Successfully");
            
         
            

        }
        

       
        private void listbuy_DoubleClick(object sender, EventArgs e)
        {

            
            int n = listbuy.Items.Count;
            for (int i = 0; i < n; i++)
            {
                
                if (listbuy.Items[i].Selected)
                {
                    listbuy.Items[i].BackColor = Color.Red;
                    listbuy.Items[i].Remove();
     
                }

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      
        private void txt_emname_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        
        private void supname_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void pname_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.pname.set(namepro.SelectedItem.ToString());
            
            selectsupname();
            selectPcode();

        }

       

        private void orcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.orcode.set(orcode.SelectedItem.ToString());
            

        }

        private void txt_date_TextChanged(object sender, EventArgs e)
        {
            txt_date.ReadOnly = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainem1 nextForm = new mainem1();
            nextForm.Show();
            this.Hide();
        }

        
    }
}
