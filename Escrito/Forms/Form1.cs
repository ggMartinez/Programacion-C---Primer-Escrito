using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escrito.Classes;
namespace Escrito
{
    public partial class Form1 : Form
    {

        public string idValidado;
        public string nombreValidado;
        public string apellidoValidado;
        public string direccionValidada;
        public string telefonoValidado;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            /*
            En este metodo se debe realizar la validacion de los datos del formulario.
            Se debe trabajar con la instancia "p" de Persona ya creada, cargando los datos del 
            formulario en sus atributos, y ejecutando los metodos de validacion, los cuales se
            le deben escribir el contenido.

            Una vez validado el formulario (si pasa todas las validaciones), 
            se debe mostar la informacion proveniente de los textbox de este formulario en otro
            formulario (el cual debe ser creado).
            */

            Persona p = new Persona();
            // Agregar el codigo necesario luego de este punto

            string idNoValidado = txtId.Text;
            string nombreNoValidado = txtNombre.Text;
            string apellidoNoValidado = txtApellido.Text;
            string direccionNoValidada = txtDireccion.Text;
            string telefonoNoValidado = txtTelefonos.Text;

            p.ValidarID(idNoValidado);
            p.ValidarNombre(nombreNoValidado);
            p.ValidarApellido(apellidoNoValidado);
            p.ValidarDireccion(direccionNoValidada);
            p.ValidarTelefono(telefonoNoValidado);

            idValidado = p.GetId().ToString();
            nombreValidado = p.GetNombre();
            apellidoValidado = p.GetApellido();
            direccionValidada = p.GetDireccion();
            telefonoValidado = p.GetTelefono();

            if (idValidado == "-1" || nombreValidado == "-1" || apellidoValidado == "-1" 
            || direccionValidada == "-1" || telefonoValidado == "-1")
            {
                MessageBox.Show("ERROR: Por favor compruebe los datos e intente de nuevo.");
                Application.Exit();
            }

            Form2 f2 = new Form2(txtId.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefonos.Text);
            f2.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtTelefonos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
