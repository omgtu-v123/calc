namespace Calculator.BinaryOperators
{
    class Divisioner : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            return (first / second).ToString();
        }
    }
}
