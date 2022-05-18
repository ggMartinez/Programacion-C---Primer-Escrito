using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool ValidarID()
        {
            // Validar que sea numero, menor a 99
            if (id >= 99)
            {
                System.Windows.Forms.MessageBox.Show("La id tiene que ser menor que 99");
                return false;
            }
            else return true;
            
        }

        public bool ValidarNombre()
        {
            // Validar que tenga menos de 20 caracteres
            if(nombre.Length >= 20)
            {
                System.Windows.Forms.MessageBox.Show("El nombre tiene que ser menor a 20 caracteres");
                return false;
            }
            return true;
        }

        public bool ValidarApellido()
        {
            // Validar que tenga menos de 20 caracteres
            if (apellido.Length >= 20)
            {
                System.Windows.Forms.MessageBox.Show("El apellido tiene que ser menor a 20 caracteres");
                return false;
            }
            return true;
        }

        public bool ValidarTelefono()
        {
            // Validar que sea numero, de hasta 9 cifras
            if (telefono.Length > 9)
            {
                System.Windows.Forms.MessageBox.Show("El telefono tiene que ser menor que 9 cifras");
                return false;
            }
            else return true;
        }

        public bool ValidarDireccion()
        {
            // Validar que tenga menos de 50 caracteres
            if (direccion.Length > 9)
            {
                System.Windows.Forms.MessageBox.Show("La direccion tiene que ser menor que 50 caracteres");
                return false;
            }
            else return true;
        }
    }
}
