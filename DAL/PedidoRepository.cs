using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PedidoRepository
    {

        private ConnectionManager connectionManager { get; }

        private SqlConnection connection;

        public PedidoRepository(ConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
            connection = connectionManager._conexion;
        }

        public void Guardar(Pedido pedido)
        {
            using (var command = connection.CreateCommand())
            {

                command.CommandText = "Insert Into PEDIDO (Codigo, Fecha, SubTotal, Iva, TotalIva, Total, Descuento, Fk_IdCliente )" +
                    " VALUES (@Codigo, @Fecha, @SubTotal, @Iva, @TotalIva, @Total, @Descuento, @Fk_IdCliente )";
                command.Parameters.AddWithValue("@Codigo", pedido.Codigo.ToString());
                command.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                command.Parameters.AddWithValue("@SubTotal", pedido.SubTotal);
                command.Parameters.AddWithValue("@Iva", pedido.Iva);
                command.Parameters.AddWithValue("@TotalIva", pedido.TotalIva);
                command.Parameters.AddWithValue("@Total", pedido.Total);
                command.Parameters.AddWithValue("@Descuento", pedido.Descuento);
                command.Parameters.AddWithValue("@Fk_IdCliente", pedido.IdPersona.ToString());

                command.ExecuteNonQuery();

            }
        }

        public int CodigoPedido()
        {
            SqlDataReader dataReader;
            int codigo = 0;
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Select count(*) from PEDIDO";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        codigo = dataReader.GetInt32(0);
                    }
                }
            }
            return codigo;
        }
        public int CodigoDetallePedido()
        {
            SqlDataReader dataReader;
            int codigo = 0;
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Select count(*) from DETALLEPEDIDO";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        codigo = dataReader.GetInt32(0);
                    }
                }
            }
            return codigo;
        }
       

        public List<Pedido> ConsultarTodos()
        {

            List<Pedido> ListaDePedidos = new List<Pedido>();

            using (var command = connection.CreateCommand())
            {

                command.CommandText = "Select * from PEDIDO";

                var dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {

                    while (dataReader.Read())
                    {

                        Pedido pedido = DataReaderMapPedido(dataReader);
                        ListaDePedidos.Add(pedido);

                    }

                }

            }

            return ListaDePedidos;

        }

        private Pedido DataReaderMapPedido(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Pedido pedido = new Pedido();
            pedido.Codigo = (string)dataReader["Codigo"];
            pedido.Fecha = (DateTime)dataReader["Fecha"];
            pedido.SubTotal = (double)dataReader["SubTotal"];
            pedido.Iva = (double)dataReader["Iva"];
            pedido.TotalIva = (double)dataReader["TotalIva"];
            pedido.Descuento = (double)dataReader["Descuento"];

            return pedido;
        }

        public DetallePedido BuscarPorCodigoDetalle(string Codigo)
        {
            SqlDataReader dataReader;
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from DETALLEPEDIDO where codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", Codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapDetallePedido(dataReader);
            }
        }
        public Pedido BuscarPorCodigoPedido(string Codigo)
        {
            SqlDataReader dataReader;
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from PEDIDO where codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", Codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapPedido(dataReader);
            }
        }

        public DetallePedido DataReaderMapDetallePedido(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            DetallePedido detallePedido = new DetallePedido();
            detallePedido.Codigo = (string)dataReader["Codigo"];
            detallePedido.CodPedido = (string)dataReader["CodigoPedido"];
            detallePedido.CodigoProducto = (string)dataReader["CodigoProducto"];
            detallePedido.Descripcion = (string)dataReader["Descripcion"];
            detallePedido.Descuento = (double)dataReader["Descuento"];
            detallePedido.Cantidad = (double)dataReader["Cantidad"];
            detallePedido.ValorUnitario = (double)dataReader["ValorUnitario"];
            detallePedido.TotalDescuento = (double)dataReader["TotalDescuento"];
            detallePedido.SubTotal = (double)dataReader["SubTotal"];
            detallePedido.TotalConDescuento = (double)dataReader["TotalConDescuento"];
            detallePedido.Total = (double)dataReader["Total"];

            return detallePedido;
        }

        public void GuardarDetalle(DetallePedido detallePedido)
        {
            using (var command = connection.CreateCommand())
            {
                detallePedido.Descripcion = "Descripción";
                command.CommandText = "Insert Into DETALLEPEDIDO (Codigo, CodigoPedido, CodigoProducto, Descripcion, Descuento, Cantidad, ValorUnitario, TotalDescuento, SubTotal, TotalConDescuento, Total )" +
                    " VALUES (@Codigo, @CodigoPedido, @CodigoProducto, @Descripcion, @Descuento, @Cantidad, @ValorUnitario, @TotalDescuento, @SubTotal, @TotalConDescuento, @Total )";
                command.Parameters.AddWithValue("@Codigo", detallePedido.Codigo.ToString());
                command.Parameters.AddWithValue("@CodigoPedido", detallePedido.CodPedido.ToString());
                command.Parameters.AddWithValue("@CodigoProducto", detallePedido.CodigoProducto.ToString());
                command.Parameters.AddWithValue("@Descripcion", detallePedido.Descripcion.ToString());
                command.Parameters.AddWithValue("@Descuento", detallePedido.Descuento);
                command.Parameters.AddWithValue("@Cantidad", detallePedido.Cantidad);
                command.Parameters.AddWithValue("@ValorUnitario", detallePedido.ValorUnitario);
                command.Parameters.AddWithValue("@TotalDescuento", detallePedido.TotalDescuento);
                command.Parameters.AddWithValue("@SubTotal", detallePedido.SubTotal);
                command.Parameters.AddWithValue("@TotalConDescuento", detallePedido.TotalConDescuento);
                command.Parameters.AddWithValue("@Total", detallePedido.Total);

                command.ExecuteNonQuery();

            }
        }

        private bool EsEncontrado(string codigoRegistrado, string codigoBuscado)
        {
            return codigoRegistrado == codigoBuscado;
        }

        public Pedido Buscar(string codigo)
        {
            List<Pedido> pedido = ConsultarTodos();
            foreach (var item in pedido)
            {
                if (EsEncontrado(item.Codigo, codigo))
                {
                    return item;
                }
            }
            return null;
        }


    }


}
