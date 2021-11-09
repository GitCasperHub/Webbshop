using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webbshop.Data;
using Webbshop.Models;

namespace Webbshop.Pages
{
    public class AdminAddGameModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        public int Price { get; set; }
        public int AgeRestriction { get; set; }
        public List<string> Platform { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Studio { get; set; }
        public double CriticScore { get; set; }
        public string ImageURL { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            Data.GameManager.NewGame(Name, Price, AgeRestriction, Description, Stock, Genre, ReleaseDate, Studio, CriticScore, ImageURL);
            Data.GameManager.GetGames();
        }

    }
}
