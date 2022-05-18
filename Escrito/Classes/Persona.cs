using Escrito.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escrito.Classes
{
    public class Persona
    { 
        private int id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string direccion;

        public void SetId(int idRecibido)
        {
            this.id = idRecibido;
        }
        public void SetNombre(string nombreRecibido)
        {
            this.nombre = nombreRecibido;
        }
        public void SetApellido(string apellidoRecibido)
        {
            this.apellido = apellidoRecibido;
        }
        public void SetTelefono(string telefonoRecibido)
        {
            this.telefono = telefonoRecibido;
        }
        public void SetDireccion(string direccionRecibida)
        {
            this.direccion = direccionRecibida;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public string GetTelefono()
        {
            return this.telefono;
        }

        public string GetDireccion()
        {
            return this.direccion;
        }

        public void ValidarID(int idSinVerificar)
        {
            if (idSinVerificar <= 99)
            {
                id = idSinVerificar;
            }

            if (idSinVerificar > 99)
            {
                MessageBox.Show("El id:" + idSinVerificar.ToString() + " supera el rango");
                id = 000;
            }

        }

        public void ValidarNombre(string nombreSinVerificar)
        {
            int longitudNombre = nombreSinVerificar.Length;

            if (longitudNombre <= 20)
            {
                nombre = nombreSinVerificar;   
            }

            if (longitudNombre > 20)
            {
                  MessageBox.Show("El nombre supera el rango de caracteres");
                  nombre = "Error";
            }

            if (longitudNombre == 0)
            {
                MessageBox.Show("El nombre esta vacio");
                nombre = "Error";
            }


        }

        public void ValidarApellido(string apellidoSinVerificar)
        {
            int longitudApellido = apellidoSinVerificar.Length;

            if (longitudApellido <= 20)
            {
                apellido = apellidoSinVerificar;
            }

            if (longitudApellido > 20)
            {
                  MessageBox.Show("El apellido supera el rango de caracteres");
                  apellido = "Error";
            }

            if (longitudApellido == 0)
            {
                MessageBox.Show("El apellido esta vacio");
                apellido = "Error";
            }


        }

        public void ValidarTelefono(string telefonoSinVerificar)
        {
            int longitudTelefono = telefonoSinVerificar.Length;

            if (longitudTelefono <= 9)
            {
                telefono = telefonoSinVerificar;
                
            }

            if (longitudTelefono > 9)
            {
                  MessageBox.Show("El telefono supera el rango de caracteres");
                  telefono = "Error";

            }

            if (longitudTelefono == 0)
            {
                MessageBox.Show("El telefono esta vacio");
                telefono = "Error";

            }


        }

        public void ValidarDireccion(string direccionSinVerificar)
        {

            int longitudDireccion = direccionSinVerificar.Length;

            if (longitudDireccion <= 50)
            {
                direccion = direccionSinVerificar;
                
            }

            if (longitudDireccion > 50)
            {
                  MessageBox.Show("La direccion supera el rango de caracteres");
                  direccion = "Error";

            }

            if (longitudDireccion > 50)
            {
                MessageBox.Show("La direccion supera el rango de caracteres");
                direccion = "Error";

            }

            if (longitudDireccion == 0)
            {
                MessageBox.Show("La direccion esta vacia");
                direccion = "Error";

            }


        }
  
    }
}
