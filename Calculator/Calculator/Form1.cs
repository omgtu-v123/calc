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

        private void BinaryCalculation(string calculatorName)
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateCalculator(calculatorName);
            ResultField.Text = calculator.Calculate(Convert.ToDouble(FirstArgument.Text), Convert.ToDouble(SecondArgument.Text));
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            BinaryCalculation("Additor");
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            BinaryCalculation("Substractor");
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            BinaryCalculation("Multiplicator");
        }

        private void Division_Click(object sender, EventArgs e)
        {
            BinaryCalculation("Divisioner");
        }
    }
}
