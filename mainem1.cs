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
    public partial class mainem1 : Form
    {
        public mainem1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addsup nextForm = new addsup();
            nextForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addproduct nextForm = new addproduct();
            nextForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buy nextForm = new Buy();
            nextForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recieve nextForm = new Recieve();
            nextForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expen nextForm = new expen();
            nextForm.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Mainem nextForm = new Mainem();
            nextForm.Show();
            this.Hide();
        }
    }
}
