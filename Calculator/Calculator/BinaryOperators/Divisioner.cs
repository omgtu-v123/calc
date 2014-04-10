namespace Calculator.BinaryOperators
{
    public class Divisioner : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return (first / second);
        }
    }
}
