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
    public partial class supdetail : Form
    {
        public supdetail()
        {
            InitializeComponent();
        }

        private void supdetail_Load(object sender, EventArgs e)
        {
            String supcode = "";
            supcode=suppro.globaluse.get();

            

            MySqlConnection connectdb = new MySqlConnection(Connect.conins);
             String dbins = "SELECT * FROM supdetail WHERE supdetail.SUPcode=@supcode";
             MySqlDataAdapter dataset = new MySqlDataAdapter(dbins, connectdb);
            dataset.SelectCommand.Parameters.AddWithValue("@supcode",supcode);
           
            DataTable datatable = new DataTable();
             dataset.Fill(datatable);
            datasupGrid.DataSource = datatable;
        }

        private void datasupgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
