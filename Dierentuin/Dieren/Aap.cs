using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    class Aap : Dier
    {
        public Aap()
        {
            Random rnd = new Random();
            GewichtInKG = Math.Round(rnd.NextDouble() * (35 - 4) + 4, 2);
        }
        public override string Zegt()
        {
            return "OooAaaEeee";
        }
    }
}
