
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Descuento
    {

        public decimal PorcentajeDescuento { get; set; }
        public string CodigoProducto { get; set; }
        public string identificacionPersona { get; set; }
        public string CodigoDescuento { get; set; }

        public Descuento()
        {

        }

        public Descuento(decimal porcentajeDescuento, string codigoProducto, string identificacionPersona, string codigoDescuento)
        {
            PorcentajeDescuento = porcentajeDescuento;
            CodigoProducto = codigoProducto;
            this.identificacionPersona = identificacionPersona;
            CodigoDescuento = codigoDescuento;
        }

    }
}
