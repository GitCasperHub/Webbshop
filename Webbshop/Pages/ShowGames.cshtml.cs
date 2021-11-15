using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webbshop.Models;
using Webbshop.Data;

namespace Webbshop.Pages
{
    public class ShowGamesModel : PageModel
    {
        public List<Game> Games = GameManager.GetGames();

        [BindProperty(SupportsGet = true)]

        //Property för Sortering
        public string Sort { get; set; }
       
        public void OnGet()
        {
            Games = Games.OrderBy(game => game.Name).ToList();



            //Sortering Via Price
            if (Sort == "Price")
            {
                Games = Games.OrderBy(game => game.Price).ToList();
            }
            //Sortering A till Z
            else if (Sort == "A2Z")
            {
                Games = Games.OrderBy(game => game.Name).ToList();
            }
            //Sortering Z till A
            else if (Sort == "Z2A")
            {
                Games = Games.OrderByDescending(game => game.Name).ToList();
            }

         

        }
    }
}
