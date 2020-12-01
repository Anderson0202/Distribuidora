
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Descuento
    {

        public double PorcentajeDescuento { get; set; }
        public string CodigoDescuento { get; set; }
        public string CodigoProducto { get; set; }
        public string identificacionPersona { get; set; }
        public Descuento()
        {

        }

        public Descuento(double porcentajeDescuento, string codigoProducto, string identificacionPersona, string codigoDescuento)
        {
            PorcentajeDescuento = porcentajeDescuento;
            CodigoDescuento = codigoDescuento;
            CodigoProducto = codigoProducto;
            this.identificacionPersona = identificacionPersona;
        }

    }
}
