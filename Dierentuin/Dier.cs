using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    abstract class Dier
    {
        public double GewichtInKG { get; set; }
        public abstract string Zegt();
        public override string ToString()
        {
            return $"{GetType().Name} - {GewichtInKG}KG";
        }
    }
}
