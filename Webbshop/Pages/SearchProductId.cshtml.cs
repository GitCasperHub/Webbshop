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
    public class SearchProductIdModel : PageModel
    {
        List<Product> allProducts = CartManager.GetAllProducts();
        public string SearchId { get; set; }
        public bool IdMatch { get; set; }
        public string Name { get; set; }


        public void OnGet()
        {



        }

        public void OnPost()
        {

            IdMatch = false;

            foreach (var product in allProducts)
            {
                if (product.Id == SearchId)
                {

                    IdMatch = true;
                    Name = product.Name;
                    break;

                }
            }
        }
    }
}
