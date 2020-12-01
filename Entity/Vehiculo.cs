using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vehiculo
    {

        public string Placa { get; set; }
        public DateTime FechaVencimientoSoat { get; set; }
        public DateTime FechaVenciciemtoTecnoMecanica { get; set; }

        public Vehiculo()
        {

        }

        public Vehiculo(string placa, DateTime fechaVencimientoSoat, DateTime fechaVenciciemtoTecnoMecanica)
        {
            Placa = placa;
            FechaVencimientoSoat = fechaVencimientoSoat;
            FechaVenciciemtoTecnoMecanica = fechaVenciciemtoTecnoMecanica;
        }
    }
}
