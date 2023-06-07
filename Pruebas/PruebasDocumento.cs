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
            p.Condiciones = "Nota:Los precios estan convertidos a pesos mexicanos, cualquier cambio en el dolar se\r\nmodificara el precio.\r\nPrecios sujetos a cambio sin previo aviso\r\n60% de anticipo y 40 % contra entrega\r\nCualquier concepto no considerado en esta cotización será cobrado de manera independiente.\r\nTiempo de entrega:  5 a 8 semanas. (sujeto a disponibilidad)\r\nDebido a la volatilidad de los precios, la vigencia de la cotizacion, sera de 5 dias habiles.\r\n\r\nAgradezco de antemano la atención prestada al presente y me reitero a sus órdenes para cualquier duda\r\no comentario\r\n";
            documento = new Documento(p);
            var file = documento.CrearPDF();
            string rutaArchivo = "Cotizacion.pdf";
            File.WriteAllBytes(rutaArchivo, file);
            Assert.IsNotNull(p.Id);
            Assert.IsNotNull(file);
        }
    }
}