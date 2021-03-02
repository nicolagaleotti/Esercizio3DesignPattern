using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3DesignPattern
{
    public class FactoryRigaTd : FactoryRiga
    {
        public static FactoryRigaTd Istanza { get; private set; } = new FactoryRigaTd();

        private FactoryRigaTd() { }

        public override Riga NuovaRiga()
        {
            RigaTd riga = new RigaTd();
            return riga;
        }
    }
}
