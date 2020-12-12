using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SecretarioRepository
    {

        private ConnectionManager connectionManager { get; }

        private SqlConnection connection;

        public SecretarioRepository(ConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
            connection = connectionManager._conexion;
        }

        public void Guardar(Secretario secretario)
        {
            using (var command = connection.CreateCommand())
            {

                command.CommandText = "Insert Into SECRETARIO (Identificacion, Nombre, Apellido, Telefono, Tipo, FechaContrato)" +
                    " VALUES (@Identificacion, @Nombre, @Apellido, @Telefono, @Tipo, @FechaContrato )";
                command.Parameters.AddWithValue("@Identificacion", secretario.Identificacion);
                command.Parameters.AddWithValue("@Nombre", secretario.Nombre);
                command.Parameters.AddWithValue("@Apellido", secretario.Apellido);
                command.Parameters.AddWithValue("@Telefono", secretario.Telefono);
                command.Parameters.AddWithValue("@Tipo", secretario.Tipo);
                command.Parameters.AddWithValue("@FechaContrato", secretario.FechaContrato);
                command.ExecuteNonQuery();

            }
        }

        public List<Secretario> ConsultarTodos()
        {

            List<Secretario> ListaDeSecretarios = new List<Secretario>();

            using (var command = connection.CreateCommand())
            {

                command.CommandText = "Select * from SECRETARIO";

                var dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {

                    while (dataReader.Read())
                    {

                        Secretario secretario = DataReaderMapSecretario(dataReader);
                        ListaDeSecretarios.Add(secretario);

                    }

                }

            }

            return ListaDeSecretarios;

        }

        private Secretario DataReaderMapSecretario(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Secretario secretario = new Secretario();
            secretario.Identificacion = (string)dataReader["Identificacion"];
            secretario.Nombre = (string)dataReader["Nombre"];
            secretario.Apellido = (string)dataReader["Apellido"];
            secretario.Telefono = (string)dataReader["Telefono"];
            secretario.Tipo = (string)dataReader["Tipo"];
            secretario.FechaContrato = (DateTime)dataReader["FechaContrato"];
            
            return secretario;
        }

        private bool EsEncontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }

        public Secretario Buscar(string identificacion)
        {
            List<Secretario> secretarios = ConsultarTodos();
            foreach (var item in secretarios)
            {
                if (EsEncontrado(item.Identificacion, identificacion))
                {
                    return item;
                }
            }
            return null;
        }

    }
}
