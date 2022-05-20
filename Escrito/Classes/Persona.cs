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

        public void ValidarID(string idSinValidar)
        {
            int IdValidada;
            bool validar = int.TryParse(idSinValidar, out IdValidada);
            if (validar && IdValidada < 99)
            {
                
                SetId(IdValidada);
                  
            }

            
        }

        public void ValidarNombre(string NombreSinValidar)
        {
            if(NombreSinValidar.Length < 20)
            {
                SetNombre(NombreSinValidar);
            }
            
        }

        public void ValidarApellido(string ApellidoValidado)
        {
            if(ApellidoValidado.Length < 20)
            {
                SetApellido(ApellidoValidado);
         }
            
        }

        public void ValidarTelefono(string TelefonoNoValidado)
        {
            int TelefonoValidado;
            bool validar = int.TryParse(TelefonoNoValidado, out TelefonoValidado);

                if(validar && TelefonoValidado.ToString().Length <= 9)
            {
                SetTelefono(TelefonoNoValidado);
            }

            
        }

        public void ValidarDireccion(string DireccionNoValidada)
        {
            if(DireccionNoValidada.Length < 50)
            {
                SetDireccion(DireccionNoValidada);
            }
           
        }
    }
}
