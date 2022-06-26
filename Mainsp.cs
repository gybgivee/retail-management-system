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
    public partial class Mainsp : Form
    {
        public Mainsp()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainsp1 nextForm = new mainsp1();
            nextForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainsyn1 nextForm = new mainsyn1();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainsyn2 nextForm = new mainsyn2();
            nextForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paydivsyn nextForm = new paydivsyn();
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
