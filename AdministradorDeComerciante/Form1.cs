using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using System.IO;

namespace AdministradorDeComerciante
{
    public partial class Form1 : Form, Interfaz
    {
        public Form1()
        {
            InitializeComponent();
            labelFecha.Text = DateTime.UtcNow.ToString();
            linkLabel1.Visible = false;
            menu.Visible = false;
            Revisar();
        }
        
        Empresa em;
        
        private void Revisar()
        {
            if (!File.Exists("Data/Registro.OKs"))
            {
                ListaEmpresas asd = new ListaEmpresas();

                asd.UsuariosTotales = new List<Empresa>();

                string g = JsonConvert.SerializeObject(asd);

                File.WriteAllText("Data/Registro.OKs", g);

                AbrirFormulario<Registrarse>();
            }
            else
            {
                Login ingresar = new Login();
                ingresar.TopLevel = false;
                ingresar.Dock = DockStyle.Fill;
                Contenedor.Controls.Add(ingresar);
                Contenedor.Tag = ingresar;
                ingresar.contrato = this;
                ingresar.Show();
                ingresar.BringToFront();
                linkLabel1.Visible = true;
            }
        }

        public void Ejecutar(Empresa o)
        {

            linkLabel1.Visible = false;
            menu.Visible = true;

            em = o;

            this.Text = o.Nombre;

            Home formulario = new Home();
            formulario.em = o;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(formulario);
            Contenedor.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario = Contenedor.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                Contenedor.Controls.Add(formulario);
                Contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.Dock = DockStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.BringToFront();
            }
        }

        private void Dmenu_Click(object sender, EventArgs e)
        {
            animacionMenu.Enabled = true;
        }

        //animacion menu ---------------------------------------------------------------------------------

        int animacion = 5;
        bool openmenu = false;

        private void animacionMenu_Tick(object sender, EventArgs e)
        {
            if(!openmenu)
            {
                if(menu.Width + animacion > 200)
                {
                    menu.Width = 200;
                    animacion = 5;
                    openmenu = !openmenu;
                    animacionMenu.Enabled = false;
                }
                else
                {
                    menu.Width = menu.Width + animacion;
                    animacion += 5;
                }

            }
            else
            {
                if (menu.Width - animacion < 36)
                {
                    menu.Width = 36;
                    animacion = 5;
                    openmenu = !openmenu;
                    animacionMenu.Enabled = false;
                }
                else
                {
                    menu.Width = menu.Width - animacion;
                    animacion += 5;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.UtcNow.ToString();
        }

        bool Opencalcu = false;
        int Calculadora = 4; 

        private void animacionCalculadora_Tick(object sender, EventArgs e)
        {
            if (!Opencalcu)
            {
                if (calcu.Height + Calculadora > 220)
                {
                    calcu.Height = 220;
                    Calculadora = 5;
                    Opencalcu = !Opencalcu;
                    animacionCalculadora.Enabled = false;
                }
                else
                {
                    calcu.Height = calcu.Height + Calculadora;
                    Calculadora += 5;
                }

            }
            else
            {
                if (calcu.Height - Calculadora < 13)
                {
                    calcu.Height = 13;
                    Calculadora = 5;
                    Opencalcu = !Opencalcu;
                    animacionCalculadora.Enabled = false;
                }
                else
                {
                    calcu.Height = calcu.Height - Calculadora;
                    Calculadora += 5;
                }
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            animacionCalculadora.Enabled = true;
        }

        string a;
        string b;

        bool selec = false;

        private void button6_Click(object sender, EventArgs e)
        {
            Calcular.Text += "1";

            if (selec)
            {
                b += "1";
            }
            else
            {
                a += "1";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Calcular.Text += "2";

            if (selec)
            {
                b += "2";
            }
            else
            {
                a += "2";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calcular.Text += "3";

            if (selec)
            {
                b += "3";
            }
            else
            {
                a += "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Calcular.Text += "4";

            if (selec)
            {
                b += "4";
            }
            else
            {
                a += "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Calcular.Text += "5";

            if (selec)
            {
                b += "5";
            }
            else
            {
                a += "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calcular.Text += "6";

            if (selec)
            {
                b += "6";
            }
            else
            {
                a += "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Calcular.Text += "7";

            if (selec)
            {
                b += "7";
            }
            else
            {
                a += "7";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Calcular.Text += "8";

            if (selec)
            {
                b += "8";
            }
            else
            {
                a += "8";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Calcular.Text += "9";

            if (selec)
            {
                b += "9";
            }
            else
            {
                a += "9";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Calcular.Text += "0";

            if (selec)
            {
                b += "0";
            }
            else
            {
                a += "0";
            }
        }

        bool coma = true;

        private void button16_Click(object sender, EventArgs e)
        {
            if (selec)
            {
                if (coma)
                {
                    b += ",";
                    coma = !coma;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (coma)
                {
                    a += ",";
                    coma = !coma;
                }
                else
                {
                    return;
                }
            }

            Calcular.Text += ",";

        }

        char ope = ' ';

        private void button17_Click(object sender, EventArgs e)
        {
            if (!selec)
            {
                ope = '+';
                Calcular.Text += " + ";
                selec = !selec;
                coma = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!selec)
            {
                ope = '-';
                Calcular.Text += " - ";
                selec = !selec;
                coma = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!selec)
            {
                ope = '*';
                Calcular.Text += " * ";
                selec = !selec;
                coma = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!selec)
            {
                ope = '/';
                Calcular.Text += " / ";
                selec = !selec;
                coma = true;
            }
        }

        double result;

        private void button18_Click(object sender, EventArgs e)
        {
            if (!selec)
                return;

            if (b == "")
                b = "0";

            if (a == "")
                a = "0";

            double A = double.Parse(a);
            double B = double.Parse(b);

            switch (ope)
            {
                case '+':
                    Calcular.Text = Convert.ToString(A+B);
                    result = A + B;
                    break;

                case '-':
                    Calcular.Text = Convert.ToString(A-B);
                    result = A - B;
                    break;

                case '*':
                    Calcular.Text = Convert.ToString(A*B);
                    result = A * B;
                    break;

                case '/':
                    Calcular.Text = Convert.ToString(A / B);
                    result = A / B;
                    break;
            }

            a = Convert.ToString(result);
            b = "";
            selec = false;
            coma = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = "";
            b = "";
            selec = false;
            coma = true;
            Calcular.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Home>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vender vender = Contenedor.Controls.OfType<Vender>().FirstOrDefault();

            if (vender == null)
            {
                vender = new Vender();
                vender.em = em;
                vender.TopLevel = false;
                vender.Dock = DockStyle.Fill;
                Contenedor.Controls.Add(vender);
                Contenedor.Tag = vender;
                vender.Show();
                vender.BringToFront();
            }
            else
            {
                vender.Dock = DockStyle.None;
                vender.Dock = DockStyle.Fill;
                vender.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comprar vender = Contenedor.Controls.OfType<Comprar>().FirstOrDefault();

            if (vender == null)
            {
                vender = new Comprar();
                vender.em = em;
                vender.TopLevel = false;
                vender.Dock = DockStyle.Fill;
                Contenedor.Controls.Add(vender);
                Contenedor.Tag = vender;
                vender.Show();
                vender.BringToFront();
            }
            else
            {
                vender.Dock = DockStyle.None;
                vender.Dock = DockStyle.Fill;
                vender.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Administrar vender = Contenedor.Controls.OfType<Administrar>().FirstOrDefault();

            if (vender == null)
            {
                vender = new Administrar();
                vender.em = em;
                vender.TopLevel = false;
                Contenedor.Controls.Add(vender);
                Contenedor.Tag = vender;
                vender.Dock = DockStyle.Fill;
                vender.Show();
                vender.BringToFront();
            }
            else
            {
                vender.Dock = DockStyle.None;
                vender.Dock = DockStyle.Fill;
                vender.BringToFront();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario<Registrarse>();
            linkLabel1.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            float asd = 0;

            try
            {
                asd = float.Parse(Calcular.Text);
            }
            catch (Exception)
            {
                return;
            }

            Calcular.Text = (asd/em.ListaDivisas[0].equivalente).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            float asd = 0;

            try
            {
                asd = float.Parse(Calcular.Text);
            }
            catch (Exception)
            {
                return;
            }

            Calcular.Text = (asd * em.ListaDivisas[0].equivalente).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(Calcular.Text);
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calcu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
