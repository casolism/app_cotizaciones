using backend.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizaciones
{
    public partial class frmConsultaProyectos : Form
    {
        public static Proyecto ProyectoActual;
        private IList<Proyecto> proyectos;
        public frmConsultaProyectos()
        {
            InitializeComponent();
            proyectos = frmSistemaCotizaciones.serviciosCRUD.obtener<Proyecto>();
            gridProyectos.DataSource = proyectos.ToArray();
        }

        private void gridProyectos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProyectoActual = proyectos[e.RowIndex];
            var newMDIChild = new NuevoProyecto(ProyectoActual);
            newMDIChild.MdiParent = this.MdiParent;
            newMDIChild.Show();
        }
    }
}
