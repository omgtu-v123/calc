namespace Calculator.BinaryOperators
{
    public class Divisioner : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            return (first / second).ToString();
        }
    }
}
