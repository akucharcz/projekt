﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Zakupy
    {
        public string nazwa { get; set; }
        public string koszt { get; set; }
        public string dzien { get; set; }
        public string miesiac { get; set; }
        public string rok { get; set; }

        virtual public string Wypisz()
        {
            string x;
            x = "Nazwa: " + this.nazwa + ", koszt: "
                + this.koszt + ", data: " + this.dzien + "." + this.miesiac + "." + this.rok;

            return x;

        }





    }

    

}
