using System;
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
    public partial class Mainem : Form
    {
        public Mainem()
        {
            InitializeComponent();
        }

        private void btn_buy(object sender, EventArgs e)
        {
            mainem1 nextForm = new mainem1();
            nextForm.Show();
            this.Hide();
        }

        private void btn_sale(object sender, EventArgs e)
        {
            sale nextForm = new sale();
            nextForm.Show();
            this.Hide();
        }

        private void btn_mem(object sender, EventArgs e)
        {
            mainem3 nextForm = new mainem3();
            nextForm.Show();
            this.Hide();
        }

        private void btn_salf(object sender, EventArgs e)
        {
            mainem4 nextForm = new mainem4();
            nextForm.Show();
            this.Hide();

        }

       

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out");
            Application.Exit();
        }
    }
}
