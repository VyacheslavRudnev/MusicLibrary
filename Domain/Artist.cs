using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Domain
{
    public class Artist
    {
        public string Img { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        
        public Artist(string name, string genre, string country, string img)
        {
            Name = name;
            Genre = genre;
            Country = country;
            Img = img;
        }
    }
}
