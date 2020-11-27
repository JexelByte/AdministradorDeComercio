using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeComerciante
{
    class Stock
    {
        public List<Articulo> ListaDeArticulos { get; set; }

        public float MontoTotal()
        {
            float a = 0;

            foreach(Articulo c in ListaDeArticulos)
            {
                a += c.PrecioVenta * c.Cantidad;
            }

            return a;
        }

        public float ganacia()
        {
            float a = 0;

            foreach(Articulo c in ListaDeArticulos)
            {
                a += c.PrecioVenta * c.Cantidad;
            }

            a = a - MontoTotal();

            return a;
        }
        
        public string id { get; set; }
    }
}
