using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Secretario : Persona
    {

        public DateTime FechaContrato { get; set; }

        public Secretario()
        {

        }

        public Secretario(DateTime fechaContrato)
        {
            FechaContrato = fechaContrato;
        }
    }
}
