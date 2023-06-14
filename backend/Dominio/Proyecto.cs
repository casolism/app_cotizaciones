using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Dominio
{
    public class Proyecto {
        public Proyecto() {
            ConceptosCotizacion = new  List<ConceptoCotizacion>();
        }

        public string Id { get; set; }
        public string NombreProyecto { get; set; }
        public string Descripcion { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public IList<ConceptoCotizacion> ConceptosCotizacion { get; set; }
        public decimal Margen { get; set; }
        public decimal TotalGastos { get {
                return TotalMateriales+TotalManoObra;
            } set { }
        }
        public decimal TotalMateriales {
            get {
                return ConceptosCotizacion.Where(x=>x.ClasificacionCosto.Equals("Materiales")).Sum(x => x.TotalConceptoMostrar) * (1.16m);
            }
            set { }
        }

        public decimal Ganancia {
            get {
                return TotalGastos * Margen;
            }
            set { }
        }
        public decimal TotalManoObra {
            get {
                return ConceptosCotizacion.Where(x => x.ClasificacionCosto.Equals("ManoObra")).Sum(x => x.TotalConcepto);
            }
            set { }
        }
        public decimal TotalCotizar { get {
                return TotalGastos + Ganancia;
            } set { }
        }
        public decimal SubTotalCotizar {
            get {
                return TotalCotizar / (1.16m);
            }
            set { }
        }

        public string Condiciones { get; set; }
        public string Estatus { get; set; }
        public override string ToString()
        {
            return $"Proyecto: {Descripcion}\nCliente:{Cliente.Empresa}\nContacto:{Cliente.Contacto.Nombre} {Cliente.Contacto.Correo}\n" +
                    $"Total costos:{TotalGastos} Total Cotizar: {TotalCotizar}\nDetalle:\n{ConceptosCotizacion}";
        }
    }
}
