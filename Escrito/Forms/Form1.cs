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
            int idTemp;
            if (int.TryParse(txtId.Text, out idTemp))
            {
                SetUp(p, idTemp);
                Validar(p);
            }



        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonos_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void Validar(Persona s)
        {
            bool[] validationValues = new bool[5];

            validationValues[0] = s.ValidarID();
            validationValues[1] = s.ValidarNombre();
            validationValues[2] = s.ValidarApellido();
            validationValues[3] = s.ValidarDireccion();
            validationValues[4] = s.ValidarTelefono();
            Conditional(validationValues);
        }
        private void Conditional(bool[] v)
        {
            if (v[0])
            {
                lblID.Text = "OK";
            }
            if (v[1])
            {
                lblNombre.Text = "OK";
            }
            if (v[2])
            {
                lblApellido.Text = "OK";
            }
            if (v[3])
            {
                lblDireccion.Text = "OK";
            }
            if (v[4])
            {
                lblTelefono.Text = "OK";
            }
        }
        private void SetUp(Persona t, int id)
        {
            t.SetId(id);
            t.SetNombre(txtNombre.Text);
            t.SetApellido(txtApellido.Text);
            t.SetDireccion(txtDireccion.Text);
            t.SetTelefono(txtTelefonos.Text);
        }
    }
}

