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
        public VehiculoRepository(ConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
            connection = connectionManager._conexion;
        }

        private ConnectionManager connectionManager { get; }

        private SqlConnection connection;

        public void Guardar(Vehiculo vehiculo)
        {
            using(var command = connection.CreateCommand()) 
            {


                command.CommandText = "Insert Into Vehiculo (PLACA, FECHAVENCIMIENTOSOAT, FechaVencimientoTecnoMecanica )" +
                    " VALUES (@PLACA, @FECHAVENCIMIENTOSOAT, @FechaVencimientoTecnoMecanica )";
                command.Parameters.AddWithValue("@PLACA",vehiculo.Placa);
                command.Parameters.AddWithValue("@FECHAVENCIMIENTOSOAT", vehiculo.FechaVencimientoSoat);
                command.Parameters.AddWithValue("@FechaVencimientoTecnoMecanica", vehiculo.FechaVenciciemtoTecnoMecanica);
                command.ExecuteNonQuery();
                

            }
            

        }

    }
}
