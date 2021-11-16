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

        public void OnGet(int Id)
        {
         
            
        }

        public void OnPost(int removeId)
        {

            //CartManager.RemoveFromCart(removeId);

            //CartList = CartList.OrderBy(product => product.Price).ToList();


        }

    }
}
