using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empleados.Models
{
    public class Vacunas
    {
        public  int edad { get; set; }

        public string Rangos()
        {
            string mensaje = "";

            if(edad>=3 && edad <= 12)
            {
                mensaje = "Eres un niño chamo";
            }else if (edad>=13 && edad<=25)
            {
                mensaje = "eres un joven";

            }else if (edad > 25)
            {
                mensaje = "Ya esta viejo";
            }
            return mensaje;
        }


        public string Mes()
        {
            string mensaje = "";

            if (edad>=3 && edad<=12)
            {
                mensaje = "Marzo";

            }else if(edad>=13 && edad <= 25)
            {
                mensaje = "Abril";
            }else if (edad>=25)
            {
                mensaje = "Mayo";
            }
            else
            {
                mensaje = "No aplicas";
            }
            return mensaje;
        }
    }
}