using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + '.';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.label2.Text = "+";
            if(this.label1.Text != "")
            {
                this.label3.Text = this.label1.Text; 
            }
            this.label1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.label2.Text = "-";
            if (this.label1.Text != "")
            {
                this.label3.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.label2.Text = "*";
            if (this.label1.Text != "")
            {
                this.label3.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.label2.Text = "/";
            if (this.label1.Text != "")
            {
                this.label3.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double aa;
            double bb;
            double cc;
            double.TryParse(this.label1.Text, out aa);
            double.TryParse(this.label3.Text, out bb);
            cc = 0;
            if(this.label2.Text == "+")
            {
                cc = aa + bb;
            }
            if (this.label2.Text == "-")
            {
                cc = bb - aa;
            }
            if (this.label2.Text == "*")
            {
                cc = aa * bb;
            }
            if (this.label2.Text == "/")
            {
                cc = bb / aa;
            }
            this.label3.Text = cc.ToString();
            this.label1.Text = "";
            this.label2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            this.label2.Text = "";
            this.label3.Text = "";
        }
    }
}
