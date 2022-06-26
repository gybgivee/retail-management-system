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
    public partial class Mainsyn : System.Windows.Forms.Form
    {
        public Mainsyn()
        {
            InitializeComponent();
        }

        private void btn_dataend(object sender, EventArgs e)
        {

            mainsyn1 nextForm = new mainsyn1();
            nextForm.Show();
            this.Hide();
        }

        private void btn_datap(object sender, EventArgs e)
        {
           mainsyn2 nextForm = new mainsyn2();
            nextForm.Show();
            this.Hide();
        }

        private void btn_div(object sender, EventArgs e)
        {
           divem nextForm = new divem();
            nextForm.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out");
            Application.Exit();
        }
    }
}
