using Softland.Framework.Engine;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Softland.ERP.AS.V
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void Application_Startup(object sender, StartupEventArgs e)
        {
            ContextoConexionBD contexto = new ContextoConexionBD();
            contexto.TipoBD = TipoBaseDatos.SqlServer;
            contexto.Servidor = "jfletes-lap";
            contexto.BaseDatos = "EXSDGUATE";
            contexto.Compania = "EXSD";
            contexto.Usuario = "sa";
            contexto.Clave = "sa";
            contexto.IDConexion = "Moneda";

            MainWindow window = new MainWindow();
            window.Inicializar(true,contexto);
            window.ShowDialog();
        }
    }

}

