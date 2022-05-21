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

            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string id = txtID.Text;
            string telefono = txtTelefonos.Text;
            string direccion = txtDireccion.Text;

            bool todosValidos = p.ValidarTodos(apellido, nombre, id, telefono, direccion);

            if (todosValidos == true)
            {
                p.SetApellido(apellido);
                p.SetNombre(nombre);
                p.SetId(int.Parse(id));
                p.SetTelefono(telefono);
                p.SetDireccion(direccion);
                p.mostrarDatos();
            }
            else
                MessageBox.Show("Existe algun error en los datos ingresador.\nCorrobore los datos e intentelo nuevamente.");
            

            
        
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
