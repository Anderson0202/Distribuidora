using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SecretarioService
    {

        private ConnectionManager connectionManager;

        public SecretarioRepository secretarioRepository { get; set; }

        public SecretarioService(string connectionString)
        {

            connectionManager = new ConnectionManager(connectionString);

            secretarioRepository = new SecretarioRepository(connectionManager);

        }

        public string Guardar(Secretario secretario)
        {

            try
            {
                connectionManager.Open();
                secretarioRepository.Guardar(secretario);
                return $"Se guardaron los datos del secretario satisfactoriamente ";
            }
            catch (Exception e)
            {

                return $"Error de la aplicacion : {e.Message}";

            }
            finally { connectionManager.Close(); }
        }

        public List<Secretario> ConsultarTodos()
        {

            try
            {
                connectionManager.Open();
                List<Secretario> secretario = secretarioRepository.ConsultarTodos();
                connectionManager.Close();
                return secretario;
            }
            catch (Exception e)
            {

                return null;
            }
            finally { connectionManager.Close(); }

        }

    }
}
