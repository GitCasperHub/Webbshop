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
    public class CartModel : PageModel
    {

        public List<Product> CartList = CartManager.CartList;

        [BindProperty]
        public double TotalPrice { get; set; }

        [BindProperty]
        public int PostalCode { get; set; }

        [BindProperty]
        public string Adress { get; set; }

        [BindProperty]
        public string WholeName { get; set; }

        [BindProperty]
        public int PhoneNumber { get; set; }

        public int Quantity { get; set; }

        public void OnGet(string removeId)
        {
            TotalPrice = CartManager.TotalPrice;

            if (removeId != null )
            {
                CartManager.RemoveFromCart(removeId);
            }

            TotalPrice = CartManager.GetPriceSum();

        }

        public void OnPost()
        {
           
        }

    }
}
