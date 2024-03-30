using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8. Importar librerías
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    //9. Cambiar la clase a modo público: de internal a public class D_Categorias
    public class D_Categorias
    {
        //10.Creando un método que lista la información
        //método que consulta la información con la BD y la trae a C#
        public DataTable Listar_ca(string cTexto)//pide un parámetro porque mi P. Almacenado tiene un parámetro
        {
            //Va a recepcionar la información que venga del SQL Server
            SqlDataReader Resultado;

            //Instanciando una variable DataTable que almacenará la información guardada en Resultado
            DataTable MiTabla = new DataTable();

            //Armando la Conectividad
            SqlConnection SqlCon = new SqlConnection();

            //Creando una interacción de datos
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("usp_listado_ca", SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@cTexto",SqlDbType.VarChar).Value = cTexto;

                SqlCon.Open();

                Resultado = Comando.ExecuteReader();

                MiTabla.Load(Resultado);

                return MiTabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //En 'finally' se programa el cierre de la coenxión a la BD
                if (SqlCon.State==ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

        }

        //11. Haciendo que la capa Negocio pueda consumir el método Listar_ca
        //clic derecho en la capa Negocio/Agregar/Nuevo Elemento/Clase/nombrarla N_Categorias e ir

    }
}
