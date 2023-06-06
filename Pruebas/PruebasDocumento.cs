using backend.Dominio;
using backend.Servicios;
using backend.Servicios.Documento;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using SharpCompress.Archives;

namespace Pruebas
{
    [TestFixture]
    public class PruebasDocumento
    {
        IServiciosCRUD serviciosCRUD;
        IConfiguration config;
        Documento documento;
        [SetUp]
        public void SetUp() {
            config = InitConfiguration();
            serviciosCRUD = new ServiciosCRUD(config);
        }

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();
            return config;
        }

        [Test]
        public void CargaProyectoYCreaPDF() {
            var p = serviciosCRUD.obtener<Proyecto>(p=>p.Cliente.Empresa=="YKK").FirstOrDefault();
            documento = new Documento(p);
            var file = documento.CrearPDF();
            string rutaArchivo = "Cotizacion.pdf";
            File.WriteAllBytes(rutaArchivo, file);
            Assert.IsNotNull(p.Id);
            Assert.IsNotNull(file);
        }


    }
}