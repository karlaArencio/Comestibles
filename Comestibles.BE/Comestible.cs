using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comestibles.BE
{
    public class Comestible
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Cantidad { get; set; }

        public string Stock()
        {
            string respuesta = Nombre
                               + " - "
                               + Codigo
                               + " - "
                               + Cantidad.ToString();

            return respuesta;
        }


    }
}
