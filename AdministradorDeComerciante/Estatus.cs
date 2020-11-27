using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace AdministradorDeComerciante
{
    class Estatus
    {
        public Stock Todo { get; set; }
        public float capital { get; set; }

        public float GanaciaEstimada { get; set; }

        public float Stock { get; set; }
        public float seguro { get; set; }
        public float Volatil { get; set; }
        
        public float MontoVentas { get; set; }

        public string id { get; set; }
        
        public float CapitalEnDivisas(string us)
        {
            string cargar = File.ReadAllText("trans/" + us + ".tr");
            Transacciones tr = JsonConvert.DeserializeObject<Transacciones>(cargar);

            float h = 0;

            foreach(Venta c in tr.TodasLasVentas)
            {
                foreach(Articulo a in c.LAVendidos)
                {
                    h += a.PrecioCompra;
                }
            }

            h = (capital * h) / 100;
            
            return h;
        }

        public float montoInventario(string us)
        {
            string cargar = File.ReadAllText("stock/" + us + ".st");
            Stock st = JsonConvert.DeserializeObject<Stock>(cargar);
            
            return st.MontoTotal();
        }
    }
}
