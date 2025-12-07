using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o'; //inicializado a o para que por defecto sea ordinario
            int numPalabras = 0;
            double coste;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
           
            // telegrama urgente?
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            
            //Obtengo el número de palabras que forma el telegrama
           //correccion lenght contaba caracteres. Usamos split para contar palabras
            numPalabras = textoTelegrama.Split('o').Length;
           
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                   //correccion:la formula correcta es base + 0.5 por cada palabra EXTRA
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";

        }
    }
}
