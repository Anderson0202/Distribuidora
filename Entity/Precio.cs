using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Precio
    {

        public List<Descuento> Descuentos { get; set; }

        public double PrecioProducto { get; set; }

        public Precio()
        {

        }

        public Precio(List<Descuento> descuentos, double precioProducto)
        {
            Descuentos = descuentos;
            PrecioProducto = precioProducto;
        }
    }
}
