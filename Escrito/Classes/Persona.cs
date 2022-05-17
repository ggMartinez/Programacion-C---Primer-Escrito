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

        public void ValidarID(string idNoValidado)
        {
            // Validar que sea numero, menor a 99
            if (int.TryParse(idNoValidado, out id) == true)
            {
                if((id = int.Parse(idNoValidado)) < 99) SetId(int.Parse(idNoValidado));
                else SetId(-1);
            }
        } 

        public void ValidarNombre(string nombreNoValidado)
        {
            // Validar que tenga menos de 20 caracteres
            if (nombreNoValidado.Length < 20) SetNombre(nombreNoValidado);
            else SetNombre("-1");
        }

        public void ValidarApellido(string apellidoNoValidado)
        {
            // Validar que tenga menos de 20 caracteres
            if (apellidoNoValidado.Length < 20) SetApellido(apellidoNoValidado);
            else SetApellido("-1");
        }

        public void ValidarTelefono(string telefonoNoValidado)
        {
            // Validar que sea numero, de hasta 9 cifras
            int numero;
            if(int.TryParse(telefonoNoValidado, out numero) == true)
            {
                if (telefonoNoValidado.Length <= 9) SetTelefono(telefonoNoValidado);
                else SetTelefono("-1");
            }
        }

        public void ValidarDireccion(string direccionNoValidada)
        {
            // Validar que tenga menos de 50 caracteres
            if (direccionNoValidada.Length < 50) SetDireccion(direccionNoValidada);
            else SetDireccion("-1");
        }
    }
}
