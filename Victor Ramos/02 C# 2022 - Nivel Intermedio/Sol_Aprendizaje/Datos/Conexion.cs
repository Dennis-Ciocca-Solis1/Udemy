using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//0. CREANDO LA CADENA DE CONEXIÓN A LA BD

//1. Importar librerías
using System.Data.SqlClient;

namespace Datos
{
    internal class Conexion
    {
        //2. Declarar variables privadas de 'Datos'
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        //3. Asignando valores a las variables en el constructor
        private Conexion()
        {                        
            this.Base = "MiBaseDatos";
            this.Servidor = "PC-NESS";
            this.Usuario = "sa";
            this.Clave = "sql";

        }

        //4. Creando el método SqlConnection para la comunicación con el servidor de base de datos
        public SqlConnection CrearConexion()
        {
            //Instanciando una variable que lleve el tipo de información SqlConnection
            SqlConnection Cadena = new SqlConnection();

            //Asignandole a 'Cadena' la información que se necesita para poder conectarse a una base de datos 
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database= " + this.Base + "; User Id=" + this.Usuario + "; Clave=" + this.Clave;

            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }

            //Retornar el resultado de la variable 'Cadena'
            return Cadena;
        }

        //5. Evaluando forma de conexión
        public static Conexion GetInstancia()
        {
            if (Con==null)
            {
                Con = new Conexion();
            }

            return Con;
        }

    }

    //6. Crear las tablas en la BD, ir al script video29

    //7. Agregar una clase a nuestra capa Datos llamada D_Categorias e ir
    

}
