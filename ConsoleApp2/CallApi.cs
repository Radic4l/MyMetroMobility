using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyMetroMobility
{
    class CallApi
    {
        public static string ApiCall()
        {
            string Y = "45.1856964", X = "5.7287321", details = "true"; // Y = Latitude & X = Longitude.
            int Z = 400;                                                // Z = Rayon de la zone de recherche.
            
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls; // Prévient de l'utilisation des protocoles Tls.
            string url = $"http://data.metromobilite.fr/api/linesNear/json?x={X}&y={Y}&dist={Z}&details={details}"; // Url utilisé lors de l'envoie de la requête stocker dans une variable. (R)

            Console.WriteLine(url);                                   // Affichage de l'url utilisé.

            WebRequest request = WebRequest.Create(url); // Stock la création d'une nouvelle requête avec comme paramètre la variable (url) dans la variable request.
            WebResponse response = request.GetResponse(); // Stock la réponse de request avec la méthode GetResponse() dans la variable response.
            // Console.WriteLine(((HttpWebResponse)response).StatusDescription); // Affiche L'état de la réponsedu serveur web.
            Stream dataStream = response.GetResponseStream(); // Une instance de stream qui prend comme valeur response avec la méthode GetResponseStream().
            StreamReader reader = new StreamReader(dataStream); // Créer une nouvelle instance de StreamReader qui prend comme paramêtre le flux reçu dans dataStream.
            string responseFromServer = reader.ReadToEnd(); // Stock dans une string le flux stocké dans reader et applique la méthode ReadToEnd() Qui va lire tous les caractères entre la position actuelle et la fin du flux.
            reader.Close(); // Ferme le flux actuel et libère toutes les ressources associées à celui-ci.
            response.Close(); // ferme le flux de la réponse du serveur stocké dans response.
            return responseFromServer; // Retourne au format string le résultat du flux stocké.
            
        }

        public static string ApiCallBus()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls; // Prévient de l'utilisation des protocoles Tls.

            

            string url = $"https://data.metromobilite.fr/api/routers/default/index/routes?codes=SEM:12"; // Url utilisé lors de l'envoie de la requête stocker dans une variable.(R)


            Console.WriteLine(url);                       // Affichage de l'url utilisé.

            WebRequest request = WebRequest.Create(url); // Stock la création d'une nouvelle requête avec comme paramètre la variable (url) dans la variable request.
            WebResponse response = request.GetResponse(); // Stock la réponse de request avec la méthode GetResponse() dans la variable response.
            // Console.WriteLine(((HttpWebResponse)response).StatusDescription); // Affiche L'état de la réponsedu serveur web.
            Stream dataStream = response.GetResponseStream(); // Une instance de stream qui prend comme valeur response avec la méthode GetResponseStream().
            StreamReader reader = new StreamReader(dataStream); // Créer une nouvelle instance de StreamReader qui prend comme paramêtre le flux reçu dans dataStream.
            string responseFromServer = reader.ReadToEnd(); // Stock dans une string le flux stocké dans reader et applique la méthode ReadToEnd() Qui va lire tous les caractères entre la position actuelle et la fin du flux.
            reader.Close(); // Ferme le flux actuel et libère toutes les ressources associées à celui-ci.
            response.Close(); // ferme le flux de la réponse du serveur stocké dans response.
            return responseFromServer; // Retourne au format string le résultat du flux stocké.

        }
    }
}
