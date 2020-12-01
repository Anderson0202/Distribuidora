using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    class PedidoService
    {
        

        public List<Pedido> Pedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            return pedidos;// returna todos los pedidos registrados en la base de datos.
        }

        public PedidoResponse Guardar(Pedido pedido)
        {
            try
            {
                //Metodo que agrega el pedido a la base de datos(InicializarCodigos(pedido));
                return new PedidoResponse(pedido);
            }
            catch (Exception e)
            {
                return new PedidoResponse($"Error de la aplicacion: {e.Message}");
            }
        }


        public Pedido InicializarCodigos(Pedido pedido)
        {
            GenerarCodigoPedido(pedido);
            GenerarCodigosDetallesPedido(pedido);
            return pedido;
        }

        public Pedido GenerarCodigosDetallesPedido(Pedido pedido)
        {
            int cantidadPedidosRegistrados = 0; //metodo que trae la cantidad de detalles de pedidos registrados en la base de datos;
            bool Parar = true;
            while (Parar)
            {
                DetallePedido detalleDePedido = null; // trae de la base de datos un detalle de pedido con el codito de prueba(cantidadPedidosRegistrados.ToString());
                if (detalleDePedido == null)
                {
                    Parar = false;
                    foreach (DetallePedido detalle in pedido.DetallesPedidos)
                    {
                        detalle.Codigo = cantidadPedidosRegistrados.ToString();
                        detalle.CodPedido = pedido.Codigo;
                        cantidadPedidosRegistrados++;
                    }
                }
                cantidadPedidosRegistrados++;
            }
            return pedido;
        }

        public Pedido GenerarCodigoPedido(Pedido pedido)
        {
            int cantidadPedidosRegistrados = 0;/*Metodo que trae de la base de datos la cantidad de pedidos registrados;*/
            bool Parar = true;
            while (Parar)
            {
                Pedido pedidoEncontrado = null; //Metodo que tare un pedido registrado con el codigo de prueba(cantidadPedidosRegistrados.ToString())
                if (pedidoEncontrado == null)
                {
                    Parar = false;
                    pedido.Codigo = cantidadPedidosRegistrados.ToString();
                }
                cantidadPedidosRegistrados++;
            }
            return pedido;
        }

        public Pedido GenerarPedido(List<Producto> Productos, Cliente Cliente)
        {

            List<Descuento> Descuentos = null; /* Metodo que trae de la base de datos los descuentos registrados del cliente qie se recive por parametros*/
            List<DetallePedido> detalleDePedidos = GenerarDetallesPedido(Productos, Descuentos);
            Pedido pedido = CalcularPedido(detalleDePedidos);
            pedido.Fecha = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
            pedido.IdPersona = Cliente.Identificacion;
            return pedido;
        }

        public Pedido CalcularPedido(List<DetallePedido> detalleDePedidos)
        {
            Pedido pedido = new Pedido();
            pedido.SubTotal = detalleDePedidos.Sum(d => d.SubTotal);
            pedido.Iva = 19;
            pedido.TotalIva = pedido.SubTotal * (pedido.Iva / 100);
            pedido.Descuento = detalleDePedidos.Sum(d => d.TotalDescuento);
            pedido.Total = pedido.SubTotal - pedido.Descuento + pedido.TotalIva;
            pedido.DetallesPedidos = detalleDePedidos;
            return pedido;
        }

        public List<DetallePedido> GenerarDetallesPedido(List<Producto> Productos, List<Descuento> Descuentos)
        {
            List<DetallePedido> detalleDePedidos = new List<DetallePedido>();

            foreach (Producto producto in Productos)
            {
                Descuento descuentoEncontrado = null;
                foreach (Descuento descuento in Descuentos)
                {
                    if (descuento.CodigoProducto == producto.Codigo)
                    {
                        descuentoEncontrado = descuento;
                        break;
                    }
                }
                detalleDePedidos.Add(CalcularDetalle(producto, descuentoEncontrado));
            }
            return detalleDePedidos;
        }

        public DetallePedido CalcularDetalle(Producto producto, Descuento descuento)
        {
            DetallePedido detalleDePedido = new DetallePedido();
            detalleDePedido.Descripcion = producto.Descripcion;
            detalleDePedido.CodProducto = producto.Codigo;
            detalleDePedido.Cantidad = producto.Peso;
            detalleDePedido.ValorUnitario = producto.Precio;

            if (descuento != null)
            {
                detalleDePedido.Descuento = descuento.PorcentajeDescuento;
            }
            else
            {
                detalleDePedido.Descuento = 0;
            }
            detalleDePedido.SubTotal = detalleDePedido.ValorUnitario * detalleDePedido.Cantidad;
            detalleDePedido.TotalDescuento = detalleDePedido.SubTotal * (detalleDePedido.Descuento / 100);
            detalleDePedido.TotalConDescuento = detalleDePedido.SubTotal - detalleDePedido.TotalDescuento;
            detalleDePedido.total = detalleDePedido.SubTotal - detalleDePedido.TotalDescuento;
            detalleDePedido.Codigo = null;
            return detalleDePedido;
        }
    }

    public class PedidoResponse
    {
        public PedidoResponse(Pedido pedido)
        {
            Error = false;
            this.pedido = pedido;
        }
        public PedidoResponse(string mensaje)
        {
            Error = true;
            this.Mensaje = mensaje;
        }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public Pedido pedido { get; set; }
    }
}
