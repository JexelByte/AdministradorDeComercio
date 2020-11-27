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
    public partial class Comprar : Form
    {
        public Empresa em;

        Stock st;

        Articulo seleccionado;

        Estatus es;

        float Fondos = 0;

        public Comprar()
        {
            InitializeComponent();

            seleccionado = new Articulo();
        }

        private void Comprar_DockChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            string cargar = File.ReadAllText("stock/" + em.Usuario + ".st");
            st = JsonConvert.DeserializeObject<Stock>(cargar);

            if (st.id != em.id)
            {
                MessageBox.Show("archivo dañado!");
                return;
            }

            Lista.Items.Clear();

            foreach (Articulo c in st.ListaDeArticulos)
            {
                Lista.Items.Add(c.nombre);
            }

            seleccionado = new Articulo();
            seleccionado.Cantidad = 0;

            Nombre.Text = "";
            Tipo.Text = "";
            descripcion.Text = "";

            Nombre.Enabled = true;
            Tipo.Enabled = true;

            precioCo.Text = "";
            precioVe.Text = "";
            cantidad.Text = "";

            richTextBox1.Text = "";
            

            cargar = File.ReadAllText("estatus/" + em.Usuario + ".es");
            es = JsonConvert.DeserializeObject<Estatus>(cargar);

            Fondos = es.seguro + es.Volatil;
            label2.Text = Fondos.ToString();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Articulo c in st.ListaDeArticulos)
            {
                if (c.nombre == Lista.Text)
                {
                    seleccionado = c;
                    richTextBox1.Text = "Nombre: " + c.nombre + "\n\n" + "Tipo: " + c.Tipo + "\n\n" + "Descripcion: "
                        + c.descripcion + "\n\n" + "Precio Unidad: " + c.PrecioVenta * em.ListaDivisas[0].equivalente + "\n\n" + "Cantidad: " + c.Cantidad;
                
                    Nombre.Text = c.nombre;
                    Tipo.Text = c.Tipo;
                    descripcion.Text = c.descripcion;
                    
                    Nombre.Enabled = false;
                    Tipo.Enabled = false;

                    precioCo.Text = c.PrecioCompra.ToString();
                    precioVe.Text = c.PrecioVenta.ToString();
                    cantidad.Text = c.Cantidad.ToString();

                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void añadir_Click(object sender, EventArgs e)
        {
            if(Nombre.Enabled == false)
            {
                Comprar1();
                return;
            }

            if (Nombre.Text == "")
                return;

            if (Tipo.Text == "")
                return;

            if (descripcion.Text == "")
                return;

            if (precioCo.Text == "")
                return;

            if (precioVe.Text == "")
                return;

            if (cantidad.Value == 0)
                return;

            foreach(Articulo c in st.ListaDeArticulos)
            {
                if (c.nombre == Nombre.Text)
                {
                    Comprar1();
                }
            }

            seleccionado.nombre = Nombre.Text;
            seleccionado.Tipo = Tipo.Text;
            seleccionado.descripcion = descripcion.Text;
            seleccionado.PrecioCompra = float.Parse(precioCo.Text);
            seleccionado.PrecioVenta = float.Parse(precioVe.Text);
            
            seleccionado.Cantidad = Convert.ToInt32(cantidad.Value);
            
                float x = float.Parse(cantidad.Value.ToString()) * float.Parse(precioCo.Text);

                if (Fondos < x)
                {
                    MessageBox.Show("No hay fondos");
                    cantidad.Value = decimal.Parse((x / float.Parse(precioCo.Text)).ToString());
                    return;
                }
                else
                {
                    if (es.Volatil < x)
                    {
                        x -= es.Volatil;
                        es.Volatil = 0;
                        es.seguro -= x;
                    }
                    else
                    {
                        es.Volatil -= x;
                    }
                }
            

            st.ListaDeArticulos.Add(seleccionado);
            guardar();
        }

        private void Comprar1()
        {
            st.ListaDeArticulos.Remove(seleccionado);

            seleccionado.nombre = Nombre.Text;
            seleccionado.Tipo = Tipo.Text;
            seleccionado.descripcion = descripcion.Text;
            seleccionado.PrecioCompra = float.Parse(precioCo.Text);
            seleccionado.PrecioVenta = float.Parse(precioVe.Text);

            if(seleccionado.Cantidad < Convert.ToInt32(cantidad.Value))
            {
                float x = float.Parse(Convert.ToString(Convert.ToInt32(cantidad.Value) - seleccionado.Cantidad)) * float.Parse(precioCo.Text);

                if (Fondos < x)
                {
                    MessageBox.Show("No hay fondos");
                    cantidad.Value = decimal.Parse((x / seleccionado.PrecioCompra).ToString());
                    return;
                }
                else
                {
                    if(es.Volatil < x)
                    {
                        x -= es.Volatil;
                        es.Volatil = 0;
                        es.seguro -= x;
                    }
                    else
                    {
                        es.Volatil -= x;
                    }
                }
            }

            seleccionado.Cantidad = int.Parse(cantidad.Text);

            st.ListaDeArticulos.Add(seleccionado);

            guardar();
        }

        private void guardar()
        {
            string cargar = JsonConvert.SerializeObject(st);
            File.WriteAllText("stock/" + em.Usuario + ".st", cargar);

            cargar = JsonConvert.SerializeObject(es);
            File.WriteAllText("estatus/" + em.Usuario + ".es", cargar);

            actualizar();
        }

        private void cantidad_ValueChanged(object sender, EventArgs e)
        {
            float x = float.Parse(Convert.ToString(Convert.ToInt32(cantidad.Value) - seleccionado.Cantidad)) * float.Parse(precioCo.Text);

            if (Fondos < x)
            {
                MessageBox.Show("No hay fondos");
                cantidad.Value = decimal.Parse(((Fondos/float.Parse(precioCo.Text)) + seleccionado.Cantidad).ToString());
                return;
            }
            else
            {
                label2.Text = (Fondos - x).ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
