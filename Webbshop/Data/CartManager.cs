using Webbshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Data
{
    public static class CartManager
    {
        public static List<Product> CartList = new List<Product>();

        // genera¨l
        public static int TotalPrice { get; set; }
        public static int Moms { get; set; }
        public static int RemoveCart { get; set; }
        public static bool ClearCart { get; set; }
       
        public static List<Product> GetAllProducts()
        {
            foreach(Gadget gadget in GadgetManager.GetGadgets())
            {
                CartList.Add(gadget);
            }
            foreach (Game game in GameManager.GetGames())
            {
                CartList.Add(game);
            }
            foreach (GameConsole console in ConsoleManager.GetGameConsoles())
            {
                CartList.Add(console);
            }

            return CartList;
        }

        public static void AddToCart(int id)
        {
            List<Product> allProducts = GetAllProducts();

            Product product = allProducts.Where(p => p.Id == id).FirstOrDefault();

            CartList.Add(product);
        }

        // delivery

        // betalning



       
      

    }
}
