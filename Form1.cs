using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Basic_Cal : Form
    {
        double n1,n2,go;
        String op;
        public Basic_Cal()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.txt_display.Text = txt_display.Text + "3";

        }

        private void sum_Click(object sender, EventArgs e)
        {
            n1= Convert.ToDouble(this.txt_display.Text);
            op = "+";
            this.txt_display.Clear();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(this.txt_display.Text);
            op = "-";
            this.txt_display.Clear();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(this.txt_display.Text);
            op = "*";
            this.txt_display.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(this.txt_display.Text);
            op = "/";
            this.txt_display.Clear();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (this.txt_display.Text != "")
            { 
                this.txt_display.Text = this.txt_display.Text + "00"; 
            }
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.txt_display.Text = this.txt_display.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.txt_display.Text = this.txt_display.Text + "2";

        }

        private void four_Click(object sender, EventArgs e)
        {
            this.txt_display.Text = this.txt_display.Text + "4";

        }

        private void five_Click(object sender, EventArgs e)
        {
            this.txt_display.Text = this.txt_display.Text + "5";

        }

        private void six_Click(object sender, EventArgs e)
        {
            this.txt_display.Text = this.txt_display.Text + "6";

        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.txt_display.Text = this.txt_display.Text + "7";

        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.txt_display.Text = this.txt_display.Text + "8";

        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.txt_display.Text = this.txt_display.Text + "9";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_display.Clear();
        }

        private void go_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToInt32(txt_display.Text);
            if (op == "+")
            {
                go = n1 + n2;
            }
            else if(op == "-")
            {
                go = n1 - n2;
            }
            else if (op == "*")
            {
                go = n1 * n2;
            }
            else if (op == "/")
            {
                go = n1 / n2;
            }
            this.txt_display.Text = go.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
