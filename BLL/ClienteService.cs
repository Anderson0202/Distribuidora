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
        public ClienteRepository ClienteRepository;

        public ClienteService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            ClienteRepository = new ClienteRepository(connectionManager);
        }

        public GuardarClienteResponse Guardar(Cliente cliente)
        {
            try
            {

                if (BuscarxIdentificacion(cliente.Identificacion)==null)
                {
                    connectionManager.Open();
                    ClienteRepository.Guardar(cliente);
                    connectionManager.Close();
                    return new GuardarClienteResponse(cliente);
                }
                return new GuardarClienteResponse($"Cliente Existente ");
            }
            catch (Exception e)
            {
                return new GuardarClienteResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally { connectionManager.Close(); }
        }

        public Cliente BuscarxIdentificacion(string identificacion)
        {
            connectionManager.Open();
            Cliente cliente= ClienteRepository.BuscarPorIdentificacion(identificacion);
            connectionManager.Close();
            if (cliente == null)
            {
                return null;
            }
            return cliente;
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
    public class GuardarClienteResponse
    {
        public GuardarClienteResponse(Cliente cliente)
        {
            Error = false;
            Cliente = cliente;
        }
        public GuardarClienteResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente Cliente { get; set; }
    }
}
