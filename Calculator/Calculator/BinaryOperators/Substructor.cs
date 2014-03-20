namespace Calculator.BinaryOperators
{
    public class Substructor:IBinaryOperation
    {
        public string Calculate (double first, double second)
        {
            return (first - second).ToString();
        }
    }
}
