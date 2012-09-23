using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 MyForm = new Form10();

            MyForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "Correct!!";
                button1.Enabled = false;
                Scores.scorevalue++;
            }

       
            else
            {
                radioButton2.Checked = true;
                radioButton4.Checked = true;
                radioButton3.Checked = true;
                textBox1.Text = "WRONG!!";
                button1.Enabled = false;
            }
       
            while (Scores.scorevalue == 0)
            {
                Scores.scorevalue2 = +1;
            }

            }
        }
    }

