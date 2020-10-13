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
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();//claer text box
            textBox1.Focus();//focues text box
            count = 2;//count switch case
            label1.Text = num.ToString() + "-";//display oparate
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();//claer text box
            textBox1.Focus();//focues text box
            count = 3;//count switch case
            label1.Text = num.ToString() + "*";//display oparate
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();//claer text box
            textBox1.Focus();//focues text box
            count = 4;//count switch case
            label1.Text = num.ToString() + "/";//display oparate
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();//claer text box
            textBox1.Focus();//focues text box
            count = 1;//count switch case
            label1.Text = num.ToString() + "+";//display oparate
        }

        private void button15_Click(object sender, EventArgs e)
        {
            complete();
            label1.Text = "";
        }

        public void complete()
        {
            switch (count)//set oparators
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;

            }
        }
    }
}
