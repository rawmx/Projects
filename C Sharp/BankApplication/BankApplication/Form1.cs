﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bankclass myaccount = new bankclass();

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            button3.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double begBal;
            

            if (double.TryParse(textBox3.Text, out begBal))
            {
                myaccount.Balance = begBal;
                textBox6.Text = begBal.ToString("c");
            }
            else
            {
                MessageBox.Show("Balance is not a number");
            }

            

            string Str = textBox2.Text.Trim();
            int Num;
            bool isNum = int.TryParse(Str, out Num);
            if (isNum)
            {
                panel1.Visible = true;
                panel2.Visible = true;
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox6.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Enter a numerical account number");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;

            double dep = 0;
            double with = 0;

            if (double.TryParse(textBox4.Text, out dep))
            {
                double balance = myaccount.depositamount(dep);
                textBox7.Text = balance.ToString("c");
            }
           else if (double.TryParse(textBox5.Text, out with))
            {
                double balance = myaccount.withdrawalamount(with);
                textBox7.Text = balance.ToString("c");
            }
            else
            {
                MessageBox.Show("please enter a valid number");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
