using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
             
            string name = textBox1.Text;

            double english = Convert.ToDouble(textBox2.Text);
            double math = Convert.ToDouble(textBox5.Text);
            double science = Convert.ToDouble(textBox3.Text);
            double filipino = Convert.ToDouble(textBox6.Text);
            double history = Convert.ToDouble(textBox4.Text);
            
            double total = english + math + science + filipino + history;
            double average = total / 5;

            label8.Text = (average >= 75.00) ? "The student passed." : "The student failed.";
            label9.Text = "The general average of " + name + " is " + average + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
