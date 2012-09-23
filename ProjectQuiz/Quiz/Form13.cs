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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANK YOU FOR TAKING THE EXAM!!", "Exam", MessageBoxButtons.OK); 
            Close();
        }


       

        private void button2_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt16(Scores.scorevalue);
            textBox2.Text = score.ToString();
        }

       
      
       
    }
}
