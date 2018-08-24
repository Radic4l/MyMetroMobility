using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetroMobility
{
    internal interface IStationProvider
    {
        List<Station> ConvertJson();
        Dictionary<string, Station> ConvertToDict();
    }
}
