namespace Calculator.BinaryOperators
{
    public class Multiplicator : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return (first * second);
        }
    }
}
