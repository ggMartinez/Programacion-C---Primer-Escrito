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
        Form2 f2 = new Form2();
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


            Validaciones();
            EnviarDatosVeridficados();
            AbrirForm2();
           

            // Agregar el codigo necesario luego de este punto
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
        public void EnviarDatosVeridficados()
        {
            f2.SetIdFinal(p.GetId());
            f2.SetNombreFinal(p.GetNombre());
            f2.SetApellidoFinal(p.GetApellido());
            f2.SetDireccionFinal(p.GetDireccion());
            f2.SetTelefonoFinal(p.GetTelefono());
        }
        private void Validaciones()
        {
            p.ValidarID(txtId.Text);
            p.ValidarNombre(txtNombre.Text);
            p.ValidarApellido(txtApellido.Text);
            p.ValidarDireccion(txtDireccion.Text);
            p.ValidarTelefono(txtTelefonos.Text);
        }
        private void AbrirForm2()
        {
            bool estaAbierto = false;

            if (estaAbierto == false)
            {
                f2.Show();
                estaAbierto = true;
            }
            else
            {
                f2.Dispose();
                f2.Close();
                estaAbierto = false;
            }

        }

    }
}
