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
    public partial class suppro : Form
    {
        //this.dataGridView1.Rows.Add("1", "XX");
        public suppro()
        {
            InitializeComponent();
        }
        public static class globaluse
        {

            public static String typename = ""; // Unmodifiable

            public static void set(String newtype)
            {
                typename = newtype;
            }

            public static String get()
            {

                return typename;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void suppro_Load(object sender, EventArgs e)
        {
            datasupGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            MySqlConnection connectdb = new MySqlConnection(Connect.conins);
            String dbins = "SELECT * FROM supplier";
            MySqlDataAdapter dataset = new MySqlDataAdapter(dbins,connectdb);
            DataTable datatable = new DataTable();
            dataset.Fill(datatable);

            datasupGrid.DataSource = datatable;
            datasupGrid.Columns[0].HeaderText = "รหัสการจ่าย";
            datasupGrid.Columns[1].HeaderText = "ชื่อตัวเเทนจำหน่าย";
            datasupGrid.Columns[2].HeaderText = "ข้อมูลติดต่อ";


        }

        private void supgrid_doubleclick(object sender, EventArgs e)
        {

            globaluse.set(datasupGrid.SelectedRows[0].Cells[0].Value.ToString());

            supdetail nextForm = new supdetail();
            nextForm.Show();
            
        }

        private void datasupGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
