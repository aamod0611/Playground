using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string operation = "";
        private string firstNumber = "";
        int operationid;


       

        private void btnOperation_Add_Click(object sender, EventArgs e)
        {
            firstNumber =result.Text;
            result.Text = "+";
            operationid = 1;
        }
        private void opration_sub1(object sender, EventArgs e)
        {
            firstNumber = result.Text;
            result.Text = "-";
            operationid = 2;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            firstNumber = Convert.ToString(result.Text);
            result.Text = "*";
            operation = "*";
            operationid = 3;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            firstNumber = result.Text;
            result.Text = "/";
            operation = "/";
            operationid = 4;
        }
        private void btnOperation_Equals_Click(object sender, EventArgs e)
        {
            switch(operationid)
            {
                case 1:
                    {
                        result.Text = Convert.ToString(Convert.ToDouble(result.Text) + (Convert.ToDouble(firstNumber)));
                        break;
                    }
                case 2:
                    {
                        result.Text = Convert.ToString((Convert.ToDouble(firstNumber)) - (Convert.ToDouble(result.Text)) );
                        break;
                    }
                case 3:
                    {
                        result.Text = Convert.ToString(Convert.ToDouble(result.Text) * (Convert.ToDouble(firstNumber)));
                        break;
                    }
                case 4:
                    {
                        result.Text = Convert.ToString((Convert.ToDouble(firstNumber)) / (Convert.ToDouble(result.Text)));
                        break;
                    }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            firstNumber = "";
            operation = "";
        }
        private void btnNum_1_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if(result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text += "1";

        }

        private void btnNum_2_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text += "2";

        }

        private void btnNum_3_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text = result.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text = result.Text + "4";
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text = result.Text + "5";

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text = result.Text + "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text = result.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text = result.Text + "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text = result.Text + "9";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text = result.Text + "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_backspace(object sender, EventArgs e)
        {
            if(result.Text != "0")
            {
                int back = result.TextLength - 1;
                string text = result.Text;
                result.Clear();
                for(int i=0;i<back;i++)
                {
                    result.Text = result.Text + text[i];
                }
            }
        }

        private void btn_dot(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "";
            }
            else if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
            result.Text = result.Text + ".";
        }
    }
}
