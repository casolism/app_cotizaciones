namespace backend.Dominio
{
    public class Viaticos :ConceptoCotizacion {
        public Viaticos(decimal Margen) : base(Margen)
        {
        }
        public int DiasTrabajo { get; set; }
        public override decimal TotalConcepto {
            get {
                return Cantidad * VentaUnitario * DiasTrabajo * (1.16m);
            }
        }
        public override string ClasificacionCosto { get => "Viáticos"; }

    }
}