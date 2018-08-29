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
            StationInfosPovider myData = new  StationInfosPovider();
            
            foreach (StationInfos Station in myData.getInfos().Values) // Une boucle pour stocker chaque stations dans une variable.
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine(Station.ToString());
            }
            Console.ReadKey(); // Attends l'utilisation d'une touche par l'utilisateur.
        }
    }
}
