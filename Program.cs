using uai_poo_actividad_integradora_3.GUI.Grillas;

namespace uai_poo_actividad_integradora_3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AdministradorDeProductos());
        }
    }
}