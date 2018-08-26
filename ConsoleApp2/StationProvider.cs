using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyMetroMobility
{
   internal class StationProvider: IStationProvider  // Créer une classe interne qui implémente l'interface IStationProvider.
    {
        internal StationProvider() // Une méthode interne appelé StationProvider(). 
        {

        }

        public List<Station> ConvertJson() // Cette méthode seras appeller par l'interface IStationProvider.
        {
            return JsonConvert.DeserializeObject<List<Station>>(CallApi.ApiCall()); // Commande à executer pour la méthode ConvertJson().
        }

        public Dictionary<string, Station> ConvertToDict() // Cette méthode seras appeller par l'interface IStationProvider.
        {
            List<Station> myList = ConvertJson(); // Créer une liste des données récupèrés par la méthode ConvertJson() et les stock dans myList de type <Station>.

            Dictionary<string, Station> myDict = new Dictionary<string, Station>(); // Créer une nouvelle instance de Dictionary de type <string, Station>;
            // Console.WriteLine("myList avant et = à " + myDict.Count);
            foreach (Station station in myList) // Boucle qui créer une station de de type Station de myList.
            {
                if (myDict.ContainsKey(station.Name)) // Si mon dictionnaire myDict contient déjà le nom de la cle station.
                {
                    for (int i = 0; i < station.Lines.Count; i++) // Boucle sur le nombres de lignes de station.
                    {
                        if (!myDict[station.Name].Lines.Contains(station.Lines[i])) // Si mon au nom de la station dans mon dictionnaire ne contient pas la lignes de ma station de myList.
                        {
                            myDict[station.Name].Lines.Add(station.Lines[i]); // Ajoute dans les lignes au nom de la station, la ligne de la station de myList.
                        }
                    }
                }
                else
                {
                    myDict.Add(station.Name, station); // Ajoute le nom de la station de myList dans mon dictionnaire.
                }
            }
            // Console.WriteLine("myList après et = à " + myDict.Count);
            return myDict; // Retourne les valeurs de mon dictionnaire.
        }
       
    }

}

