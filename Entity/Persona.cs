using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Persona
    {

        public string Identificacion { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Tipo { get; set; }

        public Persona()
        {
              
        }

        protected Persona(string identificacion, string nombre, string apellido, string telefono, string tipo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Tipo = tipo;
        }
    }
}
