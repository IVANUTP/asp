using Empleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empleados
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Vacunas va = new Vacunas();
            try
            {


                va.edad = Convert.ToInt16(TextBox1.Text);

                Label1.Text = Convert.ToString(va.Rangos());
                Label2.Text = Convert.ToString(va.Mes());
            }
            catch
            {
                TextBox1.Focus();
              
            }
        }
    }
}