using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Animal liebre = new Liebre();
        Animal tortuga = new Tortuga();

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            {
                string cadena1 = "";
                string cadena2 = "";
                int y = 0;
                int x = 0;
                while (liebre.posicion <= 80 && tortuga.posicion <= 80)
                {
                    liebre.posicion += liebre.Correr();
                    tortuga.posicion += tortuga.Correr();
                    cadena1 += tortuga.posicion + "\r\n";
                    cadena2 += liebre.posicion + "\r\n";
                }
                lblTortuga.Text = cadena1;
                lblLiebre.Text = cadena2;

                if (tortuga.posicion>= 80 && tortuga.posicion < 80)
                    lblGanador.Text = "Gano la tortuga " + tortuga.posicion;
                else
                    lblGanador.Text = "Gano la liebre " + liebre.posicion;

                if (liebre.posicion >= 80 && tortuga.posicion >= 80)
                    lblGanador.Text = "Empate";
            }
        }
    }
}
