using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3DesignPattern
{
    public abstract class Riga
    {
        internal Riga() { }

        public abstract Cella NuovaCella();
    }
}
