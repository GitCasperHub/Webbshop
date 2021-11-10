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
        public List<GameConsole> Consoles = ConsoleManager.GetGameConsoles();
        public void OnGet()
        {
            Consoles = Consoles.OrderBy(gameConsole => gameConsole.ConsoleName).ToList();
        }
    }
}
