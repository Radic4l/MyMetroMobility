using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyMetroMobility
{
   internal class StationProvider: IStationProvider
    {
        internal StationProvider()
        {

        }

        public List<Station> ConvertJson()
        {
            return JsonConvert.DeserializeObject<List<Station>>(CallApi.ApiCall());
        }

        public Dictionary<string, Station> ConvertToDict()
        {
            List<Station> myList = ConvertJson();

            Dictionary<string, Station> myDict = new Dictionary<string, Station>();

            //
            //
            foreach (Station station in myList)
            {
                if (myDict.ContainsKey(station.Name))
                {
                    for (int i = 0; i < station.Lines.Count; i++)
                    {
                        if (!myDict[station.Name].Lines.Contains(station.Lines[i]))
                        {
                            myDict[station.Name].Lines.Add(station.Lines[i]);
                        }
                    }
                }
                else
                {
                    myDict.Add(station.Name, station);
                }
            }
            
            return myDict;
        }
       
    }

}

