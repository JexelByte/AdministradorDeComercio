using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorDeComerciante
{
    class Articulo
    {
        public string nombre { get; set; }
        public string Tipo { get; set; }
        public string descripcion { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public Keys AcesoRapido { get; set; }
        public DateTime FechaExpiracion { get; set; }
    }
}
