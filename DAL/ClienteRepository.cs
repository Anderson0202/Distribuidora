using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteRepository
    {
        private ConnectionManager connectionManager { get; }

        private SqlConnection connection;

        public ClienteRepository(ConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
            connection = connectionManager._conexion;
        }

        public void Guardar(Cliente cliente)
        {

            using (var command = connection.CreateCommand())
            {

                command.CommandText = "Insert Into CLIENTE (Identificacion, Nombre, Apellido, Telefono, Tipo, Direccion, TipoCliente, Email)" +
                                                  " VALUES (@Identificacion, @Nombre, @Apellido, @Telefono, @Tipo, @Direccion, @TipoCliente, @Email)";
                command.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Tipo", cliente.Tipo);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@TipoCliente", cliente.TipoCliente);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                command.ExecuteNonQuery();

            }

        }

        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> ListaDeClientes = new List<Cliente>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Select * from CLIENTE";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapCliente(dataReader);
                        ListaDeClientes.Add(cliente);
                    }
                }
            }
            return ListaDeClientes;
        }

        private Cliente DataReaderMapCliente(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Cliente cliente = new Cliente();
            cliente.Identificacion = (string)dataReader["Identificacion"];
            cliente.Nombre = (string)dataReader["Nombre"];
            cliente.Apellido = (string)dataReader["Apellido"];
            cliente.Telefono = (string)dataReader["Telefono"];
            cliente.Tipo = (string)dataReader["Tipo"];
            cliente.Direccion = (string)dataReader["Direccion"];
            cliente.TipoCliente = (string)dataReader["TipoCliente"];
            cliente.Email = (string)dataReader["Email"];
            
            return cliente;
        }

    }
}
