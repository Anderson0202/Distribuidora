using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DescuentoRepository
    {

        private ConnectionManager connectionManager { get; }

        private SqlConnection connection;

        public DescuentoRepository(ConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
            connection = connectionManager._conexion;
        }


        public List<Descuento> ConsultarTodosDescuentosClientes()
        {

            List<Descuento> ListaDescuentos = new List<Descuento>();

            using (var command = connection.CreateCommand())
            {

                command.CommandText = "Select * from DESCUENTO";

                var dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {

                    while (dataReader.Read())
                    {

                        Descuento descuento = DataReaderMapDescuento(dataReader);
                        ListaDescuentos.Add(descuento);

                    }

                }

            }

            return ListaDescuentos;

        }

        public List<Descuento> ConsultarxDescuentoCliente(string Id)
        {

            List<Descuento> ListaDescuentos = new List<Descuento>();

            using (var command = connection.CreateCommand())
            {

                command.CommandText = "Select * from DESCUENTO where idCliente = @Id";
                command.Parameters.AddWithValue("@Id", Id);

                var dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {

                    while (dataReader.Read())
                    {

                        Descuento descuento = DataReaderMapDescuento(dataReader);
                        ListaDescuentos.Add(descuento);

                    }

                }

            }

            return ListaDescuentos;

        }

        private Descuento DataReaderMapDescuento(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Descuento descuento = new Descuento();
            descuento.PorcentajeDescuento = (double)dataReader["PorcentajeDescuento"];
            descuento.CodigoDescuento = (string)dataReader["CodigoDescuento"];
            descuento.CodigoProducto = (string)dataReader["CodigoProducto"];
            descuento.identificacionPersona = (string)dataReader["identificacionPersona"];
             

            return descuento;
        }

    }
}
