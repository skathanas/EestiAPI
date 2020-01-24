using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;

namespace EestiAPI
{
    class info
    {
        public string name { get; set; }
        public string cioc { get; set; }
        public string domain { get; set; }
        public string capital { get; set; }
        public string region { get; set; }
        public string population { get; set; }
        public string language { get; set; }
    }
}
