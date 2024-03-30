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
    public partial class frm_trabajandoCombobox : Form
    {
        public frm_trabajandoCombobox()
        {
            InitializeComponent();
        }

        private void cmb_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doble clic en el evento SelectedIndexChanged del ComboBox para acceder a aquí

            //Capturando el elemento seleccionado del Combobox y monstrando su posición
            txt_resultado.Text = "Curso Seleccionado: " + cmb_cursos.SelectedItem + " y se encuentra en la posición " + cmb_cursos.SelectedIndex;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //Agregando el nuevo curso al Combobox
            cmb_cursos.Items.Add(txt_nuevo.Text);

            //Limpinado la caja de texto 'txt_nuevo'
            txt_nuevo.Text = "";

            //Mostrando mensaje de registro exitoso
            MessageBox.Show("Curso registrado correctamente");

        }
    }
}
