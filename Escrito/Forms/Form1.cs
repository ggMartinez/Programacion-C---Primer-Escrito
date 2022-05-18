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
            Forms.FormularioDatos FormDatos = new Forms.FormularioDatos();

            p.SetId(Int32.Parse(txtId.Text));
            p.SetNombre(txtNombre.Text);
            p.SetApellido(txtApellido.Text);
            p.SetDireccion(txtDireccion.Text);

            if ((p.ValidarID() && p.ValidarNombre() && p.ValidarApellido() && p.ValidarDireccion()) == false) return;
            FormDatos.LabelIngresarId.Text=txtId.Text;
            FormDatos.LabelIngresarNombre.Text = txtNombre.Text;
            FormDatos.LabelIngresarApellido.Text = txtApellido.Text;
            FormDatos.LabelIngresarDireccion.Text = txtDireccion.Text;

            String[] telefonos= txtTelefonos.Text.Split('\n');
            FormDatos.LabelIngresarTelefonos.Text = "";
            for (int i=0; i <telefonos.Length; i++)
            {
                p.SetTelefono(telefonos[i]);
                if (p.ValidarTelefono() == false) return;
                FormDatos.LabelIngresarTelefonos.Text = FormDatos.LabelIngresarTelefonos.Text + "\n" + telefonos[i];
            }
            FormDatos.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
