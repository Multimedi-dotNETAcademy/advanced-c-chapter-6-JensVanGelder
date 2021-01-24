using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    class Uil : Dier
    {
        public Uil()
        {
            Random rnd = new Random();
            GewichtInKG = Math.Round(rnd.NextDouble() * (2 - 0.2) + 0.2,2);
        }
        public override string Zegt()
        {
            return "HooHoo";
        }
    }
}
