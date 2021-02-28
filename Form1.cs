using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculate1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(numOne.Text);
            decimal b=Convert.ToDecimal(numTwo.Text);

            // I call upon my method 
            //execute my command
            Calculate(a,b);
        }

        private void Calculate(decimal a, decimal b)
        {
            if (txtOperand.Text == " + ")
            {
                txtResultOne.Text = (a + b).ToString();
            }

            else if (txtOperand.Text== "-")
            {
                txtResultOne.Text = (a - b).ToString();
            }

            else if (txtOperand.Text == "*")
            {
                txtResultOne.Text = (a * b).ToString();
            }

            else if (txtOperand.Text == "/")
            {
                txtResultOne.Text = (a / b).ToString();
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            numOne.Clear();
            numTwo.Clear();
            txtOperand.Clear();
            txtResultOne.Clear();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }


        }

         static void tb_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == (char)13)
             {
                 txtCalculate_Click(sender, e);
             }
         }

    }



}

