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
                   
            Persona p = new Persona();
            Form2 f = new Form2();


            p.ValidarID(txtId.Text);
            p.ValidarNombre(txtNombre.Text);
            p.ValidarApellido(txtApellido.Text);
            p.ValidarDireccion(txtDireccion.Text);
            p.ValidarTelefono(txtTelefonos.Text);

            f.IngresarDatos(p.GetId().ToString() , p.GetNombre() ,p.GetApellido() ,p.GetDireccion() ,p.GetTelefono());
            f.Show();

            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
