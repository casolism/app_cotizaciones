using backend.Dominio;
using backend.Servicios;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Pruebas
{
    [TestFixture]
    public class PruebasDatos
    {
        IServiciosCRUD serviciosCRUD;
        IConfiguration config;
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
        public void CreaProyectoYKK() {
            decimal margen = 0.5m;
            Proyecto p = new Proyecto() { 
                Cliente = new Cliente() { Empresa = "YKK", Contacto= new Contacto() { Nombre="Juan Pablo González", Correo="juanpablogonzalez@ykk.com"} },
                Descripcion = "Conectores de aviación de 12 mm de 3 y 4 pines",
                Fecha = DateTime.Now,
                Margen = margen,
                ConceptosCotizacion = new List<ConceptoCotizacion>() {
                    new Material(margen){ Cantidad=1, Concepto= "DGZZI 5 Pares GX12 4 Pines Macho Hembra Conector de aviación Circular Conector de 12 mm Panel de Alambre Conector de Metal",
                    CostoUnitario=241.74m,CodigoMaterial="https://www.amazon.com.mx/DGZZI-Conector-aviaci%C3%B3n-Circular-Alambre/dp/B07PQF2RDL"},
                    new Material(margen){ Cantidad=1, Concepto= "WMDER Para 4 juegos GX12 3 pines enchufe de aviación macho hembra panel de alambre conector de metal 12 mm GX12-3",
                    CostoUnitario=286.13m,CodigoMaterial="https://www.amazon.com.mx/WMDER-enchufe-aviaci%C3%B3n-conector-GX12-3/dp/B0BQD46YRP"},                    
                }

            };
            serviciosCRUD.guardar(p);
            Assert.IsNotNull(p.Id);
        }

        [Test]
        public void CreaProyectoCamaras()
        {
            decimal margen = 0.35m;
            Proyecto p = new Proyecto()
            {
                Cliente = new Cliente() { Empresa = "A quien corresponda", Contacto = new Contacto() { Nombre = "Nombre", Correo = "xx@c.c" } },
                Descripcion = "Cotización de cámaras",
                Fecha = DateTime.Now,
                Margen = margen,
                ConceptosCotizacion = new List<ConceptoCotizacion>() {
                    new Material(margen){ Cantidad=2, Concepto= "Domo IP 2 Megapixel / 30 mts IR EXIR / Exterior IP67 / IK10 / Lente 2.8 mm / dWDR / PoE / ONVIF",
                    CostoUnitario=895.08m,CodigoMaterial="DS-2CD1123G0E-I(C)"},
                    new Material(margen){ Cantidad=2, Concepto= "Cámara Bullet Dahua 2 MP, DH-HAC-HFW1209CN-LED-0280B, Full Color 1080p, lente de 2.8mm",
                    CostoUnitario=395.39m,CodigoMaterial="DH-HAC-HFW1209CN-LED-0280B"},
                    new Material(margen){ Cantidad=1, Concepto= "Disco Duro Purple de 1 TB / 5400 RPM / Optimizado para Soluciones de Videovigilancia / Uso 24-7 / 3 Años de Garantia",
                    CostoUnitario=785.7m,CodigoMaterial="WD10PURZ"},
                    new Material(margen){ Cantidad=1, Concepto= "NVR 8 Megapixel (4K) (Compatible con Cámaras AcuSense) / 4 Canales IP / 4 Puertos PoE+ / 1 Bahía de Disco Duro / HDMI en 4K",
                    CostoUnitario=1392.37m,CodigoMaterial="NVR-104MH-C/4P(C)"},
                    new Material(margen){ Cantidad=1, Concepto= "Bobina de cable de 305 m, Cat5e, para intemperie, sin blindar, color blanco, UL, para aplicaciones en CCTV, redes de datos.",
                    CostoUnitario=1813.43m,CodigoMaterial="PRO-CAT5-EXT-LITEW"},
                    new Material(margen){ Cantidad=1, Concepto= "Easy Smart Switch PoE JetStream , 8 puertos 10/100/1000 Mbps 55 W",
                    CostoUnitario=1011.78m,CodigoMaterial="TL-SG108PE"},
                    new Material(margen){ Cantidad=1, Concepto= "Gabinete ACTECK PERFORMANCE GI210 Micro Tower Micro ATX Y Mini ITX USB 2.0 Fuente 500W",
                    CostoUnitario=486.17m,CodigoMaterial="AC-929011"},
                    new Material(margen){ Cantidad=1, Concepto= "Extensión Eléctrica De 20 Mts Uso Rudo Naranja Multicontacto",
                    CostoUnitario=600m,CodigoMaterial="https://articulo.mercadolibre.com.mx/MLM-1817394994-extension-electrica-de-20-mts-uso-rudo-naranja-multicontacto-_JM#position=2&search_layout=grid&type=item&tracking_id=b8e7579d-10ba-4376-a05d-a360d88099d4:~:text=Nuevo%20%20%7C%20%204%20vendidos-,Extensi%C3%B3n%20El%C3%A9ctrica%20De%2020%20Mts%20Uso%20Rudo%20Naranja%20Multicontacto,-Favorito"},
                    new ManoObra(margen){Cantidad=2, Concepto="Instalador por día",VentaUnitario=400,DiasTrabajo=2}
                }

            };
            serviciosCRUD.guardar(p);
            Assert.IsNotNull(p.Id);
        }
    }
}