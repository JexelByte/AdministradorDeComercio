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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public Interfaz contrato { get; set; }

        private void button4_Click(object sender, EventArgs e)
        {
            ogin();
        }

        private void ogin()
        {
            string car = File.ReadAllText("Data/Registro.OKs");

            ListaEmpresas em = JsonConvert.DeserializeObject<ListaEmpresas>(car);

            foreach (Empresa c in em.UsuariosTotales)
            {
                if (c.Usuario == Usuario.Text)
                {
                    if (c.Clave == key.Text)
                    {
                        loadem(c);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta", "Error");
                        key.Text = "";
                        key.Focus();
                    }
                }
            }

            MessageBox.Show("El usuario " + Usuario.Text + " no existe", "Error");
        }
        
        private void loadem(Empresa c)
        {
            Empresa esta = new Empresa();

            esta.Nombre = c.Nombre;
            esta.Dueño = c.Dueño;
            esta.Direccion = c.Direccion;
            esta.ListaDivisas = c.ListaDivisas;
            esta.Telefono = c.Telefono;
            esta.id = c.id;
            esta.Usuario = c.Usuario;
            esta.ListaDivisas = c.ListaDivisas;

            contrato.Ejecutar(esta);

            this.Close();
        }
        
        private void Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                key.Focus();
            }
        }

        private void key_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ogin();
            }
        }
    }
}
