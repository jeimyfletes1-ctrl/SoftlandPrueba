using Softland.ERP.AS.Mbase;
using Softland.ERP.AS.VM;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Softland.ERP.AS.V
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : SoftlandVentana
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void ConfigurarVentana(ContextoConexionBD contextoBD)
        {
            base.ConfigurarVentana(contextoBD);

            GestorConexionesBD.CrearConexion(contextoBD);
            GestorConexionesBD.AbrirConexion(contextoBD.IDConexion);

            Type clase = typeof(MonedaMBase);
            ColeccionPrincipal = new MonedaVM(contextoBD.IDConexion, clase);
            ColeccionPrincipal.CargarColeccion();

            PrepararBarraMenu();
            PreparacionInicialTabla();
        }


        public void PrepararBarraMenu()
        {
            SFBarraMenu.Boton_Nuevo_Click += SFBarraMenu_Boton_Nuevo_Click;
            SFBarraMenu.Boton_Guardar_Click += SFBarraMenu_Boton_Guardar_Click;
            SFBarraMenu.Boton_Modificar_Click += SFBarraMenu_Boton_Modificar_Click;
            SFBarraMenu.EliminarItemBarra(SoftlandBarraMenu.Nombre_Boton_CargadorDinamico, SoftlandBarraMenu.Nombre_Categoria_ExportarImportar);
        }

        private void SFBarraMenu_Boton_Modificar_Click(object sender, RoutedEventArgs e)
        {
            DetalleVentana detalleVentana = new DetalleVentana();
            detalleVentana.ItemDetalle = SFTablaMoneda.ItemActual;
            detalleVentana.Inicializar(true, GestorConexionesBD.ObtenerContextoPorID(ColeccionPrincipal.NombreColeccion));
            detalleVentana.ShowDialog();

        }

        private void SFBarraMenu_Boton_Guardar_Click(object sender, RoutedEventArgs e)
        {
            ColeccionPrincipal.GuardarColeccion();
        }

        private void SFBarraMenu_Boton_Nuevo_Click(object sender, RoutedEventArgs e)
        {
            //ColeccionPrincipal.CrearNuevoSObjeto();
            DetalleVentana detalleVentana = new DetalleVentana();
            detalleVentana.ItemDetalle = (MonedaMBase)ColeccionPrincipal.CrearNuevoSObjeto();
            detalleVentana.Inicializar(true, GestorConexionesBD.ObtenerContextoPorID(ColeccionPrincipal.NombreColeccion));
            detalleVentana.ShowDialog();
        }



        protected virtual void PreparacionInicialTabla()
        {
            SFTablaMoneda.config_SeleccionMultiple = true;
            SFTablaMoneda.config_EsEditable = true;
            SFTablaMoneda.config_IncluirColumnaNotificacion = true;

            SFTablaMoneda.PrepararTabla("Moneda", ColeccionPrincipal);

        }
    } 
}
