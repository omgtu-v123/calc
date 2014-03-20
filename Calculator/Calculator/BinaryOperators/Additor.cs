namespace Calculator.BinaryOperators
{
    public class Additor : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            return (first + second).ToString();
        }

    }
}
