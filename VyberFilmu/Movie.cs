using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace VyberFilmu
{
    public class Movie
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public List<string> Genre { get; set; }

        public Movie(string name, string country, List<string> genre)
        {
            Name = name;
            Country = country;
            Genre = genre;
        }
    }
}
