﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDll
{
   internal class StationProvider: IStationProvider  // Créer une classe interne qui implémente l'interface IStationProvider.
    {

        public List<Station> ConvertStationJson() // Cette méthode seras appeller par l'interface IStationProvider.
        {
           List<Station> stationConvert = JsonConvert.DeserializeObject<List<Station>>(CallApi.ApiCall()); // Commande à executer pour la méthode ConvertStationJson().

            foreach (Station st in stationConvert)
            {
                for (int iSelect = 0; iSelect < st.Lines.Count; iSelect++)
                {
                    for (int iCheck = iSelect + 1; iCheck < st.Lines.Count ; iCheck++)
                    {
                        if (st.Lines[iSelect] == st.Lines[iCheck])
                        {
                            st.Lines.Remove(st.Lines[iSelect]);
                            iCheck--;
                        }
                    }
                }
            }
            return stationConvert;
        }
        // public List<Lines>;

        public Dictionary<string, Station> ConvertStationToDict() // Cette méthode seras appeller par l'interface IStationProvider.
        {
            List<Station> myList = ConvertStationJson(); // Créer une liste des données récupèrés par la méthode ConvertStationJson() et les stock dans myList de type <Station>.

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

        public List<string> getLinesIdDict()
        {
            Dictionary<string, Station> stationList = ConvertStationToDict();
            List<string> LinesIdDict = new List<string>();

            foreach (Station st in stationList.Values)
            {
                LinesIdDict = LinesIdDict.Concat(st.Lines).ToList();
            }


            return LinesIdDict.Distinct().ToList();
        }
       
    }

}

