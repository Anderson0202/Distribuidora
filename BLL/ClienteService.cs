using DAL;
using Entity;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteService
    {
        private ConnectionManager connectionManager;
        public ClienteRepository ClienteRepository { get; set; }

        public ClienteService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            ClienteRepository = new ClienteRepository(connectionManager);
        }

        public string Guardar(Cliente cliente)
        {
            Email email = new Email();
            string mensajeEmail = string.Empty;
            try
            {
                connectionManager.Open();
                ClienteRepository.Guardar(cliente);
                mensajeEmail = email.EnviarEmail(cliente);
                return $"Se guardaron los datos satisfactoriamente n_n";
            }
            catch (Exception e) 
            {

                return $"Error de la aplicacion : {e.Message}";
            }
            finally { connectionManager.Close(); }
        }

        public List<Cliente> ConsultarTodos()
        {

            try
            {
                connectionManager.Open();
                List<Cliente> clientes = ClienteRepository.ConsultarTodos();
                connectionManager.Close();
                return clientes;
            }
            catch (Exception e)
            {

                return null;
            }
            finally { connectionManager.Close(); }

        }
    }
}
