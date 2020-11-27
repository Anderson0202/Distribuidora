using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Pedido
    {

        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public double TotalDescuento { get; set; }
        public Domiciliario domiciliario { get; set; }
        public List<DetallePedido> DetallesDePedidos { get; set; }

        public void AgregarDetalle(double cantidadKg, Producto producto)
        {
            DetallePedido detalle = new DetallePedido(cantidadKg, producto);
            DetallesDePedidos.Add(detalle);
        }

        public void CalcularSubtotal()
        {

            SubTotal = DetallesDePedidos.Sum(d=>d.SubTotalPagar );
            
        }


        public void CalcularDescuentos()
        {

            TotalDescuento = DetallesDePedidos.Sum(d => d.TotalDescuento);

        }


        public void CalcularTotal()
        {

            Total = SubTotal - TotalDescuento;

        }

    }
}
