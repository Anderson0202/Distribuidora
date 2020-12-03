using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {

        public string Codigo { get; set; }

        public double Peso { get; set; }

        public double Precio { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public double PesoMinimo { get; set; }
        

        public Producto()
        {

        }

        public Producto(string codigo, double peso, double precio, string categoria, string nombre, double pesoMinimo)
        {
            Codigo = codigo;
            Peso = peso;
            Precio = precio;
            Categoria = categoria;
            Nombre = nombre;
            PesoMinimo = pesoMinimo;
          
        }
    }
}
