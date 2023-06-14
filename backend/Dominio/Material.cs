namespace backend.Dominio
{
    public class Material : ConceptoCotizacion
    {
        public Material(decimal Margen) : base(Margen)
        {
        }
        public string Unidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public string CodigoMaterial { get; set; }
        public override string ClasificacionCosto { get => "Materiales"; }
        public override decimal VentaUnitario { get {
                return CostoUnitario;
            } set { 
                CostoUnitario = value;
            }
        }
        public override decimal UnitarioMostrar 
        {
            get
            {
                return CostoUnitario*(1+Margen);
            }
        }
    }
}