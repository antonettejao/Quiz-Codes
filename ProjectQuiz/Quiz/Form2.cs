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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 MyForm = new Form3();

            MyForm.Show();

            this.Hide();

        }

       

      
    }
}
