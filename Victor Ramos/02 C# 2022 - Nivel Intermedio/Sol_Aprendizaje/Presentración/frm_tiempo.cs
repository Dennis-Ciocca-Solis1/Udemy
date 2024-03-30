using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentración
{
    public partial class frm_tiempo : Form
    {
        //Declaración de variables globales para el formulario
        int Contador=0;

        //Fin de declaración de variables globales para el formulario

        public frm_tiempo()
        {
            InitializeComponent();
        }       

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Incrementando la información y mostrando dentro de la caja de texto

            //int Contador se declara afuera porque sino reinicia la cuenta

            Contador++;

            txt_contador.Text = Convert.ToString(Contador);
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            timer1.Stop();           
        }
    }
}
