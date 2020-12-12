using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class VehiculoRepository
    {
        private ConnectionManager connectionManager { get; }

        private SqlConnection connection;
                
        public VehiculoRepository(ConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
            connection = connectionManager._conexion;
        }


        public void Guardar(Vehiculo vehiculo, string idDomiciliario)
        {
            using(var command = connection.CreateCommand()) 
            {

                command.CommandText = "Insert Into Vehiculo (Placa, FechaVS, FechaVTM, Fk_IdDomiciliario )" +
                    " VALUES (@Placa, @FechaVS, @FechaVTM, @Fk_IdDomiciliario )";
                command.Parameters.AddWithValue("@Placa", vehiculo.Placa);
                command.Parameters.AddWithValue("@FechaVS", vehiculo.FechaVencimientoSoat);
                command.Parameters.AddWithValue("@FechaVTM", vehiculo.FechaVenciciemtoTecnoMecanica);
                command.Parameters.AddWithValue("@Fk_IdDomiciliario", idDomiciliario);
                command.ExecuteNonQuery();
                
            }
            
        }

        public List<Vehiculo> ConsultarTodos()
        {
            List<Vehiculo> ListaDeVehiculos = new List<Vehiculo>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Select * from VEHICULO";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Vehiculo vehiculo = DataReaderMapVehiculo(dataReader);
                        ListaDeVehiculos.Add(vehiculo);
                    }
                }
            }
            return ListaDeVehiculos;
        }

        private Vehiculo DataReaderMapVehiculo(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = (string)dataReader["Placa"];
            vehiculo.FechaVencimientoSoat = (DateTime.Parse(dataReader["FechaVS"].ToString()));
            vehiculo.FechaVenciciemtoTecnoMecanica = (DateTime.Parse(dataReader["FechaVTM"].ToString()));
            
            return vehiculo;
        }

    }
}
