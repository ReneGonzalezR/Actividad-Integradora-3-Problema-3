using System;
using System.Windows.Forms;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>
namespace Actividad_Integradora_3_Problema_3
{
    public partial class Form1 : Form
    {
        Puntuacion punto = new Puntuacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            punto.reiniciarPuntuacion();
            lblResultado.Text = punto.getPuntuacion().ToString();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            punto.sumarPunto();
            lblResultado.Text = punto.getPuntuacion().ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            punto.restarPunto();
            lblResultado.Text = punto.getPuntuacion().ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(punto.getPuntuacion().ToString(), "Puntaje Acumulado");
        }
    }
}
