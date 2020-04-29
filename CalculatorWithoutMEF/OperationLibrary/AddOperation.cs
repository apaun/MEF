using Interfaces;
using System.ComponentModel.Composition;

namespace OperationLibrary
{
    [Export(typeof(IOperation))]
    public class AddOperation : IOperation
    {
        public int Perform(int a, int b)
        {
            return a + b;
        }
    }
}
