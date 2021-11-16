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
      
       
        [BindProperty]
        public string Search { get; set; }

        

        [BindProperty(SupportsGet = true)]

        //Property f�r Sortering
        public string Sort { get; set; }
       
        public void OnGet(int Id)
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

     

        public void OnPost(int id)
        {
            


           

            
            //Search Bar s�kningar
            if (Search == "playstation")
            {
                
                Games = Games.Where(game => game.Platform.Contains("Playstation")).ToList();              
            }
            else if (Search == "xbox one")
            {
                
                Games = Games.Where(game => game.Platform.Contains("Xbox One")).ToList();
                
            }
            else if (Search == "electronic arts")
            {
                Games = Games.Where(game => game.Studio.Contains("Electronic Arts")).ToList();

            }
            else if (Search == "activision")
            {
                Games = Games.Where(game => game.Studio.Contains("Activision")).ToList();
              
            }
            else if (Search == "wii")
            {
                Games = Games.Where(game => game.Platform.Contains("Wii")).ToList();

            }
            else if (Search == "cod")
            {
                Games = Games.Where(game => game.Name.Contains("Call of Duty: Vanguard ")).ToList();

            }
        }
    }
}
