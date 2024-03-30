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
    public partial class frm_encuesta : Form
    {
        public frm_encuesta()
        {
            InitializeComponent();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            string Resultado;
            Resultado = "";

            //VERIFICANDO SI CHECKBOX ESTÁ CHEQUEADO
            if(chk_vfp.Checked==true) 
            {
                //Resultado = Resultado + chk_vfp.Text;
                Resultado += chk_vfp.Text+ ", "; //creando una separación entre objetos

            }

            if(chk_csharp.Checked==true) 
            {
                Resultado += chk_csharp.Text + ", ";
            
            }

            if(chk_vbnet.Checked==true) 
            {
                Resultado += chk_vbnet.Text + ", ";
                            
            }

            if(chk_java.Checked==true) 
            {
                Resultado += chk_java.Text;

            }

            //MOSTRANDO EL VALOR SELECCIONADO DE LOS RADIOBUTTON
            if(rdb_presencial.Checked==true) 
            {
                Resultado += " ::::: " + rdb_presencial.Text + " ::::: ";
            }
            else
            {
                Resultado += " ::::: " + rdb_virtual.Text + " ::::: ";
            }

            //MONSTRANDO EL RESULTADO DE LOS CHECKBOX y RADIOBUTTON CHEQUEADOS
            txt_resultado.Text = Resultado;  

        }
    }
}
