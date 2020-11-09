using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Producto
    {

        public string Codigo { get; set; }

        public double Peso { get; set; }

        public double Precio { get; set; }

        public Descuento Descuento { get; set; }

        public Producto()
        {

        }

        public Producto(string codigo, double peso, double precio, Descuento descuento)
        {
            Codigo = codigo;
            Peso = peso;
            Precio = precio;
            Descuento = descuento;
        }
    }
}
