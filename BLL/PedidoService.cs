using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class PedidoService
    {

        private ConnectionManager connectionManager;
        public ClienteRepository ClienteRepository;

        private PedidoRepository PedidoRepository;

        public PedidoService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            ClienteRepository = new ClienteRepository(connectionManager);
            PedidoRepository = new PedidoRepository(connectionManager);
        }

        public List<Pedido> ConsultarPedidos()
        {
            List<Pedido> pedidos = PedidoRepository.ConsultarTodos();
            return pedidos;
        }


        public PedidoResponse Guardar(Pedido pedido)
        {
            try
            {
                Pedido pedido1 = InicializarCodigos(pedido);
                connectionManager.Open();
                PedidoRepository.Guardar(pedido1);
                connectionManager.Close();
                foreach (DetallePedido detalle in pedido.DetallesPedidos)
                {
                    connectionManager.Open();
                    PedidoRepository.GuardarDetalle(detalle);
                    connectionManager.Close();
                }
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
            connectionManager.Open();
            int cantidadPedidosRegistrados = PedidoRepository.CodigoDetallePedido();
            connectionManager.Close();
            bool Parar = true;
            while (Parar)
            {
                connectionManager.Open();
                DetallePedido detalleDePedido = PedidoRepository.BuscarPorCodigoDetalle(cantidadPedidosRegistrados.ToString());
                connectionManager.Close();
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
            connectionManager.Open();
            int cantidadPedidosRegistrados = PedidoRepository.CodigoPedido();
            connectionManager.Close();
            bool Parar = true;
            while (Parar)
            {
                connectionManager.Open();
                Pedido pedidoEncontrado = PedidoRepository.BuscarPorCodigoPedido(cantidadPedidosRegistrados.ToString());
                connectionManager.Close();
                    
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
            /* Metodo que trae de la base de datos los descuentos registrados del cliente qie se recive por parametros*/
            List<Descuento> Descuentos = new List<Descuento>(); 
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
            //detalleDePedido.Descripcion = producto.Descripcion;
            detalleDePedido.CodigoProducto = producto.Codigo;
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
            detalleDePedido.Total = detalleDePedido.SubTotal - detalleDePedido.TotalDescuento;
            detalleDePedido.Codigo = null;
            return detalleDePedido;
        }

       

        public Cliente BuscarxIdentificacion(string identificacion)
        {
            connectionManager.Open();
            Cliente cliente = ClienteRepository.BuscarPorIdentificacion(identificacion);
            connectionManager.Close();
            if (cliente == null)
            {
                return null;
            }
            return cliente;
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
