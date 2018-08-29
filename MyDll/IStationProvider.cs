using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll // L'interface fait parti de l'espace MyMetroMobility.
{
    internal interface IStationProvider // Une interface interne. elle seras implémenter par une classe qui possèderas ces méthodes.

    {
        List<Station> ConvertStationJson(); // La liste de Station utiliseras la méthode ConvertStationJson().
        Dictionary<string, Station> ConvertStationToDict(); // Les Dictionnaires de type <string & Station> utiliseras la méthode ConvertStationToDict().
        List<string> getLinesIdDict();
    }
}
