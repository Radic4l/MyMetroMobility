using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetroMobility
{
    class StationInfosPovider
    {
        internal Dictionary<string, StationInfos>  getInfos ()
        {
            IStationProvider stationProvider = new StationProvider(); // Nouvelle instance de StationProvider(); en passant par l'interface IStationProvider.
            ILinesProvider linesProvider = new LinesProvider();
            // List<Station> stations = stationProvider.ConvertStationJson();   // Créer une liste de <Station> de la nouvelle instance stationProvider avec la méthode ConvertStationJson().
            Dictionary<string, Station> myStationsDict = stationProvider.ConvertStationToDict(); // Créer un Dictionnaire au format string de <Station> de l'instance stationProvider avec la méthode ConvertStationToDict().
            Dictionary<string, Lines> myLinesDict = linesProvider.ConvertLinesToDict();
            Dictionary<string, StationInfos> stationInfosDict = new Dictionary<string, StationInfos>();

            foreach (KeyValuePair<string, Station> stationKeyValue in myStationsDict)
            {
                List<Lines> lines = new List<Lines>();

                foreach (string line in stationKeyValue.Value.Lines)
                {
                    lines.Add(myLinesDict[line]);
                }
                StationInfos stationInfos = new StationInfos(stationKeyValue.Value.Id,
                                                             stationKeyValue.Value.Name,
                                                             stationKeyValue.Value.Lat,
                                                             stationKeyValue.Value.Lon,
                                                             lines);

                stationInfosDict.Add(stationKeyValue.Key , stationInfos);
            }
            return stationInfosDict;
        }
    }
}
