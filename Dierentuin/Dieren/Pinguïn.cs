using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    class Pinguïn : Dier
    {
        public Pinguïn()
        {
            Random rnd = new Random();
            GewichtInKG = Math.Round(rnd.NextDouble() * (25 - 1.5) + 1.5, 2);
        }
        public override string Zegt()
        {
            return "Surf's Up!";
        }
    }
}
