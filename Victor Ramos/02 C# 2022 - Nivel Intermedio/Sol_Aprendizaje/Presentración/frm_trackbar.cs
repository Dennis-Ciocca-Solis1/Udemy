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
    public partial class frm_trackbar : Form
    {
        public frm_trackbar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Programando el evento scroll
            lbl_porcentaje.Text = "Porcentaje " + trackBar1.Value.ToString() + " %";

        }
    }
}
