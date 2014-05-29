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
using Calculator.SortingOperations;
using Calculator.UnaryOperators;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SortingCalculation(string calculatorName)
        {
            string[] stringArray = FirstArgument.Text.Split(' ');
            int[] intArray = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(stringArray[i]);
            }
            ISortingOperation calculator = SortingOperationsFactory.CreateCalculator(calculatorName);
            int[] result = calculator.SortingCalculate(intArray);
            string stringResult = string.Empty;
            for (int i = 0; i < result.Length; i++)
            {
                stringResult += result[i] + " ";
            }
            ResultField.Text = stringResult;
        }
        private void BinaryCalculation(string calculatorName)
        {
            try
            {
                IBinaryOperation calculator = BinaryOperationFactory.CreateCalculator(calculatorName);
                ResultField.Text = calculator.Calculate(Convert.ToDouble(FirstArgument.Text),
                    Convert.ToDouble(SecondArgument.Text)).ToString();
            }
            catch (Exception e)
            {
                ResultField.Text = e.Message;
            }
            
        }

        private void UnaryCalculation(string calculatorName)
        {
            try
            {
                IUnaryOperation calculator = UnaryOperationFactory.CreateCalculator(calculatorName);
                ResultField.Text = calculator.Calculate(Convert.ToDouble(FirstArgument.Text)).ToString();
            }
            catch (Exception e)
            {
                ResultField.Text = e.Message;
            }
          
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

        private void Sqrt_Click(object sender, EventArgs e)
        {
            BinaryCalculation("Pow");
        }

        private void Root_Click(object sender, EventArgs e)
        {
            BinaryCalculation("Root");
        }

        private void Logarithm_Click(object sender, EventArgs e)
        {
            BinaryCalculation("Logarithm");
        }

        private void Radius_Click(object sender, EventArgs e)
        {
            BinaryCalculation("Radius");
        }

        private void Sine_Click(object sender, EventArgs e)
        {
            UnaryCalculation("siner");
        }

        private void Cosine_Click(object sender, EventArgs e)
        {
            UnaryCalculation("cosiner");
        }

        private void Tangent_Click(object sender, EventArgs e)
        {
            UnaryCalculation("tangenter");
        }

        private void Cotangent_Click(object sender, EventArgs e)
        {
            UnaryCalculation("cotangenter");
        }

        private void Arcsin_Click(object sender, EventArgs e)
        {
            UnaryCalculation("Asiner");
        }

        private void Arccos_Click(object sender, EventArgs e)
        {
            UnaryCalculation("Acosiner");
        }

        private void Arctan_Click(object sender, EventArgs e)
        {
            UnaryCalculation("Atangenter");
        }

        private void Arcctg_Click(object sender, EventArgs e)
        {
            UnaryCalculation("Acotangenter");
        }

        private void Sqrt_Click_1(object sender, EventArgs e)
        {
            UnaryCalculation("Sqrt");
        }

        private void CubeSqrt_Click(object sender, EventArgs e)
        {
            UnaryCalculation("CubeSqrt");
        }

        private void NatLog_Click(object sender, EventArgs e)
        {
            UnaryCalculation("NatLog");
        }

        private void Exp_Click(object sender, EventArgs e)
        {
            UnaryCalculation("Exp");
        }

        private void DownSorting_Click(object sender, EventArgs e)
        {
            SortingCalculation("Chose");
        }

        private void UpSorting_Click(object sender, EventArgs e)
        {
            SortingCalculation("Bubble");
        }
    }

}
