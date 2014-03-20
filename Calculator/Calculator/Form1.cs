using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(FirstArgument.Text) + Convert.ToDouble(SecondArgument.Text);
            ResultField.Text = Convert.ToString(result);
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(FirstArgument.Text) - Convert.ToDouble(SecondArgument.Text);
            ResultField.Text = Convert.ToString(result);
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(FirstArgument.Text) * Convert.ToDouble(SecondArgument.Text);
            ResultField.Text = Convert.ToString(result);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(FirstArgument.Text) / Convert.ToDouble(SecondArgument.Text);
            ResultField.Text = Convert.ToString(result);
        }
    }
}
