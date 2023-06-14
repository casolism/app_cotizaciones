using backend.Dominio;
using backend.Servicios;
using backend.Servicios.Documento;
using backend.Servicios.Documento.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Cotizaciones
{
    public partial class NuevoProyecto : Form
    {
        private Proyecto Proyecto;
        IServiciosCRUD serviciosCRUD;
        private bool ModoEdicion=false;
        public NuevoProyecto(Proyecto proyecto)
        {
            InitializeComponent();
            Proyecto = proyecto;
            serviciosCRUD = new ServiciosCRUD(Program.InitConfiguration);
            cargaDatosProyecto();
            ModoEdicion = true;

        }

        private void cargaDatosProyecto()
        {
            txtNombreProyecto.Text = Proyecto.NombreProyecto;
            txtDescripcion.Text = Proyecto.Descripcion;
            txtmargen.Text = Proyecto.Margen.ToString();
            CargaConceptosCotizacion();
        }

        public NuevoProyecto()
        {
            InitializeComponent();
            Proyecto = new Proyecto();
            serviciosCRUD = new ServiciosCRUD(Program.InitConfiguration);

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
            CargaConceptosCotizacion();
        }

        private void CargaConceptosCotizacion()
        {
            gridConceptos.DataSource = null;
            gridConceptos.DataSource = Proyecto.ConceptosCotizacion;
            txtCostoMateriales.Text = Proyecto.TotalMateriales.ToString("0.##");
            txtTotalManoObra.Text = Proyecto.TotalManoObra.ToString("0.##");
            txtSubTotal.Text = Proyecto.SubTotalCotizar.ToString("0.##");
            txtTotal.Text = Proyecto.TotalCotizar.ToString("0.##");
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Proyecto.Descripcion))
                MessageBox.Show("Debes proporcionar el nombre del proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (ModoEdicion)
                    serviciosCRUD.actualizar(Proyecto);
                else
                    serviciosCRUD.guardar(Proyecto);
                MessageBox.Show("Se ha guardado el proyecto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdVistaPrevia_Click(object sender, EventArgs e)
        {
            Proyecto.Cliente = new Cliente() { Contacto = new Contacto() { Nombre = "A quien Corresponda", Correo = "n/a" }, Empresa = "-" };
            Proyecto.Condiciones = txtCondiciones.Text;
            var documento = new Documento(Proyecto);
            var file = documento.CrearPDF();
            MostrarPDF(file);
        }

        private void MostrarPDF(byte[] pdf)
        {
            var filePDF = @$"{FuncionesPdf.AppPath()}\{Proyecto.Id}.pdf";
            File.WriteAllBytes(filePDF, pdf);
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(filePDF) { UseShellExecute = true };
            p.Start();
        }

        private async void gridConceptos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var concepto = gridConceptos.Rows[e.RowIndex].DataBoundItem as ConceptoCotizacion;
            Proyecto.ConceptosCotizacion[e.RowIndex] = concepto;
            gridConceptos.CellEndEdit -= gridConceptos_CellEndEdit;
            await Task.Delay(1000);
            CargaConceptosCotizacion();
            gridConceptos.CellEndEdit += gridConceptos_CellEndEdit;
        }

        private void gridConceptos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }
    }
}

