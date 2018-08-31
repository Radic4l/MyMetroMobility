using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    public class Metro
    {
        private StationInfosPovider stationInfos;

        public Metro ()
        {
            stationInfos = new StationInfosPovider();
        }

        public Dictionary<string, StationInfos> getInfos()
        {
            return stationInfos.getInfos();
        }
    }
}
