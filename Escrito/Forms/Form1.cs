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
using Escrito.Forms;

namespace Escrito
{
    public partial class Form1 : Form
    {
        
        Persona p = new Persona();

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

            int id = Int32.Parse(txtId.Text); 
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefonos.Text;
            string direccion = txtDireccion.Text;
                
            p.ValidarID(id);
            p.ValidarNombre(nombre);
            p.ValidarApellido(apellido);
            p.ValidarTelefono(telefono);
            p.ValidarDireccion(direccion);
               
            int idEnviarFormularioDatos = p.GetId();
            string nombreEviarFormularioDatos = p.GetNombre();
            string apellidoEnviarFormularioDatos = p.GetApellido();
            string telefonoEnviarFormularioDatos = p.GetTelefono();
            string direccionEnviarFormularioDatos = p.GetDireccion();
  
            Form2 FormularioDatos = new Form2();
            FormularioDatos.txtRecibidoId.Text = idEnviarFormularioDatos.ToString();
            FormularioDatos.txtRecibidoNombre.Text = nombreEviarFormularioDatos;
            FormularioDatos.txtRecibidoApellido.Text = apellidoEnviarFormularioDatos;
            FormularioDatos.txtRecibidoTelefono.Text = telefonoEnviarFormularioDatos;
            FormularioDatos.txtRecibidoDireccion.Text = direccionEnviarFormularioDatos;

            FormularioDatos.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
