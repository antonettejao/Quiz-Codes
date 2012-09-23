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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 MyForm = new Form8();

            MyForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
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
                radioButton4.Checked = true;
                radioButton1.Checked = true;
                textBox1.Text = "WRONG!!";
                button1.Enabled = false;

            }
        }
    }
}
