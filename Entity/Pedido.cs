using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pedido
    {

        public string Codigo { get; set; }
        public string IdPersona { get; set; }
        public DateTime Fecha { get; set; }
        public double SubTotal { get; set; }
        public List<DetallePedido> DetallesPedidos { get; set; }
        public double Iva { get; set; }
        public double TotalIva { get; set; }
        public double Total { get; set; }
        public double Descuento { get; set; }

        public Pedido()
        {

        }

        public Pedido(string codigo, string idPersona, DateTime fecha, double subTotal, List<DetallePedido> detallesPedidos, double iva, double totalIva, double total, double descuento)
        {
            Codigo = codigo;
            IdPersona = idPersona;
            Fecha = fecha;
            SubTotal = subTotal;
            DetallesPedidos = detallesPedidos;
            Iva = iva;
            TotalIva = totalIva;
            Total = total;
            Descuento = descuento;
        }
    }
}
