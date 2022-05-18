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
            int idTempt = GetId();
            if (idTempt < 99)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool ValidarNombre()
        {
            // Validar que tenga menos de 20 caracteres
            string nomTemp = GetNombre();
            if (nomTemp.Length < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarApellido()
        {
            // Validar que tenga menos de 20 caracteres
            string apelTemp = GetApellido();
            if (apelTemp.Length < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarTelefono()
        {
            // Validar que sea numero, de hasta 9 cifras
            string telTemp = GetTelefono();
            int dummyInt;
            if (int.TryParse(telTemp, out dummyInt))
            {
                if (telTemp.Length < 9)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ValidarDireccion()
        {
            // Validar que tenga menos de 50 caracteres
            string dirTemp = GetDireccion();
            if (dirTemp.Length < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
