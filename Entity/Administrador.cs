using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Administrador : Persona
    {

        public string Cargo { get; set; }

        public Administrador()
        {

        }

        public Administrador(string cargo)
        {
            Cargo = cargo;
        }

    }
}
