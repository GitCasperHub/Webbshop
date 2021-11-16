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
    public class EditProductModel : PageModel
    {

        List<Product> allProducts = CartManager.GetAllProducts();

        public string SearchId { get; set; }

        public void OnGet()
        {
        }

        public void Post()
        {
            foreach(var product in allProducts)
            {
                if(product.Id == SearchId)
                {
                    product.Name = "";
                    break;
                }

            }
        }
    }
}
