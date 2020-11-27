using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeComerciante
{
    class Venta
    {
        public DateTime Fecha { get; set; }
        public float MontoTotal { get; set; }
        public List<Articulo> LAVendidos { get; set; }
    }
}
