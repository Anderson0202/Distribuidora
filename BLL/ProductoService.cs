using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoService
    {
        private ConnectionManager connectionManager;
        public ProductoRepository ProductoRepository { get; set; }
        public ProductoService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            ProductoRepository = new ProductoRepository(connectionManager);
        }

        public string Guardar(Producto producto)
        {
            try
            {
                connectionManager.Open();
                ProductoRepository.Guardar(producto);
                return $"Se guardaron los datos satisfactoriamente n_n";
            }
            catch (Exception e)
            {

                return $"Error de la aplicacion : {e.Message}";
            }
            finally { connectionManager.Close(); }
        }

        public List<Producto> ConsultarTodos()
        {

            try
            {
                connectionManager.Open();
                List<Producto> productos = ProductoRepository.ConsultarTodos();
                connectionManager.Close();
                return productos;
            }
            catch (Exception e)
            {

                return null;
            }
            finally { connectionManager.Close(); }

        }

        
        public Producto BuscarxCodigo(string codigo)
        {
            connectionManager.Open();
            Producto producto = ProductoRepository.BuscarPorCodigo(codigo);
            connectionManager.Close();
            if (producto == null)
            {
                return null;
            }
            return producto;
        }

    }
}
