using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    public class StationInfos
    {
        public string Id { get; set; }          // Récupère la valeur de Id et l'attribue à la variable.
        public string Name { get; set; }        // Récupère la valeur de Name et l'attribue à la variable.
        public double Lon { get; set; }         // Récupère la valeur de Lon et l'attribue à la variable.
        public double Lat { get; set; }         // Récupère la valeur de Lat et l'attribue à la variable.
        public List<Lines> Lines { get; set; } // Récupère les valeurs de Lines et créer une liste de string et l'attribue à la variable.

        public StationInfos(Station station, List<Lines> lines)
        {
            Id = station.Id;
            Name = station.Name;
            Lon = station.Lon;
            Lat = station.Lat;
            Lines = lines;
        }
        public StationInfos(string id, string name, double lon, double lat, List<Lines> lines)
        {
            Id = id;
            Name = name;
            Lon = lon;
            Lat = lat;
            Lines = lines;
        }
        public override string ToString()
        {
            string lines = "";
            foreach (Lines Line in Lines) // Une boucle pour stocker chaque lignes de la station.
            {
                lines += "\n" + Line.ToString(); // Affiche une ligne de station.
            }
            return $"Arrêt : {Name}\n Les lignes de cet arrêt sont : \n-----------\n{lines}\n-------------";
        }
    }
}
