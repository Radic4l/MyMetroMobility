using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    internal interface ILinesProvider
    {
        List<Lines> ConvertLinesJson();
        Dictionary<string, Lines> ConvertLinesToDict();
    }
}
