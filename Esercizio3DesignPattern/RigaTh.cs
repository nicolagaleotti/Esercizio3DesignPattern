using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3DesignPattern
{
    public class RigaTh : Riga
    {
        List<Cella> celle = new List<Cella>();

        public RigaTh() { }

        public override Cella NuovaCella()
        {
            Cella c = new Cella();
            celle.Add(c);
            return c;
        }
    }
}
