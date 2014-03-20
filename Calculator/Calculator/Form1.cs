using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.BinaryOperators;

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
            Additor additor = new Additor();
            ResultField.Text = additor.Calculate(Convert.ToDouble(FirstArgument.Text), Convert.ToDouble(SecondArgument.Text));
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            Substructor substructor = new Substructor();
            ResultField.Text = substructor.Calculate(Convert.ToDouble(FirstArgument.Text), Convert.ToDouble(SecondArgument.Text));
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            Multiplicator multiplicator = new Multiplicator();
            ResultField.Text = multiplicator.Calculate(Convert.ToDouble(FirstArgument.Text), Convert.ToDouble(SecondArgument.Text));
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Divisioner divisioner = new Divisioner();
            ResultField.Text = divisioner.Calculate(Convert.ToDouble(FirstArgument.Text), Convert.ToDouble(SecondArgument.Text));
        }
    }
}
