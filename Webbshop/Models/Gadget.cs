using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbshop.Models
{
    public class Gadget
    {
        public string GadgetName { get; set; }
        public double GadgetPrice { get; set; }
        public int GadgetStock { get; set; }
        public string GadgetPlatform { get; set; }
        public string GadgetImageURL { get; set; }
        public string GadgetDescription { get; set; }
    }
}
