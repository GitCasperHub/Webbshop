using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Models
{

    //Properties som används för Game & GameManager
    public class Game
    {
        

        public string Name { get; set; }
        public double Price { get; set; }
        public int AgeRestriction { get; set; }
        public string Platform { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public bool InStock { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Studio { get; set; }
        public double CriticScore { get; set; }
        public string ImageURL { get; set; }

    }
   
}

