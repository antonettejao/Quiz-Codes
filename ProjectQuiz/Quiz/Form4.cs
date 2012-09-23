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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 MyForm = new Form5();

            MyForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox1.Text = "Correct!!";
                button1.Enabled = false;
                Scores.scorevalue++;
            }

            else if (Scores.scorevalue == 0)
            {
                Scores.scorevalue2 = +1;
            }

            else
            {
                radioButton2.Checked = true;
                radioButton3.Checked = true;
                radioButton1.Checked = true;
                textBox1.Text = "WRONG!!";
                button1.Enabled = false;

            }
        }
    }
}
