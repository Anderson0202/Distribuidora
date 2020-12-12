using Entity;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductoRepository
    {
        private ConnectionManager connectionManager { get; }

        private SqlConnection connection;

        public ProductoRepository(ConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
            connection = connectionManager._conexion;
        }

        public void Guardar(Producto producto )
        {

            using (var command = connection.CreateCommand())
            {

                command.CommandText = "Insert Into PRODUCTO (Codigo, Peso, Precio, Categoria, Nombre, PesoMinimo)" +
                                      " VALUES (@Codigo, @Peso, @Precio, @Categoria, @Nombre, @PesoMinimo)";
                command.Parameters.AddWithValue("@Codigo", producto.Codigo);
                command.Parameters.AddWithValue("@Peso", producto.Peso);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Categoria", producto.Categoria);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@PesoMinimo", producto.PesoMinimo);
                command.ExecuteNonQuery();

            }

        }

        public List<Producto> ConsultarTodos()
        {
            List<Producto> ListaDeProductos = new List<Producto>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Select * from PRODUCTO";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapProducto(dataReader);
                        ListaDeProductos.Add(producto);
                    }
                }
            }
            return ListaDeProductos;
        }

        private Producto DataReaderMapProducto(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto();
            producto.Codigo = (string)dataReader["Codigo"];
            producto.Peso = (double.Parse(dataReader["Peso"].ToString()));
            producto.Precio = double.Parse(dataReader["Precio"].ToString());
            producto.Categoria = (string)dataReader["Categoria"];
            producto.Nombre = (string)dataReader["Nombre"];
            producto.PesoMinimo = (double.Parse(dataReader["PesoMinimo"].ToString()));
            return producto;
        }

        public Producto BuscarPorCodigo(string codigo)
        {
            SqlDataReader dataReader;
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from PRODUCTO where Codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapProducto(dataReader);
            }
        }

    }
}
