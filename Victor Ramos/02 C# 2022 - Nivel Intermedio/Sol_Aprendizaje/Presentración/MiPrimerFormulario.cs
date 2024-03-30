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
    public partial class MiPrimerFormulario : Form
    {
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        //INICIO DE MIS VARIABLES
        //Identificará si se está guardando un elemento nuevo o sólo se está actualizando el elemento
        int NestadoGuarda = 0; //es sólo una declaración global

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Asignandole un valor a la variable NestadoGuarda
            NestadoGuarda = 1; //cuando NestadoGuarda tenga valor de 1 es un nuevo registro

            //Inactivando la lista al darle clic en el botón 'nuevo'
            lst_mantenimiento.Enabled = false;

            //Limpiar cajas de texto
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            /*----------------------------------------------------------
            //Habilitando los textbox desabilitados previamente en diseño
            txt_codigo.Enabled=true; 
            txt_descripcion.Enabled=true;

            //Haciendo Visibles los botones con propiedad Visible:false
            btn_cancelar.Visible = true;
            btn_guardar.Visible = true;*/

            //Habilitando un GroupBox en vez de cada elemento por separado
            grb_mantenimiento.Enabled = true;

            //Habilitando el textbox codigo luego de actualizar
            txt_codigo.Enabled = true;

            //------------------------------------------------------------
            /*Desabilitando los botones luego de dar clic en nuevo
            btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_reporte.Enabled = false;
            btn_salir.Enabled = false;*/

            //Desabilitando los botones principales con un GroupBox
            grb_botones_principales.Enabled = false;

            //---------------------------------------------------------------

            //Enfocando cursos
            txt_codigo.Focus();

            //otra forma
            //txt_codigo.Select();

            //Otras Propiedades del Panel de Propiedades
            //Tab Index: Ordena el orden de la tabulación
            //Enabled: false (desabilita el botón)
            //MaxLength: Determina el máximo de caracteres permitidos    

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Limpiando cajas
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            /*-----------------------------------------------------------------------------
            //Desabilitando Cajas
            txt_codigo.Enabled=false;
            txt_descripcion.Enabled = false;

            //Escondiendo botones 'Cancelar' y 'Guardar' luego de darle clic en 'Cancelar'
            btn_cancelar.Visible = false;
            btn_guardar.Visible=false;*/

            //Desabilitando el GroupBox 'Mantenimiento'
            grb_mantenimiento.Enabled = false;

            //-----------------------------------------------------------------------------

            /*Habilitando los botones luego de dar clic en 'Cancelar'
            btn_nuevo.Enabled = true;
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_reporte.Enabled = true;
            btn_salir.Enabled = true;*/

            //Habilitando los botones principales luego de dar clic en 'Cancelar', pero con un GroupBox
            grb_botones_principales.Enabled = true;

            //Activando la lista al darle clic en el botón 'cancelar'
            lst_mantenimiento.Enabled = true;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Anadiendo información en el ListBox
            string Registro;

            Registro = txt_codigo.Text.Trim() + " | " + txt_descripcion.Text.Trim();

            //-----------------------------------------------------------------------
            //ESTIPULANDO SI SE ESTÁ ACTUALIZANDO O GUARDANDO UN NUEVO REGISTRO
            if (NestadoGuarda == 1) //Escenario de Guardando Nuevo Registro
            {
                lst_mantenimiento.Items.Add(Registro);
            }
            else //Escenario de Actualizando Registro
            {
                //Capturando la posición del elemento seleccionado en una variable
                int ElementoSeleccionado = lst_mantenimiento.SelectedIndex;                            

                //Eliminando item seleccionado de la lista
                lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);

                //Agregando el elemento actualizado en la misma posición que estaba antes de eliminarlo
                lst_mantenimiento.Items.Insert(ElementoSeleccionado, Registro); //Registro tiene la información de las 2 cajas de texto
                //ElementoSeleccionado es la posición de elemento seleccionado
            }

            //-----------------------------------------------------------------------

            //lst_mantenimiento.Items.Add(Registro); //esto era cuando no estaba configurado para guardar nuevo o actualizar
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Mostrando mensaje de 'Guardado Correctamente'
            MessageBox.Show("Datos Guardados Correctamente");

            //Limpiando cajas al terminar de guardar
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            //Desabilitando el GroupBox 'Mantenimiento' luego de dar clic en 'Guardar'
            grb_mantenimiento.Enabled = false;

            //Habilitando los botones principales luego de dar clic en 'Guardar'
            grb_botones_principales.Enabled = true;

            //Activando la lista al darle clic en el botón 'guardar'
            lst_mantenimiento.Enabled = true;

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //Eliminando item seleccionado de la lista
            lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);

            //Mostrando mensaje de 'Eliminado Correctamente'
            MessageBox.Show("Elemento Eliminado Correctamente");
        }

        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            //MOSTRANDO EL ELEMENTO DEL LISTBOX SELECCIONADO DE LOS TEXTBOX            
            string TextoSeleccionado;
            int LongitudTexto;           

            //Almacenando el contenido del elemento seleccionado en una variable
            TextoSeleccionado = this.lst_mantenimiento.SelectedItem.ToString().Trim();
                            //this hace que aunque se instancie al formulario, se sigue refiriendo a este formulario

            //Mostrando en un MessageBox el texto del elemento seleccionado
            //MessageBox.Show(TextoSeleccionado);

            //Obtener la longitud del texto seleccionado
            LongitudTexto = TextoSeleccionado.Length;

            //Retornando la información al textbox codigo
            txt_codigo.Text = TextoSeleccionado.Substring(0, 3); //seleccionado desde la posición 0, 3 elementos

            //Retornando la información al textbox descripcion
            txt_descripcion.Text = TextoSeleccionado.Substring(6, LongitudTexto-6);
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //Asignandole un valor a la variable NestadoGuarda
            NestadoGuarda = 2; //cuando NestadoGuarda tenga valor de 2 está actualizando

            //---------------------------------------------------------------
            //Habilitando un GroupBox en vez de cada elemento por separado
            grb_mantenimiento.Enabled = true;

            //Inactivando la lista al darle clic en el botón 'actualizar'
            lst_mantenimiento.Enabled = false;

            //Desabilitando el textbox codigo
            txt_codigo.Enabled = false;

            //Desabilitando los botones principales con un GroupBox
            grb_botones_principales.Enabled = false;

            //---------------------------------------------------------------

            //Enfocando cursos
            txt_codigo.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
