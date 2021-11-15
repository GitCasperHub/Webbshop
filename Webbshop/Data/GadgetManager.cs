using Webbshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Data
{
    public static class GadgetManager
    {
        public static List<Gadget> Gadgets { get; set; }

        public static List<Gadget> GetGadgets()
        {
            if (Gadgets == null || !Gadgets.Any())
            {
                Gadgets = new List<Gadget>
                {
                    new Gadget()
                    {
                        GadgetName = "PlayStation 5 Controller",
                        GadgetPrice = 629,
                        GadgetStock = 10,
                        GadgetPlatform = "PlayStation 5",
                        GadgetImageURL = "https://www.mytrendyphone.se/images/Sony-PlayStation-5-DualSense-Wireless-Controller-23122020-White-0711719399506-01-p.jpg",
                        GadgetDescription = "The DualSense™ wireless controller offers immersive haptic feedback1, " +
                        "dynamic adaptive triggers and a built-in microphone, all integrated into an iconic comfortable design."

                    },
                     new Gadget()
                    {
                        GadgetName = "PlayStation 4 Controller",
                        GadgetPrice = 649,
                        GadgetStock = 13,
                        GadgetPlatform = "PlayStation 4",
                        GadgetImageURL = "https://www.pricerunner.se/product/1200x630/1554043887/Sony-DualShock-4-Wireless-Controller-Black.jpg",
                        GadgetDescription = "The Wireless PlayStation 4 Controller is one of Sonys most comfortable controllers ever"

                    },
                      new Gadget()
                    {
                        GadgetName = "SCUF Xbox Series X Controller",
                        GadgetPrice = 2000,
                        GadgetStock = 4,
                        GadgetPlatform = "Xbox Series X & Xbox One",
                        GadgetImageURL = "https://scufgaming.com/media/prismic/71b5c986-76fd-4182-b7de-31d3c8ad2234_instinct_base_shadow_xbox_series_x_controller_850x600.png",
                        GadgetDescription = "Custome Made Wireless Controller for Primarly Xbox Series X. " +
                        "Adds a competitive edge with non-slip performance grip and instant triggers." +
                        "Works with Xbox One because of backward compatibility."

                    },
                       new Gadget()
                    {
                        GadgetName = "Xbox One Controller",
                        GadgetPrice = 550,
                        GadgetStock = 15,
                        GadgetPlatform = "Xbox One & Xbox Series X",
                        GadgetImageURL = "https://www.pricerunner.se/product/1200x630/1752541419/Microsoft-Xbox-One-Wireless-Controller-White.jpg",
                        GadgetDescription = "Wireless Xbox One Controller, forward compatibility so it works with Xbox Series X aswell."

                    },
                        new Gadget()
                    {
                        GadgetName = "Branch Outlet 6-way",
                        GadgetPrice = 99,
                        GadgetStock = 25,
                        GadgetPlatform = "Works for all Platforms",
                        GadgetImageURL = "https://www.netonnet.se/GetFile/ProductImagePrimary/hem-fritid/el-batterier/grenuttag/on-extension-lead-6-way-grounded-with-switch-1-5m(1003909)_325892_1_Normal_Large.jpg",
                        GadgetDescription = "Branch Outlet with 6-way extension and ON/OFF switch"

                    },

                };



            }


            return Gadgets;
        }

    }
}
