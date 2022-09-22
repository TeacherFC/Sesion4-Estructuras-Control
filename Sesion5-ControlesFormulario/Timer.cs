using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion5_ControlesFormulario
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void IntializeTimer() {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            button1.Text = "Parar";
            button1.Click += new EventHandler(button1_Click);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Parar")
            {
                button1.Text = "Iniciar";
                timer1.Enabled = false;
            }
            else
            {
                button1.Text = "Parar";
                timer1.Enabled = true;
            }
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }
    }
}
