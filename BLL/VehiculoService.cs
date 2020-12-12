using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class VehiculoService
    {

        private ConnectionManager connectionManager;
        public VehiculoRepository VehiculoRepository { get; set; }

        public VehiculoService(string ConnectionString)
        {
            connectionManager = new ConnectionManager(ConnectionString);
            VehiculoRepository = new VehiculoRepository(connectionManager);

        }

        public string Guardar(Vehiculo vehiculo, string idDomiciliario)
        {
            try
            {
                connectionManager.Open();
                VehiculoRepository.Guardar(vehiculo, idDomiciliario);
                return $"Se guardaron los datos satisfactoriamente n_n";
            }
            catch (Exception e)
            {

                return $"Error de la aplicacion : {e.Message}";
            }
            finally { connectionManager.Close(); }
        }

        public List<Vehiculo> ConsultarTodos()
        {

            try
            {
                connectionManager.Open();
                List<Vehiculo> vehiculo = VehiculoRepository.ConsultarTodos();
                connectionManager.Close();
                return vehiculo;
            }
            catch (Exception e)
            {

                return null;
            }
            finally { connectionManager.Close(); }

        }

    }
}
