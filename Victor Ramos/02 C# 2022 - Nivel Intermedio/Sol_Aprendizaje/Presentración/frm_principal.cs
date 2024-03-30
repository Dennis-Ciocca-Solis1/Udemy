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
    public partial class frm_principal : Form
    {     
        //Aquivan todas la variables globales ---------------------------

        //Declarando un objeto de tipo MiPrimerFormulario
        MiPrimerFormulario Frm_01;

        //Declarando un objeto de tipo frm_trackBar
        frm_trackbar Frm_02;

        //Fin la variables globales -------------------------------------

        public frm_principal()
        {
            InitializeComponent();
        }

        private void miPrimerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Le di doble clic en el primer objeto del menu 'Datos Maestros' para llegar aquí

            //-----------------------------------------------------------------------------------
            //Programando que sólo se pueda abrir un formulario sólo una vez
            if (Frm_01 == null)
            {
                //primero hay que declarar la variable afuera
                //Instanciando la variable de tipo formulario
                Frm_01 = new MiPrimerFormulario();

                //Asociando el formulario instanciado con un formulario padre
                Frm_01.MdiParent = this;//este this está haciendo referencia al formulario frm_principal

                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                /*Cuando el formulario esté cerrado, asignandole el evento FormClosedEventHandler con un parámetro que es una función
                que devuelve frm_01 con valor null*/ 
                Frm_01.FormClosed += new FormClosedEventHandler(Alta_frm_01);

                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //LLamando(mostrar) al Formulario Asociado 
                Frm_01.Show();
            }
            else
            {               
                //Enfocando un formulario cuando se encuentre detrás de otro al intertar volver a abrirlo
                Frm_01.Activate();
            }          

            //-----------------------------------------------------------------------------------
            /*
            //primero hay que declarar la variable afuera
            //Instanciando la variable de tipo formulario
            Frm_01 = new MiPrimerFormulario();

            //Asociando el formulario instanciado con un formulario padre
            Frm_01.MdiParent = this;//este this está haciendo referencia al formulario frm_principal

            //LLamando(mostrar) al Formulario Asociado 
            Frm_01.Show();*/

        }

        //------------------------------------------------------------------------------
        //Creando un evento que permite abrir un formulario que fue cerrado previamente
        void Alta_frm_01(object sender, EventArgs e)
        {
            Frm_01 = null;
        }
        //------------------------------------------------------------------------------

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aquí se aplica lo mismo que en los demás formularios

            if (Frm_02 == null)
            {                
                Frm_02 = new frm_trackbar();
                
                Frm_02.MdiParent = this;
                
                Frm_02.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                
                Frm_02.Show();
            }
            else
            {                
                Frm_02.Activate();
            }

        }

        void Alta_frm_02(object sender, EventArgs e)
        {
            Frm_02 = null;
        }

    }
}
