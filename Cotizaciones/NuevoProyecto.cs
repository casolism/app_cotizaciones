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
    public partial class NuevoProyecto : Form
    {
        public NuevoProyecto()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha agregado el proyecto","Atención",MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
