using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_snake
{
    public partial class La_Culebrita : Form
    {
        Culebra oCulebra;
        public La_Culebrita()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            oCulebra = new Culebra(pictureBox1, labelPuntos);
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!oCulebra.GameOver)
            {
                oCulebra.Next();
                oCulebra.Show();
            }
            else
            {
                timer1.Enabled=false;
                MessageBox.Show("Perdiste, vuelve a intentarlo");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                oCulebra.DireccionActual = Culebra.Direccion.arriba;
            if (e.KeyCode == Keys.D)
                oCulebra.DireccionActual = Culebra.Direccion.derecha;
            if (e.KeyCode == Keys.S)
                oCulebra.DireccionActual = Culebra.Direccion.abajo;
            if (e.KeyCode == Keys.A)
                oCulebra.DireccionActual = Culebra.Direccion.izquierda;
        }
    }
}
