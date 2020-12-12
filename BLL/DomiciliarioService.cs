using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DomiciliarioService
    {

        private ConnectionManager connectionManager;

        public DomiciliarioRepository DomiciliarioRepository { get; set; }

        public DomiciliarioService(string connectionString )
        {

            connectionManager = new ConnectionManager(connectionString);

            DomiciliarioRepository = new DomiciliarioRepository(connectionManager);

        }

        public string Guardar(Domiciliario domiciliario)
        {

            try
            {
                connectionManager.Open();
                DomiciliarioRepository.Guardar(domiciliario);
                return $"Se guardaron los datos del domiciliario satisfactoriamente ";
            }
            catch (Exception e)
            {

                return $"Error de la aplicacion : {e.Message}";

            }
            finally { connectionManager.Close(); }
        }

        public List<Domiciliario> ConsultarTodos()
        {

            try
            {
                connectionManager.Open();
                List<Domiciliario> domiciliario = DomiciliarioRepository.ConsultarTodos();
                connectionManager.Close();
                return domiciliario;
            }
            catch (Exception e)
            {

                return null;
            }
            finally { connectionManager.Close(); }

        }

    }
}
