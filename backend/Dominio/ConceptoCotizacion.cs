using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Dominio
{
    [BsonKnownTypes(typeof(Material))]
    [BsonKnownTypes(typeof(ManoObra))]
    [BsonKnownTypes(typeof(Viaticos))]
    public abstract class ConceptoCotizacion
    {
        public decimal Margen { get; set; }
        public int Cantidad { get; set; }
        public string Concepto { get; set; }
        public virtual decimal VentaUnitario { get; set; }
        public abstract string ClasificacionCosto { get; }
        public ConceptoCotizacion(decimal Margen)
        {
            this.Margen = Margen;
        }
        public virtual decimal TotalConcepto
        {
            get
            {
                return Cantidad * VentaUnitario;
            }
        }
        public override string ToString()
        {
            return $"Concepto: {Concepto} Cantidad: {Cantidad} Unitario: {VentaUnitario}";
        }
    }
}
