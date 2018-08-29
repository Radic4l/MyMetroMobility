using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDll
{
    public class Lines
    {
        public string id { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string color { get; set; }
        public string textColor { get; set; }
        public string mode { get; set; }
        public string type { get; set; }

        public override string ToString()
        {
            return $"Le {mode} {type} N° {shortName} En direction de : {longName}";
        }
    }
}
