using Escrito.Forms;
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
        private const int ERRORID = 999; 

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

        public void ValidarID(string IdSinValidar)
        {
            if (CantidadDeCaracteres(IdSinValidar, 99) && int.TryParse(IdSinValidar, out int result))
            {
                id = Int32.Parse(IdSinValidar); 
            }
            else
            {
                id = ERRORID;
            }
        } // Validar que sea numero, menor a 99

        public void ValidarNombre(string NombreSinValidar)
        {
            if (CantidadDeCaracteres(NombreSinValidar, 20))
                nombre = NombreSinValidar;
        }  // Validar que tenga menos de 20 caracteres
        

        public void ValidarApellido(string ApellidoSinValidar)
        {
            if (CantidadDeCaracteres(ApellidoSinValidar, 20))
                apellido = ApellidoSinValidar;
        }// Validar que tenga menos de 20 caracteres

        public void ValidarTelefono(string TelefonoSinValidar)
        {
            if (CantidadDeCaracteres(TelefonoSinValidar, 10))
               telefono = TelefonoSinValidar;
        }// Validar que sea numero, de hasta 9 cifras

        public void ValidarDireccion(string DireccionSinValidar)
        {
            if (CantidadDeCaracteres(DireccionSinValidar, 50))
                direccion = DireccionSinValidar;
        }// Validar que tenga menos de 50 caracteres
        public bool CantidadDeCaracteres(string cadena, int maximo)
        {
            if (cadena.Length < maximo)
                return true;
            else
                return false;   
        }
        
    }
}
