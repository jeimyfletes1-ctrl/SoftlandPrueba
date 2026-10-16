using Softland.Framework.Engine;
using Softland.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Softland.ERP.AS.V
{
    /// <summary>
    /// Interaction logic for DetalleVentana.xaml
    /// </summary>
    public partial class DetalleVentana : SoftlandDetalle
    {
        public DetalleVentana()
        {
            InitializeComponent();
        }

        protected override void ConfigurarVentana(ContextoConexionBD contextoBD)
        {
            base.ConfigurarVentana(contextoBD);
            ColeccionPrincipal = ItemDetalle.ColeccionPrincipal;
        }

        private void Button_Click (object sender, RoutedEventArgs e)
        {
            ColeccionPrincipal.GuardarColeccion();
        }


    }
}
