using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetroMobility // Espace utilisé.
{
    public class Station // Constructeur Station
    {
        public string Id { get; set; }          // Récupère la valeur de Id et l'attribue à la variable.
        public string Name { get; set; }        // Récupère la valeur de Name et l'attribue à la variable.
        public double Lon { get; set; }         // Récupère la valeur de Lon et l'attribue à la variable.
        public double Lat { get; set; }         // Récupère la valeur de Lat et l'attribue à la variable.
        public List<string> Lines { get; set; } // Récupère les valeurs de Lines et créer une liste de string et l'attribue à la variable.
    }
}
