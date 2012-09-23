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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Ready?", "Exam", MessageBoxButtons.OK);

            Form2 MyForm = new Form2();
          
            MyForm.Show();

            this.Hide();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

    

