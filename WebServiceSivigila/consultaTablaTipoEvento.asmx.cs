using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//librerias para conectarnos a datos utilizando AD=
using System.Data;
using System.Data.SqlClient;

namespace WebServiceSivigila
{
    /// <summary>
    /// Descripción breve de consultaTablaTipoEvento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class consultaTablaTipoEvento : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        //Método del web service para obtener los datos de la tabla

        [WebMethod]
        //retornamos un data set
        public DataSet GetData()
        {
            //creamos un objeto para conexión de bases de datos
            SqlConnection con = new SqlConnection();
            //String de Datos de conexión al servidor de bases de datos
            con.ConnectionString = "Data Source=DESKTOP-R3GF3UI; Initial Catalog=Sivigila; Persist Security Info=True;Integrated Security=SSPI;";
            //adaptador donde indico la consulta que quiero y el objeto de conexion
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TablaTipoEvento",con);
            //creamos un data set que almacene la consulta que se pide a través del adaptador
            DataSet ds = new DataSet();
            //con el data adapter lleno el dataset
            da.Fill(ds);
            //returnará la consulta de la tablaTipoEvento de la BD sivigila
            return ds;

            //el consumo del webservices lo hacemos en otro proyecto

        }

    }
}
