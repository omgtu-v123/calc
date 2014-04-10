namespace Calculator.BinaryOperators
{
    public class Substructor:IBinaryOperation
    {
        public double Calculate (double first, double second)
        {
            return (first - second);
        }
    }
}
