using backend.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizaciones
{
    public partial class NuevoProyecto : Form
    {
        private Proyecto Proyecto;
        public NuevoProyecto()
        {
            InitializeComponent();
            Proyecto = new Proyecto();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha agregado el proyecto", "Atención", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void NuevoProyecto_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtmargen_TextChanged(object sender, EventArgs e)
        {
            Proyecto.Margen = decimal.Parse(txtmargen.Text) / 100;
        }

        private void cmbTipoConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoProducto.Enabled = cmbTipoConcepto.SelectedIndex.Equals(0);
            txtDias.Enabled = !cmbTipoConcepto.SelectedIndex.Equals(0);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTipoConcepto.SelectedIndex.Equals(0))
                Proyecto.ConceptosCotizacion.Add(new Material(Proyecto.Margen)
                {
                    Cantidad = int.Parse(txtCantidad.Text),
                    Concepto = txtConcepto.Text,
                    CostoUnitario = decimal.Parse(txtCostoUnitario.Text),
                    CodigoMaterial = txtCodigoProducto.Text
                });
            if (cmbTipoConcepto.SelectedIndex.Equals(1))
                Proyecto.ConceptosCotizacion.Add(new ManoObra(Proyecto.Margen)
                {
                    Cantidad = int.Parse(txtCantidad.Text),
                    Concepto = txtConcepto.Text,
                    VentaUnitario = decimal.Parse(txtCostoUnitario.Text),
                    DiasTrabajo = int.Parse(txtDias.Text)
                });
            if (cmbTipoConcepto.SelectedIndex.Equals(2))
                Proyecto.ConceptosCotizacion.Add(new Viaticos(Proyecto.Margen)
                {
                    Cantidad = int.Parse(txtCantidad.Text),
                    Concepto = txtConcepto.Text,
                    VentaUnitario = decimal.Parse(txtCostoUnitario.Text),
                    DiasTrabajo = int.Parse(txtDias.Text)
                });
            gridConceptos.DataSource = null;
            gridConceptos.DataSource = Proyecto.ConceptosCotizacion;
            txtCostoMateriales.Text = Proyecto.TotalMateriales.ToString("0.##");
            txtTotalManoObra.Text = Proyecto.TotalManoObra.ToString("0.##");
            txtSubTotal.Text = Proyecto.SubTotalCotizar.ToString("0.##");
            txtTotal.Text = Proyecto.TotalCotizar.ToString("0.##");
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}

