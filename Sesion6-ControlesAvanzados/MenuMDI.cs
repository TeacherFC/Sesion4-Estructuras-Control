using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion6_ControlesAvanzados
{
    public partial class MenuMDI : Form
    {
        public MenuMDI()
        {
            InitializeComponent();
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroCliente().Show();
        }
        private void registrarProductoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            new RegistroProductos().Show();
        }


        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Calendario().Show();
        }

        private void listadoDeOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListadoOpciones().Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
