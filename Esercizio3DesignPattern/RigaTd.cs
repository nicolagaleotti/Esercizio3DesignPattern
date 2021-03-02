using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3DesignPattern
{
    public class RigaTd:Riga
    {
        List<Cella> celle = new List<Cella>();

        public RigaTd() { }

        public override Cella NuovaCella()
        {
            Cella c = new Cella();
            celle.Add(c);
            return c;
        }
    }
}
