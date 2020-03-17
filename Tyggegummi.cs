using System;
using System.Collections.Generic;
using System.Text;

namespace Tyggegummimaskinen
{
    class Tyggegummi
    {
        private string flavour { get; set; }

        public string Flavour
        {
            get
            {
                return flavour;
            }
        }

        public Tyggegummi(string flavour)
        {

            this.flavour = flavour;

        }

        

    }
}
