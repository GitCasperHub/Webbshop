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
    public class ShowGadgetsModel : PageModel
    {

        public List<Gadget> gadgets = GadgetManager.GetGadgets();

        [BindProperty(SupportsGet = true)]
        public string Sort { get; set; }

        public void OnGet()
        {

            gadgets = gadgets.OrderBy(Gadget => Gadget.GadgetName).ToList();

            if (Sort == "Price")
            {
                gadgets = gadgets.OrderBy(Gadget => Gadget.GadgetPrice).ToList();
            }
            else if (Sort == "A2Z")
            {
                gadgets = gadgets.OrderBy(Gadget => Gadget.GadgetName).ToList();
            }
            else if (Sort == "Z2A")
            {
                gadgets = gadgets.OrderByDescending(Gadget => Gadget.GadgetName).ToList();
            }


        }
    }
}
