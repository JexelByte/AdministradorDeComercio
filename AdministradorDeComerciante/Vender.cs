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
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
            Nombre.Checked = true;

            venta = new Venta();
            venta.LAVendidos = new List<Articulo>();
        }

        Venta venta;

        public Empresa em { get; set; }

        private Stock st;

        private Estatus es;

        private void Vender_DockChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            string cargar = File.ReadAllText("stock/" + em.Usuario + ".st");
            st = JsonConvert.DeserializeObject<Stock>(cargar);

            cargar = File.ReadAllText("estatus/" + em.Usuario + ".es");
            es = JsonConvert.DeserializeObject<Estatus>(cargar);

            if(st.id != em.id)
            {
                MessageBox.Show("archivo dañado!");
                return;
            }

            Lista.Items.Clear();

            listBox1.Items.Clear();

            richTextBox1.Text = "";

            label4.Text = "Productos:";
            label3.Text = "Monto Total:";
            label5.Text = "Monto Final:";

            final.Text = "";

            foreach (Articulo c in st.ListaDeArticulos)
            {
                Lista.Items.Add(c.nombre);
            }
        
            seleccionado = new Articulo();

            venta.LAVendidos = new List<Articulo>();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if(textBox1.ForeColor == Color.Gray)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = "Buscar";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.White)
            {
                Lista.Items.Clear();

                if (Nombre.Checked == true)
                {
                    foreach (Articulo c in st.ListaDeArticulos)
                    {
                        if (c.nombre.ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            if (!Lista.Items.Contains(c.nombre))
                            {
                                Lista.Items.Add(c.nombre);
                            }
                        }
                    }
                }
                else if (tipo.Checked == true)
                {
                    foreach (Articulo c in st.ListaDeArticulos)
                    {
                        if (c.Tipo.ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            if (!Lista.Items.Contains(c.Tipo))
                            {
                                Lista.Items.Add(c.Tipo);
                            }
                        }
                    }
                }
                else if (descripcion.Checked == true)
                {
                    foreach (Articulo c in st.ListaDeArticulos)
                    {
                        if (c.descripcion.ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            if (!Lista.Items.Contains(c.descripcion))
                            {
                                Lista.Items.Add(c.descripcion);
                            }
                        }
                    }
                }
            }
        }

        Articulo seleccionado;

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Nombre.Checked == true)
            {
                foreach (Articulo c in st.ListaDeArticulos)
                {
                    if (c.nombre == Lista.Text)
                    {
                        seleccionado = c;
                        richTextBox1.Text = "Nombre: " + c.nombre + "\n\n" + "Tipo: " + c.Tipo + "\n\n" + "Descripcion: "
                            + c.descripcion + "\n\n" + "Precio Unidad $: " + c.PrecioVenta + "\n\n" + "Precio Unidad: " + c.PrecioVenta * em.ListaDivisas[0].equivalente + "\n\n" + "Cantidad: " + c.Cantidad;
                    }
                }
            }
            else if (tipo.Checked == true)
            {
                foreach (Articulo c in st.ListaDeArticulos)
                {
                    if (c.Tipo == Lista.Text)
                    {
                        seleccionado = c;
                        richTextBox1.Text = "Nombre: " + c.nombre + "\n\n" + "Tipo: " + c.Tipo + "\n\n" + "Descripcion: "
                            + c.descripcion + "\n\n" + "Precio Unidad $: " + c.PrecioVenta + "\n\n" + "Precio Unidad: " + c.PrecioVenta * em.ListaDivisas[0].equivalente + "\n\n" + "Cantidad: " + c.Cantidad;
                    }
                }
            }
            else if (descripcion.Checked == true)
            {
                foreach (Articulo c in st.ListaDeArticulos)
                {
                    if (c.descripcion == Lista.Text)
                    {
                        seleccionado = c;
                        richTextBox1.Text = "Nombre: " + c.nombre + "\n\n" + "Tipo: " + c.Tipo + "\n\n" + "Descripcion: "
                            + c.descripcion + "\n\n" + "Precio Unidad $: " + c.PrecioVenta + "\n\n" + "Precio Unidad: " + c.PrecioVenta * em.ListaDivisas[0].equivalente + "\n\n" + "Cantidad: " + c.Cantidad;
                    }
                }
            }
        }

        private void añadir_Click(object sender, EventArgs e)
        {
            if (seleccionado.nombre == null)
                return;
            
            
            foreach(Articulo c in st.ListaDeArticulos)
            {
                if(c == seleccionado)
                {
                    if (c.Cantidad < 1)
                    {
                        return;
                    }
                    else
                    {
                        c.Cantidad--;
                        richTextBox1.Text = "Nombre: " + c.nombre + "\n\n" + "Tipo: " + c.Tipo + "\n\n" + "Descripcion: "
                             + c.descripcion + "\n\n" + "Precio Unidad $: " + c.PrecioVenta + "\n\n" + "Precio Unidad bs: " + c.PrecioVenta * em.ListaDivisas[0].equivalente + "\n\n" + "Cantidad: " + c.Cantidad;
                    }
                }
            }

            listBox1.Items.Add(seleccionado.nombre);
            venta.LAVendidos.Add(seleccionado);
            venta.MontoTotal += seleccionado.PrecioVenta;

            label4.Text = "Productos: " + listBox1.Items.Count.ToString();

            if(Dolar.Checked == true)
            {
                label3.Text = "Monto Total: " + venta.MontoTotal.ToString();
                final.Text = Convert.ToString(venta.MontoTotal);
            }
            else
            {
                label3.Text = "Monto Total: " + venta.MontoTotal * em.ListaDivisas[0].equivalente;
                final.Text = Convert.ToString(venta.MontoTotal * em.ListaDivisas[0].equivalente);
            }
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            if (seleccionado.nombre == null)
                return;

            if (!listBox1.Items.Contains(seleccionado.nombre))
                return;

            foreach (Articulo c in st.ListaDeArticulos)
            {
                if (c == seleccionado)
                {
                    c.Cantidad++;
                    richTextBox1.Text = "Nombre: " + c.nombre + "\n\n" + "Tipo: " + c.Tipo + "\n\n" + "Descripcion: "
                            + c.descripcion + "\n\n" + "Precio Unidad $: " + c.PrecioVenta + "\n\n" + "Precio Unidad: " + c.PrecioVenta * em.ListaDivisas[0].equivalente + "\n\n" + "Cantidad: " + c.Cantidad;
                }
            }

            listBox1.Items.Remove(seleccionado.nombre);
            venta.LAVendidos.Remove(seleccionado);
            venta.MontoTotal -= seleccionado.PrecioVenta;

            label4.Text = "Productos: " + listBox1.Items.Count.ToString();

            label3.Text = "Monto Total: " + venta.MontoTotal.ToString();

            final.Text = venta.MontoTotal.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Articulo c in st.ListaDeArticulos)
            {
                if (c.nombre == Lista.Text)
                {
                    seleccionado = c;
                    richTextBox1.Text = "Nombre: " + c.nombre + "\n\n" + "Tipo: " + c.Tipo + "\n\n" + "Descripcion: "
                        + c.descripcion + "\n\n" + "Precio Unidad: " + c.PrecioVenta + "\n\n" + "Cantidad: " + c.Cantidad;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            venta.Fecha = DateTime.Today;
            
            es.MontoVentas += float.Parse(final.Text);

            if (Dolar.Checked == true)
            {
                es.seguro += float.Parse(final.Text);
            }
            else
            {
                es.Volatil += float.Parse(final.Text)/em.ListaDivisas[0].equivalente;
            }

            Guardar();
        }

        private void Guardar()
        {
            string cargar = JsonConvert.SerializeObject(st);
            File.WriteAllText("stock/" + em.Usuario + ".st", cargar);

            cargar = JsonConvert.SerializeObject(es);
            File.WriteAllText("estatus/" + em.Usuario + ".es", cargar);

            cargar = File.ReadAllText("trans/" + em.Usuario + ".tr");
            Transacciones tr = JsonConvert.DeserializeObject<Transacciones>(cargar);

            tr.TodasLasVentas.Add(venta);

            venta = new Venta();

            cargar = JsonConvert.SerializeObject(tr);
            File.WriteAllText("trans/" + em.Usuario + ".tr", cargar);

            actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void Dolar_CheckedChanged(object sender, EventArgs e)
        {
            if (Dolar.Checked == true)
            {
                label3.Text = "Monto Total: " + venta.MontoTotal.ToString();
                final.Text = Convert.ToString(venta.MontoTotal);
            }
            else
            {
                label3.Text = "Monto Total: " + venta.MontoTotal * em.ListaDivisas[0].equivalente;
                final.Text = Convert.ToString(venta.MontoTotal * em.ListaDivisas[0].equivalente);
            }
        }
    }
}
