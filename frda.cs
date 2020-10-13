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
    public partial class frda : Form
    {
        public frda()
        {
            InitializeComponent();
        }

        private void frda_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            calc f4 = new calc();
            f4.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double assignment, final, marks, assignment1, final1;
            assignment = Double.Parse(textBox1.Text);
            final = Double.Parse(textBox2.Text);
            assignment1 = (assignment * 30) / 100;
            final1 = (final * 70) / 100;
            marks = (assignment1 + final1);
            label7.Text = marks.ToString();
            label7.Visible = true;

            if (assignment < 30)
                label10.Text = "I(SE)";
            else if (final < 30)
                label10.Text = "I(SE)";
            else if (marks < 40)
                label10.Text = "C-";
            else if (marks < 45)
                label10.Text = "C";
            else if (marks < 50)
                label10.Text = "C+";
            else if (marks < 54)
                label10.Text = "B-";
            else if (marks < 60)
                label10.Text = "B";
            else if (marks < 65)
                label10.Text = "B+";
            else if (marks < 70)
                label10.Text = "A-";
            else if (marks < 85)
                label10.Text = "A";
            else label10.Text = "A+";
        }
    }
    }

