using CalculatorWithoutMEF;

namespace CalculatorLibWithoutMEF
{
    public class AddOperation : IOperation
    {
        public int Perform(int a, int b)
        {
            return a + b;
        }
    }
}
