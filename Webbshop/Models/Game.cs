using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Models
{
    public class Game
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public int AgeRestriction { get; set; }
        public List<string> Platform { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public bool InStock { get; set; }
        public string Genre { get; set; }
        public int ReleaseDate { get; set; }
        public string Stduio { get; set; }
        public string CriticScore { get; set; }


    }
   
}

