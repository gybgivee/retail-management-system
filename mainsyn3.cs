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
    public partial class mainsyn3 : Form
    {
        public mainsyn3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            divmem nextForm = new divmem();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            divem nextForm = new divem();
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
