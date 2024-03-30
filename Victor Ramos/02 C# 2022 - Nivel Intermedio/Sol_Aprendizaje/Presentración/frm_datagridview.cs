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
    public partial class frm_datagridview : Form
    {
        public frm_datagridview()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //PROGRAMANDO EL BOTÓN AGREGAR
            
            //Consultando si los textbox tienen información  para poder agregarlos en el 'DataGridView'
            if (txt_nombres.Text!="" && txt_email.Text!="")
            {
                //Agregando la información de los textbox en el DataGridView
                dgv_datos.Rows.Add(txt_nombres.Text,txt_email.Text);

                //Limpiando los textbox
                txt_nombres.Text = "";
                txt_email.Text = "";

                //Mostrando mensaje
                MessageBox.Show("Datos Agregados Correctamente");

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //PROGRAMANDO EL BOTÓN ELIMINAR

            //Programando un DialogResult (mensaje de confirmación para la eliminación)
            DialogResult Respuesta;

            //Almacenando los botones Yes y No en una variable       //Fórmula (Pregunta, Título del MessageBox,Botones Si o No)
            Respuesta = MessageBox.Show("Está seguro de eliminar la fila seleccionada?","Aviso del Sistema",MessageBoxButtons.YesNo);

            //Verificando si se presionó el botón Si o No y según eso accionar
            if(Respuesta == DialogResult.Yes)
            {
                int nFila;

                //Obteniendo la posición de la fila seleccionada
                nFila = dgv_datos.CurrentRow.Index;

                //Removiendo la información de la fila seleccionada pasándole el índice de la fila seleccionada
                dgv_datos.Rows.RemoveAt(nFila);

                MessageBox.Show("Fila Eliminada Correctamente");
            }

            //----------------------------------------------------------------------------------------------
            /*Eliminando la información del DataGridView
            int nFila;

            //Obteniendo la posición de la fila seleccionada
            nFila = dgv_datos.CurrentRow.Index;

            //Removiendo la información de la fila seleccionada pasándole el índice de la fila seleccionada
            dgv_datos.Rows.RemoveAt(nFila);

            //MessageBox.Show("Fila Eliminada Correctamente");*/
        }

        private void dgv_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //PROGRAMANDO EL EVENTO CELLCLICK DEL DATAGRIDVIEW PARA PODER MODIFICAR UN CAMPO

            //Obteniendo los valores de la fila seleccionada y mostrarlas en los textbox
            txt_nombres.Text = Convert.ToString(dgv_datos.CurrentRow.Cells["Column1"].Value);
                                                        //Column1 es el nombre de la columna dentro del DataGridView

            txt_email.Text = Convert.ToString(dgv_datos.CurrentRow.Cells["Column2"].Value);
        }
    }
}
