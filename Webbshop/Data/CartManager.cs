using Webbshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Data
{
    public static class CartManager
    {
        public static List<Product> AllProductsList = new List<Product>();
        public static List<Product> CartList = new List<Product>();

        // general
        public static int TotalPrice { get; set; }
        public static int Moms { get; set; }
        public static int RemoveCart { get; set; }
        public static bool ClearCart { get; set; }

        public static List<Product> GetAllProducts()
        {
            foreach (Gadget gadget in GadgetManager.GetGadgets())
            {
                AllProductsList.Add(gadget);
            }
            foreach (Game game in GameManager.GetGames())
            {
                AllProductsList.Add(game);
            }
            foreach (GameConsole console in ConsoleManager.GetGameConsoles())
            {
                AllProductsList.Add(console);
            }

            return AllProductsList;
        }


        public static void AddToCart(int id)
        {
            List<Product> allProducts = GetAllProducts();

            

            for (int i = allProducts.Count-1; i > 0; i--)
            {
                if (allProducts[i].Id == id)
                {
                    CartList.Add( allProducts[i] );
                    // 1 CoD - 2 Fifa - 3 StarW
                }
            }





        }













        public static void RemoveFromCart(int removeId)
        {

            for (int i = CartList.Count - 1; i > 0; i--)
            {
                if (CartList[i].Id == removeId)
                {
                    CartList.Remove(CartList[i]);
                }
            }
        }


    }
}
