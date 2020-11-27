using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorDeComerciante
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Dueño { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public string Usuario { get; set; }
        public string Clave { get; set; }

        public List<Divisa> ListaDivisas { get; set; }

        public string id { get; set; }
    }
}
