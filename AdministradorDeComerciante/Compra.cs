using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeComerciante
{
    class Compra
    {
        public DateTime fecha { get; set; }
        public float MontoTotal { get; set; }
        public List<Articulo> LAComprados { get; set; }

        public string NombreProveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public string TlfProveedor { get; set; }
        public string Descripcion { get; set; }
        public Divisa Divisa { get; set; }
    }
}
