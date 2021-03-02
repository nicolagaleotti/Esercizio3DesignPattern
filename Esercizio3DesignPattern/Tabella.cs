using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3DesignPattern
{
    public class Tabella
    {
        List<Riga> righe = new List<Riga>();

        public static Tabella Istanza { get; private set; } = new Tabella();

        private Tabella() { }

        public Riga NuovaRiga()
        {
            Riga r = FactoryRigaTh.Istanza.NuovaRiga();
            righe.Add(r);
            return r;
        }
    }
}
