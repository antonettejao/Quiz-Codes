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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("This is now your 2nd attempt. Good Luck", "Exam", MessageBoxButtons.OK);
            Form2 MyForm = new Form2();


            Scores.scorevalue = 0;


            MyForm.Show();

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you don't want to take the 2nd attempt?", "Exam", MessageBoxButtons.YesNo);
            Close();
        }

    
       

        private void button3_Click_1(object sender, EventArgs e)
        {
                                                                      
            int score = Convert.ToInt16(Scores.scorevalue);
            textBox1.Text = score.ToString();

            
        }
    }
  
}

