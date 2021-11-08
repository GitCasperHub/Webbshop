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
    public class IndexModel : PageModel
    {

       public List<Game> Games = GameManager.GetGames();

        public void OnGet()
        {
            Games = Games.OrderBy(game => game.Name).ToList();
            //Games = Games.OrderBy(game => game.ImageURL).ToList();
        }
    }
}
