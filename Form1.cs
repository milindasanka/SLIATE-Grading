using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biffox_Sliate_Grading_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();//close button form 1
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            hndit f2 = new hndit();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frda f5 = new frda();
            f5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frdm f4 = new Frdm();
            f4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frthm f5 = new Frthm();
            f5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frHnden f6 = new frHnden();
            f6.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();//close button
        }
    }
}