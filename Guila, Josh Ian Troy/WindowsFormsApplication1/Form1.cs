using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_conv_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            double bmi;

            weight = double.Parse(textBox1.Text);
           height = double.Parse(textBox2.Text);
           bmi = ( weight) / (height * height);

            if(bmi<18.5)
            {
                textBox3.Text = bmi + "   Underweight";
            }

            else if (bmi > 18.5 && bmi < 24.9)
            {
                textBox3.Text = bmi + "   Normal";
            }

            else if (bmi > 25 && bmi < 29.9)
            {
                textBox3.Text = bmi + "   OverWeight";
            }

            else if (bmi > 30)
            {
                textBox3.Text = bmi + "   Obese";
            }
            

        }
    }
}
