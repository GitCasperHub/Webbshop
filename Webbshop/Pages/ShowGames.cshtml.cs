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
        public List<GameConsole> consoles = ConsoleManager.GetGameConsoles();
        public List<Gadget> gadgets = GadgetManager.GetGadgets();

        [BindProperty]
        public string Search { get; set; }

        [BindProperty(SupportsGet = true)]

        //Property f�r Sortering
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

        public void OnPost()
        {
            string searchWord = Search.ToLower();


            //Search Bar s�kningar
            if (searchWord == "playstation")
            {

                Games = Games.Where(game => game.Platform.Contains("Playstation")).ToList();              
            }
            else if (searchWord == "xbox one")
            {
                Games = Games.Where(game => game.Platform.Contains("Xbox One")).ToList();
                
            }
            else if (searchWord == "electronic arts")
            {
                Games = Games.Where(game => game.Studio.Contains("Electronic Arts")).ToList();

            }
            else if (searchWord == "activision")
            {
                Games = Games.Where(game => game.Studio.Contains("Activision")).ToList();
              
            }
            else if (searchWord == "wii")
            {
                Games = Games.Where(game => game.Platform.Contains("Wii")).ToList();

            }
        }
    }
}
