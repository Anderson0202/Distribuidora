using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DomiciliarioRepository
    {
        private ConnectionManager connectionManager { get; }

        private SqlConnection connection;

        public DomiciliarioRepository(ConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
            connection = connectionManager._conexion;
        }

        public void Guardar(Domiciliario domiciliario)
        {
            using(var command = connection.CreateCommand())
            {

                command.CommandText = "Insert Into DOMICILIARIO (Identificacion, Nombre, Apellido, Telefono, Tipo, FechaVPC)" +
                    " VALUES (@Identificacion, @Nombre, @Apellido, @Telefono, @Tipo, @FechaVPC )";
                command.Parameters.AddWithValue("@Identificacion", domiciliario.Identificacion);
                command.Parameters.AddWithValue("@Nombre", domiciliario.Nombre);
                command.Parameters.AddWithValue("@Apellido", domiciliario.Apellido);
                command.Parameters.AddWithValue("@Telefono", domiciliario.Telefono);
                command.Parameters.AddWithValue("@Tipo", domiciliario.Tipo);
                command.Parameters.AddWithValue("@FechaVPC", domiciliario.FechaVencimientoPermisoConduccion);
                command.ExecuteNonQuery();

            }
        }

        public List<Domiciliario> ConsultarTodos()
        {

            List<Domiciliario> ListaDeDomiciliarios = new List<Domiciliario>();

            using (var command = connection.CreateCommand())
            {

                command.CommandText = "Select * from DOMICILIARIO";

                var dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {

                    while (dataReader.Read())
                    {

                        Domiciliario domicicilario = DataReaderMapDomiciliario(dataReader);
                        ListaDeDomiciliarios.Add(domicicilario);

                    }

                }

            }

            return ListaDeDomiciliarios;

        }

        private Domiciliario DataReaderMapDomiciliario(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Domiciliario domiciliario = new Domiciliario();
            domiciliario.Identificacion = (string)dataReader["Identificacion"];
            domiciliario.Nombre = (string)dataReader["Nombre"];
            domiciliario.Apellido = (string)dataReader["Apellido"];
            domiciliario.Telefono = (string)dataReader["Telefono"];
            domiciliario.Tipo = (string)dataReader["Tipo"];
            domiciliario.FechaVencimientoPermisoConduccion = (DateTime)dataReader["FechaVPC"];
            //domiciliario.Moto = (Vehiculo)dataReader["Moto"];
            return domiciliario;
        }

        private bool EsEncontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }

        public Domiciliario Buscar(string identificacion)
        {
            List<Domiciliario> domiciliarios = ConsultarTodos();
            foreach (var item in domiciliarios)
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
