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
    public partial class mainsyn1 : Form
    {
        public mainsyn1()
        {
            InitializeComponent();
        }

        private void btn_mem(object sender, EventArgs e)
        {
           datamemse nextForm = new datamemse();
            nextForm.Show();
            this.Hide();
        }

        private void btn_em(object sender, EventArgs e)
        {
            dataem nextForm = new dataem();
            nextForm.Show();
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Mainsyn nextForm = new Mainsyn();
            nextForm.Show();
            this.Hide();
        }
    }
}
