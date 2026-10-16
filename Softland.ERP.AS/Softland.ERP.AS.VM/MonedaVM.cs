
using Softland.Framework.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softland.ERP.AS.VM
{
    public class MonedaVM : SoftlandColeccion
    {
        public MonedaVM(string IDColeccion, Type Clase, bool usaBloqueo = false)
            : base(IDColeccion, Clase, usaBloqueo) { }
    }
}
