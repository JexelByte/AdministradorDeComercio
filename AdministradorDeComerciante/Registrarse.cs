using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace AdministradorDeComerciante
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Empresa.Text == "")
            {
                Empresa.Focus();
                MessageBox.Show("¡Faltan Datos!");
                return;
            }

            if (Dueño.Text == "")
            {
                Dueño.Focus();
                MessageBox.Show("¡Faltan Datos!");
                return;
            }

            if (Telefono.Text == "")
            {
                Telefono.Focus();
                MessageBox.Show("¡Faltan Datos!");
                return;
            }

            if (Direccion.Text == "")
            {
                Direccion.Focus();
                MessageBox.Show("¡Faltan Datos!");
                return;
            }

            if (usuario.Text == "")
            {
                usuario.Focus();
                MessageBox.Show("¡Faltan Datos!");
                return;
            }

            if (key1.Text == "")
            {
                key1.Focus();
                MessageBox.Show("¡Faltan Datos!");
                return;
            }

            if (key2.Text == "")
            {
                key2.Focus();
                MessageBox.Show("¡Faltan Datos!");
                return;
            }

            if(key1.Text != key2.Text)
            {
                MessageBox.Show("¡Las Contraseñas no coinciden!");
                key1.Text = "";
                key2.Text = "";
                key1.Focus();
                return;
            }
            else
            {
                Empresa a = new Empresa();

                a.Nombre = Empresa.Text;
                a.Dueño = Dueño.Text;
                a.Telefono = Telefono.Text;
                a.Direccion = Direccion.Text;

                a.Usuario = usuario.Text;
                a.Clave = key1.Text;

                a.ListaDivisas = new List<Divisa>();

                Divisa Bs = new Divisa();

                Bs.Nombre = "Bolívares";
                Bs.Logo = "Bs";
                Bs.equivalente = 250000;

                a.ListaDivisas.Add(Bs);

                Random ran = new Random();

                byte[] buffer = new byte[14];
                
                string g = File.ReadAllText("Data/Registro.OKs");

                ListaEmpresas asd = JsonConvert.DeserializeObject<ListaEmpresas>(g);

                bool s = true;

                do
                {
                    s = false;

                    a.id = "";

                    ran.NextBytes(buffer);
                    
                    foreach(char c in buffer)
                    {
                        a.id += c;
                    }

                    foreach (Empresa c in asd.UsuariosTotales)
                    {
                        if (c.id == a.id)
                        {
                            s = true;
                            break;
                        }
                    }

                } while (s);

                foreach (Empresa c in asd.UsuariosTotales)
                {
                    if (c.Usuario == a.Usuario)
                    {
                        MessageBox.Show("¡Este nombre de usuario ya esta en uso!");
                        return;
                    }
                }

                asd.UsuariosTotales.Add(a);

                g = JsonConvert.SerializeObject(asd);
                File.WriteAllText("Data/Registro.OKs", g);

                //transacciones-------------------------------------------
                Transacciones tr = new Transacciones();

                tr.TodasLasCompras = new List<Compra>();
                tr.TodasLasVentas = new List<Venta>();
                tr.id = a.id;

                g = JsonConvert.SerializeObject(tr);
                File.WriteAllText(string.Format("trans/{0}{1}", a.Usuario, ".tr"), g);

                //Stock--------------------------------------------------

                Stock st = new Stock();

                st.ListaDeArticulos = new List<Articulo>();
                st.id = a.id;

                g = JsonConvert.SerializeObject(st);
                File.WriteAllText(string.Format("stock/{0}{1}", a.Usuario, ".st"), g);

                //estatus----------------------------------------------------

                Estatus es = new Estatus();
                es.id = a.id;

                g = JsonConvert.SerializeObject(es);
                File.WriteAllText(string.Format("estatus/{0}{1}", a.Usuario, ".es"), g);

                Application.Restart();
            }
        }
    }
}
