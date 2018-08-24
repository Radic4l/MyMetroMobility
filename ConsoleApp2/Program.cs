using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyMetroMobility
{
    class Program
    {
        static void Main(string[] args)
        {
            IStationProvider stationProvider = new StationProvider();
            List<Station> stations = stationProvider.ConvertJson();
            Dictionary<string, Station> myDict = stationProvider.ConvertToDict();





            foreach (Station Station in myDict.Values)
            {
                Console.WriteLine(Station.Name);
                foreach (string Line in Station.Lines)
                {
                    Console.WriteLine("\t" + Line);
                }
            }


            Console.WriteLine("---------------------------------------");

            foreach (Station Station in stations)
            {
                Console.WriteLine(Station.Name);
                foreach (string Line in Station.Lines)
                {
                    Console.WriteLine("\t" + Line);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
