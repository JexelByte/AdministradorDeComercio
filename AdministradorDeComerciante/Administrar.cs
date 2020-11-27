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
    public partial class Administrar : Form
    {
        public Empresa em;
        Estatus es;
        public Administrar()
        {
            InitializeComponent();
        }

        private void actualizar()
        {
            dollar.Text = em.ListaDivisas[0].equivalente.ToString();

            string cargar = File.ReadAllText("estatus/" + em.Usuario + ".es");

            es = JsonConvert.DeserializeObject<Estatus>(cargar);

            capital.Text = (es.seguro + es.Volatil).ToString();

            Nem.Text = em.Nombre;

            Dueño.Text = em.Dueño;

            tlf.Text = em.Telefono;

            Direc.Text = em.Direccion;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            float price = 0;

            if (dollar.Text != em.ListaDivisas[0].equivalente.ToString())
            {
                try
                {
                    price = float.Parse(dollar.Text);
                }
                catch (Exception)
                {
                    dollar.Text = "";
                    dollar.Focus();
                    return;
                }
            }
            else
            {
                return;
            }

            es.Volatil = es.Volatil * em.ListaDivisas[0].equivalente;
            es.Volatil /= price;

            em.ListaDivisas[0].equivalente = price;
        }

        private void guardar()
        {
            string car = File.ReadAllText("Data/Registro.OKs");

            ListaEmpresas Le = JsonConvert.DeserializeObject<ListaEmpresas>(car);

            foreach (Empresa c in Le.UsuariosTotales)
            {
                if (c.id == em.id)
                {
                    em.Clave = c.Clave;

                    Le.UsuariosTotales.Remove(c);
                    Le.UsuariosTotales.Add(em);

                    break;
                }
            }

            car = JsonConvert.SerializeObject(Le);
            File.WriteAllText("Data/Registro.OKs", car);

            em.Clave = null;

            car = JsonConvert.SerializeObject(es);
            File.WriteAllText("estatus/" + em.Usuario + ".es", car);

            actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void Administrar_DockChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (capital.Text != es.capital.ToString())
            {
                try
                {
                    if (float.Parse(capital.Text) > es.seguro + es.Volatil)
                    {
                        es.seguro += float.Parse(capital.Text) - (es.seguro + es.Volatil);
                    }
                    else if (float.Parse(capital.Text) < es.Volatil)
                    {
                        es.Volatil -= (es.seguro + es.Volatil) - float.Parse(capital.Text);
                    }
                    else
                    {
                        float a = (es.seguro + es.Volatil) - float.Parse(capital.Text);

                        a -= es.Volatil;

                        es.Volatil = 0;

                        es.seguro -= a;

                    }
                }
                catch (Exception)
                {
                    capital.Text = "";
                    capital.Focus();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string car = File.ReadAllText("Data/Registro.OKs");

            ListaEmpresas Le = JsonConvert.DeserializeObject<ListaEmpresas>(car);

            foreach (Empresa c in Le.UsuariosTotales)
            {
                if (c.id == em.id)
                {
                    if (c.Clave == textBox3.Text)
                    {
                        File.Delete("estatus/" + em.Usuario + ".es");
                        File.Delete("stock/" + em.Usuario + ".st");
                        File.Delete("trans/" + em.Usuario + ".tr");

                        Le.UsuariosTotales.Remove(c);

                        car = JsonConvert.SerializeObject(Le);
                        File.WriteAllText("Data/Registro.OKs", car);

                        Application.Restart();
                    }
                    else
                    {
                        return;
                    }
                }
            }

            guardar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            em.Nombre = Nem.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            em.Dueño = Dueño.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            em.Telefono = tlf.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            em.Direccion = Direc.Text;
        }
    }
}
