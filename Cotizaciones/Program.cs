using Microsoft.Extensions.Configuration;

namespace Cotizaciones
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
            Application.Run(new frmSistemaCotizaciones());
        }
        public static IConfiguration InitConfiguration
        {
            get
            {
                {
                    var config = new ConfigurationBuilder()
                       .AddJsonFile("appsettings.json")
                       .Build();
                    return config;
                }
            }
        }
    }
}