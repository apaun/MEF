using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithoutMEF
{
    public interface IOperation
    {
        int Perform(int a, int b);
    }
}
