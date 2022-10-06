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
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            //Agregar tipos de documentos en el cboTipoDocu
            cboTipoDocu.Items.AddRange(new object[] {
                "DNI",
                "Carnet Extranjeria",
                "RUC"
            });

            //Rango de Fechas de dtFecNac
            dtFechaNac.MinDate = new DateTime(1920,01,01);
            dtFechaNac.MaxDate = new DateTime(2004, 12, 31);
            dtFechaNac.Value = new DateTime(2004,12,31);

            //Agregar Distrito en lstDistrito
            string[] objDistrito = { "Los Olivos","Carabayllo","Magdalena del Mar","El Agustino","San Martin de Porres","La Victoria",""};
            lstDistrito.Items.AddRange(objDistrito);
            LimpiarForm();
        }

        private void LimpiarForm() {

            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtNumDocu.Text = "";
            cboTipoDocu.SelectedIndex = 0;
            lstDistrito.SelectedIndex = 0;
            dtFechaNac.Value = new DateTime(2004,01,01);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Correcto");
            LimpiarForm();
        }
    }
}
