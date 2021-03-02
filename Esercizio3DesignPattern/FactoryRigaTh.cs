using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3DesignPattern
{
    public class FactoryRigaTh : FactoryRiga
    {
        public static FactoryRigaTh Istanza { get; private set; } = new FactoryRigaTh();

        private FactoryRigaTh() { }

        public override Riga NuovaRiga()
        {
            RigaTh riga = new RigaTh();
            return riga;
        }
    }
}
