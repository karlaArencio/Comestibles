using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comestibles.BE
{
    public class StockComestibles
    {
        public Comestible[] Stock { get; set; } = new Comestible[3];

        public int fila = 0;

        public void AgregarComestible(Comestible dato)
        {
            Stock[fila] = dato;
            fila = fila + 1;

        }

        public string Control()
        {
            string respuesta = "";

            foreach (Comestible item in Stock)
            {
                if (item == null)
                {
                    break; 
                }
       
                respuesta = respuesta + item.Stock() + "\r\n";
            } 

            return respuesta;
        }

        public Comestible BuscarComestible(string codigo)
        {
            Comestible Comes = new Comestible();
            foreach (Comestible item in Stock)
            {
                if (item == null)
                {
                    break;
                }
                if (item.Codigo == codigo)
                {
                    Comes = item;
                    break;
                }
                 
            }
            return Comes; //cuando el codigo no lo encuentre va ser nulo
        }   

    }    
}
