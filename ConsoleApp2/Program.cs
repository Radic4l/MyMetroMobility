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
        static void Main(string[] args) // Méthode static qui ne retourne rien [void], Main qui seras la Classe de démmarage de mon application.
        {
            IStationProvider stationProvider = new StationProvider(); // Nouvelle instance de StationProvider(); en passant par l'interface IStationProvider.
            // List<Station> stations = stationProvider.ConvertJson();   // Créer une liste de <Station> de la nouvelle instance stationProvider avec la méthode ConvertJson().
            Dictionary<string, Station> myDict = stationProvider.ConvertToDict(); // Créer un Dictionnaire au format string de <Station> de l'instance stationProvider avec la méthode ConvertToDict().





            foreach (Station Station in myDict.Values) // Une boucle pour stocker chaque stations dans une variable.
            {
                Console.WriteLine(Station.Name); // Affiche Le nom d'une station
                foreach (string Line in Station.Lines) // Une boucle pour stocker chaque lignes de la station.
                {
                    Console.WriteLine("\t" + Line); // Affiche une ligne de station.
                }
            }


            Console.WriteLine("---------------------------------------");

            //foreach (Station Station in stations)
            //{
            //    Console.WriteLine(Station.Name);
            //    foreach (string Line in Station.Lines)
            //    {
            //        Console.WriteLine("\t" + Line);
            //    }
            //}
            //Console.WriteLine();
            Console.ReadKey(); // Attends l'utilisation d'une touche par l'utilisateur.
        }
    }
}
