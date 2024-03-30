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
    public partial class frm_progressbar : Form
    {
        //Declaración de variables globales para el formulario
        int Contador=0;

        //Fin de declaración de variables globales para el formulario

        public frm_progressbar()
        {
            InitializeComponent();
        }       

        private void timer1_Tick(object sender, EventArgs e)
        {
            //INCREMENTANDO LA INFORMACIÓN Y MOSTRANDO DENTRO DE LA CAJA DE TEXTO            

            /*
            //Deteniendo el contador al llegar al límite de 100
            if (Contador<100)
            {
                Contador++;

                //Mostrando el valor de contador en el textbox
                txt_contador.Text = Convert.ToString(Contador);

                //Incrementando el progressBar
                //ajustando el progressbar al tiempo de demora
                //progressBar1.Value = Contador;

                //Otra forma de incrementar el progreso del progressBar
                progressBar1.Increment(1);
            
            }
            else
            {
                timer1.Stop();
            }*/

            //-------------------------------------------------------------
            //2DA FORMA DE TRABAJAR CON EL PROGRESSBAR
            if (progressBar1.Value < 100)
            {
                progressBar1.Increment(1);
                txt_contador.Text=progressBar1.Value.ToString();
            }
            else
            {
                timer1.Stop();
            }  
            
            //-------------------------------------------------------------
            /*Bloque antiguo
            //int Contador se declara afuera porque sino reinicia la cuenta
            Contador++;

            txt_contador.Text = Convert.ToString(Contador);*/
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
