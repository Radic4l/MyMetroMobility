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
            string Y = "45.1856964", X = "5.7287321", details = "true"; // Y = & X = 
            int Z = 400;
            
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            string url = $"http://data.metromobilite.fr/api/linesNear/json?x={X}&y={Y}&dist={Z}&details={details}";
            //Console.WriteLine(url);
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return responseFromServer;
            
        }
    }
}
