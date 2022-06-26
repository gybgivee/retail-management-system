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
    public partial class mainsyn2 : Form
    {
        public mainsyn2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            databill nextForm = new databill();
            nextForm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product nextForm = new product();
            nextForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datasup nextForm = new datasup();
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
