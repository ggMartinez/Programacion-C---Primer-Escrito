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
    

        public Persona(int idRecibido, string nombreRecibido, string apellidoRecibido, string telefonoRecibido, string direccionRecibido)
        {
            this.id = idRecibido;
            this.nombre = nombreRecibido;
            this.apellido = apellidoRecibido;
            this.telefono = telefonoRecibido;
            this.direccion = direccionRecibido;
        }

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

        public void ValidarID()
        {
            if (id > 99)
            {
                MessageBox.Show("El id:" + id.ToString() + " supera el rango");
            }
        }

        public void ValidarNombre()
        {
            int longitudNombre = nombre.Length;

            if (longitudNombre > 20)
            {
                MessageBox.Show("El nombre supera el rango de caracteres");
            }
        }

        public void ValidarApellido()
        {
            int longitudApellido = apellido.Length;

            if (longitudApellido > 20)
            {
                MessageBox.Show("El apellido supera el rango de caracteres");
            }
        }

        public void ValidarTelefono()
        {
            int longitudTelefono = telefono.Length;

            if (longitudTelefono > 9)
            {
                MessageBox.Show("El telefono supera el rango de caracteres");
            }
        }

        public void ValidarDireccion()
        {

            int longitudDireccion = direccion.Length;

            if (longitudDireccion > 50)
            {
                MessageBox.Show("La direccion supera el rango de caracteres");
            }
        }
    }
}
