using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Models
{
    //Properties för ConsoleManager & GameConsole
    public class GameConsole
    {
       
        public string ConsoleName { get; set; }
        public int ConsolePrice { get; set; }
        public string ConsoleDeveloper { get; set; }
        public string ConsoleRelease { get; set; }
        public int ConsoleStock { get; set; }
        public string ConsoleDescription { get; set; }
        public string ConsoleImageURL { get; set; }

    }
}
