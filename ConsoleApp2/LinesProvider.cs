using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetroMobility
{
    internal class LinesProvider : ILinesProvider
    {
        public List<Lines> ConvertLinesJson() // Cette méthode seras appeller par l'interface ILinesProvider.
        {
            return JsonConvert.DeserializeObject<List<Lines>>(CallApi.ApiCallBus()); // Commande à executer pour la méthode ConvertLinesJson().
        }
        // public List<Lines>;

        public Dictionary<string, Lines> ConvertLinesToDict() // Cette méthode seras appeller par l'interface ILinesProvider.
        {
            List<Lines> myList = ConvertLinesJson(); // Créer une liste des données récupèrés par la méthode ConvertLinesJson() et les stock dans myList de type <Lines>.

            Dictionary<string, Lines> myDict = new Dictionary<string, Lines>(); // Créer une nouvelle instance de Dictionary de type <string, Lines>;
            // Console.WriteLine("myList avant et = à " + myDict.Count);
            foreach (Lines line in myList) // Boucle qui créer une line de de type Lines de myList.
            {
                if (!myDict.ContainsKey(line.id)) // Si mon dictionnaire myDict contient déjà le nom de la cle station.
                {
                    myDict.Add(line.id, line); // Ajoute le nom de la ligne de myList dans mon dictionnaire.
                }
            }
            // Console.WriteLine("myList après et = à " + myDict.Count);
            return myDict; 
        }
    }
}
// Url : https://data.metromobilite.fr/api/routers/default/index/routes?codes=SEM:12