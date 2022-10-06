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
    public partial class ListadoOpciones : Form
    {
        public ListadoOpciones()
        {
            InitializeComponent();
        }

        private void ListadoOpciones_Load(object sender, EventArgs e)
        {
            //Agregar opciones dentro del ComboBox
            this.comboBox1.Items.AddRange(new object[] {"Programación Concurrente",
                        "Estadistica",
                        "Base de Datos"});
            //comboBox1.SelectedIndex = 0;

            //Agregar Items al ListBox
            listBox1.BeginUpdate();
            listBox1.Items.AddRange(new object[] {
                "Programación Concurrente",
                "Estadistica",
                "Base de Datos",
                "Seguridad de la Informacion",
                "Inteligencia Artificial"
            });
            listBox1.EndUpdate();
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            //Agregar Itemns en CheckedListBox
            string[] objLP = {"C#","Java","Python","VB" };
            checkedListBox1.Items.AddRange(objLP);
            checkedListBox1.CheckOnClick = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }
    }
}
