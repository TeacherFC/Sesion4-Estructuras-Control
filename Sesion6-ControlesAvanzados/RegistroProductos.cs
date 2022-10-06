using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sesion6_ControlesAvanzados
{
    public partial class RegistroProductos : Form
    {
        public RegistroProductos()
        {
            InitializeComponent();
        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {
            cboTipo.Items.AddRange(
                    new object[] {"Alimento","Medicinal","Limpieza","Seguridad"}
                );
            Limpiar();
        }

        private void Limpiar() {
            txtSKU.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "0.00";
            cboTipo.SelectedItem = 1;
            nudStock.ResetText();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
            MessageBox.Show("Se grabó el producto correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp)";
            if (open.ShowDialog()==DialogResult.OK) {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open2 = new OpenFileDialog();
            open2.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp)";
            if (open2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(open2.FileName);
            }
        }
    }
}
