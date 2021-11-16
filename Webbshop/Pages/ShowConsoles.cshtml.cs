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

        public List<GameConsole> consoles = ConsoleManager.GetGameConsoles();


        [BindProperty]
        public string Search { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Sort { get; set; }
        public void OnGet()
        {

            consoles = consoles.OrderBy(gameConsole => gameConsole.Name).ToList();

            if (Sort == "Price")
            {
                consoles = consoles.OrderBy(gameConsole => gameConsole.Price).ToList();
            }
            else if (Sort == "A2Z")
            {
                consoles = consoles.OrderBy(gameConsole => gameConsole.Name).ToList();
            }
            else if (Sort == "Z2A")
            {
                consoles = consoles.OrderByDescending(gameConsole => gameConsole.Name).ToList();
            }


        }
       

        public void Onpost()
        {

            

            //Search Bar s�kningar
            if (Search == "playstation")
            {

                consoles = consoles.Where(console => console.Name.Contains("Playstation")).ToList();

            }
            else if (Search == "xbox ")
            {

                consoles = consoles.Where(console => console.Name.Contains("Xbox")).ToList();


            }
            else if (Search == "nintendo")
            {

                consoles = consoles.Where(console => console.Name.Contains("Nintendo")).ToList();


            }
            else if (Search == "sony")
            {

                consoles = consoles.Where(console => console.ConsoleDeveloper.Contains("Sony")).ToList();


            }


        }
    }
}
