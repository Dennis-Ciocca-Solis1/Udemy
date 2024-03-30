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
    public partial class frm_numericupdown : Form
    {
        public frm_numericupdown()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //Fijar en DataBindings el límite mínimo y máximo del NumericUpDown

            //Obteniendo el valor seleccionado del NumericUpDown
            decimal Nrodia;
            Nrodia = num_nrodia.Value;

            //montrando que valor he seleccionado
            //MessageBox.Show("Dato " + Nrodia);

            //Declarando variable que alamcenará el texto del día de la semana
            string DiaTexto="";

            //Preguntando el caso del número de día seleccionado
            switch(Nrodia)
            {
                case 1:
                    DiaTexto = "Lunes";                    
                    break;

                case 2:
                    DiaTexto = "Martes";                    
                    break;

                case 3:
                    DiaTexto = "Miércoles";                    
                    break;

                case 4:
                    DiaTexto = "Jueves";                    
                    break;

                case 5:
                    DiaTexto = "Viernes";                    
                    break;

                case 6:
                    DiaTexto = "Sábado";                    
                    break;

                default:
                    DiaTexto = "Domingo";                    
                    break;
            }//Fin Switch

            txt_resultado.Text = DiaTexto;

        }
    }
}
