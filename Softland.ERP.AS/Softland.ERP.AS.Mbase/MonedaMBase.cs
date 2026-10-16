using Softland.Framework.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softland.ERP.AS.Mbase
{
    [TablaBD("MONEDA", "Moneda Prueba")]
    public class MonedaMBase : SoftlandObjeto
    {
        private string _MONEDA { get; set; }

        [ColumnaBD(RelacionColumnaEnum.LlavePrimaria, "MONEDA", "Moneda", "Moneda", "Moneda", 1, 100, 4, "")]
        public string MONEDA
        {
            get
            {
                return _MONEDA;
            }
            set
            {
                this._MONEDA = value;
                NotifyPropertyChanged(nameof(MONEDA));
            }
        }


        
         private string _NOMBRE { get; set; }

         [ColumnaBD(RelacionColumnaEnum.Ninguna, "NOMBRE", "Nombre", "Nombre", "Nombre", 2, 100, 40, "")]
         public string NOMBRE
            {
                get
                {
                    return _NOMBRE;
                }
                set
                {
                    this._NOMBRE = value;
                    NotifyPropertyChanged(nameof(NOMBRE));
                }
            }
       
    }
}
