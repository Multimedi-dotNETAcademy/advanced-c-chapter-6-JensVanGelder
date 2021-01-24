using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    class Tijger : Dier
    {
        public Tijger()
        {
            Random rnd = new Random();
            GewichtInKG = Math.Round(rnd.NextDouble() * (310 - 70) + 70,2);
        }
        public override string Zegt()
        {
            return "Diepe Miauw";
        }
    }
}
