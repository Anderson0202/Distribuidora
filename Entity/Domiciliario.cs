using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Domiciliario : Persona
    {

        public DateTime FechaVencimientoPermisoConduccion { get; set; }
        public Vehiculo Moto { get; set; }

        public Domiciliario()
        {

        }

        public Domiciliario(DateTime fechaVencimientoPermisoConduccion, Vehiculo moto)
        {
            FechaVencimientoPermisoConduccion = fechaVencimientoPermisoConduccion;
            Moto = moto;
        }

    }
}
