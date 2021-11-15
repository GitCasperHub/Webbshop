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
    public class ShowConsolesModel : PageModel
    {
        public List<Game> Games = GameManager.GetGames();
        public List<GameConsole> consoles = ConsoleManager.GetGameConsoles();
        public List<Gadget> gadgets = GadgetManager.GetGadgets();

        [BindProperty]
        public string Search { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Sort { get; set; }
        public void OnGet()
        {

            consoles = consoles.OrderBy(gameConsole => gameConsole.ConsoleName).ToList();

            if(Sort == "Price")
            {
                consoles = consoles.OrderBy(gameConsole => gameConsole.ConsolePrice).ToList();
            }
            else if (Sort == "A2Z")
            {
                consoles = consoles.OrderBy(gameConsole => gameConsole.ConsoleName).ToList();
            }
            else if (Sort == "Z2A")
            {
                consoles = consoles.OrderByDescending(gameConsole => gameConsole.ConsoleName).ToList();
            }


        }

        public void Onpost()
        {
            string searchWord = Search.ToLower();


            //Search Bar sökningar
            if (searchWord == "playstation")
            {

                consoles = consoles.Where(console => console.ConsoleName.Contains("Playstation")).ToList();

            }


        }

       
    }
}
