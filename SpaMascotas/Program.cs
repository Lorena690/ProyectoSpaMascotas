
namespace FASE2_SPAMASCOTAS
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new IngresoSistema(new SpaMascotas()));
        }
    }
}