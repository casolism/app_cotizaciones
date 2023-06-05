namespace backend.Dominio
{
    public class ManoObra : ConceptoCotizacion
    {
        public ManoObra(decimal Margen) : base(Margen) {
        }

        public int DiasTrabajo { get; set; }

        public override decimal TotalConcepto {
            get {
                return Cantidad * VentaUnitario * DiasTrabajo * (1.16m);
            }
        }

        public override string ClasificacionCosto { get => "ManoObra"; }
    }
}