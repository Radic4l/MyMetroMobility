using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetroMobility
{
    class ConvertToDict
    {
        Dictionary<string, string> myDict =
        new Dictionary<string, string>();
        
        public void ToConvert()
        {

            //// Add some elements to the dictionary. There are no 
            //// duplicate keys, but some of the values are duplicates.
            //myDict.Add("txt", "notepad.exe");
            //myDict.Add("bmp", "paint.exe");
            //myDict.Add("dib", "paint.exe");
            //myDict.Add("rtf", "wordpad.exe");

            //// The Add method throws an exception if the new key is 
            //// already in the dictionary.
            //try
            //{
            //    myDict.Add("txt", "winword.exe");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("An element with Key = \"txt\" already exists.");
            //}
            ////return myDict;
        }
    }
}
