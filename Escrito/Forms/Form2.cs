using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escrito.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        public void IngresarDatos(string ID ,string Nombre, string Apellido ,string Direccion , string Telefono)
        {
            IDLabel.Text = ID;
            NombreLabel.Text = Nombre;
            ApellidoLabel.Text = Apellido;
            DireccionLabel.Text = Direccion;
            TelefonoLabel.Text = Telefono;


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
