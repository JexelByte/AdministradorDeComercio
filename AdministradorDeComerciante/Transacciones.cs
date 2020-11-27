using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeComerciante
{
    class Transacciones
    {
        public List<Venta> TodasLasVentas { get; set; }
        public List<Compra> TodasLasCompras { get; set; }

        public string id { get; set; }
    }
}
