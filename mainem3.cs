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
    public partial class mainem3 : Form
    {
        public mainem3()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            regismem nextForm = new regismem();
            nextForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adddiv nextForm = new adddiv();
            nextForm.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            subdiv nextForm = new subdiv();
            nextForm.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataem nextForm = new dataem();
            nextForm.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Mainem nextForm = new Mainem();
            nextForm.Show();
            this.Hide();
        }
    }
}
