using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Producto
    {

        public double Precio { get; set; }
        public Descuento Descuento { get; set; }
        public string Codigo { get; set; }

        public Producto()
        {

        }

        public Producto(double precio, Descuento descuento, string codigo)
        {
            Precio = precio;
            Descuento = descuento;
            Codigo = codigo;
        }
    }
}
