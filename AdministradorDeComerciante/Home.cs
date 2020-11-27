using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace AdministradorDeComerciante
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public Empresa em { get; set; }

        private Transacciones tr;

        private Estatus es;

        private void Home_DockChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            string cargar = File.ReadAllText("trans/" + em.Usuario + ".tr");
            tr = JsonConvert.DeserializeObject<Transacciones>(cargar);

            cargar = File.ReadAllText("estatus/" + em.Usuario + ".es");
            es = JsonConvert.DeserializeObject<Estatus>(cargar);
            
            if(es.GanaciaEstimada > 0)
            {
                int a = Convert.ToInt32((es.MontoVentas / es.GanaciaEstimada) * 100);

                if(a > 100)
                {
                    Ganancias.Value = 100;
                    Ganancias.Text = "100";
                }
                else
                {
                    Ganancias.Value = a;
                    Ganancias.Text = a.ToString();
                }
            }

            if(es.capital > 0)
            {
                int a = Convert.ToInt32((es.Stock / es.capital) * 100);
                Capital.Value = a;
                Capital.Text = a.ToString();

                a = Convert.ToInt32((es.Volatil / es.capital) * 100);
                Volatil.Value = a;
                Volatil.Text = a.ToString();

                a = Convert.ToInt32((es.seguro / es.capital) * 100);
                Seguro.Value = a;
                Seguro.Text = a.ToString();
            }

            PrecioDolar.Text = string.Format(em.ListaDivisas[0].equivalente.ToString() + " " + em.ListaDivisas[0].Logo);

            List<estadisticaHome> ss = new List<estadisticaHome>();

            estadisticaHome h = new estadisticaHome();

            foreach (Venta c in tr.TodasLasVentas)
            {
                if(ss.Count < 1)
                {
                    h.fecha = c.Fecha;
                    h.monto = c.MontoTotal;
                    continue;
                }
                else
                {
                    if(h.fecha == c.Fecha)
                    {
                        h.monto += c.MontoTotal;
                    }
                    else
                    {
                        ss.Add(h);
                        h.fecha = c.Fecha;
                        h.monto = c.MontoTotal;
                        continue;
                    }
                }
            }

            ss.Add(h);

            foreach (estadisticaHome c in ss)
            {
                chart1.Series["ChartData"].Points.AddXY(c.fecha, c.monto);
            }
            
            es.capital = es.montoInventario(em.Usuario) + es.Volatil;

            es.capital += es.seguro;

            Capital.Text = Convert.ToInt32(es.capital).ToString();
            Capital.Value = 100;

            if(es.capital == 0)
            {
                return;
            }

            Volatil.Value = Convert.ToInt32((es.Volatil / es.capital) *100);
            Volatil.Text = Volatil.Value.ToString();

            Seguro.Value = Convert.ToInt32((es.seguro / es.capital) *100);
            Seguro.Text = Seguro.Value.ToString();
        }
    }
}
