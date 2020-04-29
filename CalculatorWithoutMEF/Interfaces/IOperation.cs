using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://dailydotnettips.com/working-with-aggregatecatalog-in-mef/
/// https://docs.microsoft.com/en-us/dotnet/framework/mef/
/// </summary>
namespace Interfaces
{
    public interface IOperation
    {
        int Perform(int a, int b);
    }
}
