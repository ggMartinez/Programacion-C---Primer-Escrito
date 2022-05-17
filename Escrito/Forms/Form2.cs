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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIDFinal_TextChanged(object sender, EventArgs e)
        {

        }
        public void SetIdFinal(int id)
        {
            FillForm(id);
        }
        public void SetNombreFinal(string nombre)
        {
            if (PruebaDeErrores(nombre))
                FillForm(nombre,1); 
        }
        public void SetApellidoFinal(string apellido)
        {
            if (PruebaDeErrores(apellido))
                FillForm(apellido,2);
        }
        public void SetDireccionFinal(string direccion)
        {
            if (PruebaDeErrores(direccion))
                FillForm(direccion,3);
        }
        public void SetTelefonoFinal(string telefono)
        {
            if (PruebaDeErrores(telefono))
                FillForm(telefono,4);
        }
        public void FillForm(string dato, int tipo)
        {
            if (dato != "")
            {
                if (tipo == 1)
                    txtNombreFinal.Text = dato;
                else if (tipo == 2)
                    txtApellidoFinal.Text = dato;
                else if (tipo == 3)
                    txtDireccionFinal.Text = dato;
                else if (tipo == 4)
                    txtTelefonoFinal.Text = dato;
            }

        }
        public void FillForm(int dato)
        {
            if (dato != 999)
                txtIDFinal.Text = dato.ToString();
            else
                txtIDFinal.Text = "error";
        }
        private bool PruebaDeErrores(string dato)
        {
            if (dato != null)
                return true;
            else
                return false;
        }

    }
}
