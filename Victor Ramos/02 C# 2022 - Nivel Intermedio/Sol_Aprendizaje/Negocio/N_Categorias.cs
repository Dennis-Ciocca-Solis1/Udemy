using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//importar
using System.Data;
using Datos;

namespace Negocio
{
    //cambiar a public

    //internal class N_Categorias
    public class N_Categorias
    {
        //12. Listar 
        public static DataTable Listar_ca(string xTexto)
        {
            D_Categorias Datos = new D_Categorias();

            return Datos.Listar_ca(xTexto);
        }

        //13. Generar este proceso en la capa Presentación(en los formularios) e ir a

    }
}
