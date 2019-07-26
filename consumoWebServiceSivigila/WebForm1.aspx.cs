using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consumoWebServiceSivigila
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //por lo que hicimos con el servicio, obj devolverá un dataset
            SivigilaWS_TablaTipoEvento.consultaTablaTipoEvento obj = new SivigilaWS_TablaTipoEvento.consultaTablaTipoEvento();
            //vinculamos el dataset que retorna obj mediante GetData() al GridView1
            GridView1.DataSource = obj.GetData();
            //Desplegamos los datos en el grid medante DataBind()M
            GridView1.DataBind();

            //es necesario establecer este proyecto y el formulario como proyecto y página de inicio
        }
    }
}