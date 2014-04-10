namespace Calculator.BinaryOperators
{
    public class Additor : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return (first + second);
        }

    }
}
