namespace Calculator.BinaryOperators
{
    public class Multiplicator : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            return (first * second).ToString();
        }
    }
}
