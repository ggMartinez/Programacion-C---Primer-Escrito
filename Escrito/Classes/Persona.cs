using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escrito.Forms;//puse esto acá para poder crear un objeto del Form2

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

        public bool ValidarID(string id)
        {
            bool valido = false;
            if (id.All(char.IsDigit) && id != "")
            {
                if (id.Length < 99)
                    valido = true;
            }
            return valido;
            // Validar que sea numero, menor a 99
        }

        public bool ValidarNombre(string nombre)
        {
            bool valido = false;
            if (nombre.Length < 20)
                valido = true;
            return valido;
                // Validar que tenga menos de 20 caracteres
        }

        public bool ValidarApellido(string apellido)
        {
            bool valido = false;
            if (apellido.Length < 20 && apellido != "")
                valido = true;
            return valido;
            // Validar que tenga menos de 20 caracteres
        }

        public bool ValidarTelefono(string telefono)
        {
            bool valido = false;
            if (telefono.All(char.IsDigit) && telefono != "")
            {
                if (telefono.Length < 9)
                    valido = true;
            }
            return valido;
            // Validar que sea numero, de hasta 9 cifras
        }

        public bool ValidarDireccion(string direccion)
        {
            bool valido = false;
            if (direccion.Length < 20 && direccion != "")
                valido = true;
            return valido;
            // Validar que tenga menos de 50 caracteres
        }

        public bool ValidarTodos(string apellido, string nombre, string id, string telefonos, string direccion)
        {
            bool todosSonValidos = true;

            bool apellidoEsValido = ValidarApellido(apellido);
            bool nombreEsValido = ValidarNombre(nombre);
            bool idEsValido = ValidarID(id);
            bool telefonoEsValidos = ValidarTelefono(telefonos);
            bool direccionEsValida = ValidarDireccion(direccion);

            bool[] validos = {apellidoEsValido, nombreEsValido, idEsValido, telefonoEsValidos, direccionEsValida};

            foreach (bool v in validos)
            {
                if (v == false)
                    todosSonValidos = false;
            }
            return todosSonValidos;
        }

        public void mostrarDatos()
        {
            Form2 f = new Form2();

            f.txtApellido.Text = apellido;
            f.txtDireccion.Text = direccion;
            f.txtNombre.Text = nombre;
            f.txtTelefono.Text = telefono;
            f.txtID.Text = id.ToString();

            f.Visible = true;
        }
    }
}
