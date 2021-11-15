using Webbshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Data
{
    public static class ConsoleManager
    {


        public static List<GameConsole> Consoles { get; set; }

        public static List<GameConsole> GetGameConsoles()
        {
            if (Consoles == null || !Consoles.Any())
            {
                Consoles = new List<GameConsole>
                {
                    new GameConsole()
                    {
                        ConsoleName = "Playstation 5",
                        ConsolePrice = 4999,
                        ConsoleDeveloper = "Sony Interactive Entertainment",
                        ConsoleRelease = "12/11/2020",
                        ConsoleStock = 0,
                        ConsoleDescription = 
                        "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment. " +
                        "Announced in 2019 as the successor to the PlayStation 4. " +
                        "The PlayStation 5's main hardware features include a solid-state drive customized for high-speed data streaming " +
                        "to enable significant improvements in storage performance, an AMD GPU capable of 4K resolution display at up to 120 frames per second,",
                        ConsoleImageURL = "https://pricespy-75b8.kxcdn.com/product/standard/280/5113846.jpg"

                    },
                     new GameConsole()
                    {
                        ConsoleName = "Xbox Series X ",
                        ConsolePrice = 4999,
                        ConsoleDeveloper = "Microsoft",
                        ConsoleRelease = "10/11/2020",
                        ConsoleStock = 3,
                        ConsoleDescription =
                        "The Xbox Series X is a home video game consoles developed by Microsoft" +
                        "The Xbox Series X has higher end hardware, and supports higher display resolutions (up to 8K resolution) " +
                        "along with higher frame rates and real-time ray tracing; it also has a high-speed solid-state drive to reduce loading times.",
                        ConsoleImageURL = "https://pricespy-75b8.kxcdn.com/product/standard/280/5147004.jpg"

                    },
                      new GameConsole()
                    {
                        ConsoleName = "Nintendo Switch",
                        ConsolePrice = 3299,
                        ConsoleDeveloper = "Nintendo",
                        ConsoleRelease = "03/03/2017",
                        ConsoleStock = 8,
                        ConsoleDescription = 
                        "The Nintendo Switch is a hybrid video game console, consisting of a console unit, a dock, and two Joy-Con controllers. " +
                        "Although it is a hybrid console, Nintendo classifies it as a home console that you can take with you on the go.",
                        ConsoleImageURL = "https://www.nintendo.se/images/_sections/section_nintendo_switch/overview/nintendoswitchrevised.jpg"

                    },
                       new GameConsole()
                    {
                        ConsoleName = "Xbox One",
                        ConsolePrice = 4499,
                        ConsoleDeveloper = "Microsoft",
                        ConsoleRelease = "22/11/2013",
                        ConsoleStock = 6,
                        ConsoleDescription =
                        "The Xbox One is a line of home video game consoles developed by Microsoft. " +
                        "It is the successor to Xbox 360 and the third base console in the Xbox series of video game consoles." +
                        "Moving away from its predecessor's PowerPC-based architecture, the Xbox One features an AMD Accelerated Processing Unit (APU) " +
                        "built around the x86-64 instruction set.",
                        ConsoleImageURL = "https://www.netonnet.se/files/Content/Xbox/XboxOne_Content_Topp_1766x718.jpg"

                    },
                        new GameConsole()
                    {
                        ConsoleName = "Playstation 4",
                        ConsolePrice = 3349,
                        ConsoleDeveloper = "Sony Computer Entertainment",
                        ConsoleRelease = "15/11/2013",
                        ConsoleStock = 7,
                        ConsoleDescription =
                        "The PlayStation 4 (PS4) is a home video game console developed by Sony Computer Entertainment. " +
                        "The PlayStation 4 moved away from the more complex Cell microarchitecture of its predecessor, " +
                        "the console features an AMD Accelerated Processing Unit (APU) built upon the x86-64 architecture",
                        ConsoleImageURL = "https://www.pricerunner.se/product/1200x630/1688121826/Sony-Playstation-4-Pro-1TB-Black-Edition.jpg"

                    },


                };

            }




                return Consoles;
        }
        

    }
}
