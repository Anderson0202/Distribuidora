using Entity;
using System;
using System.Windows.Forms;
using BLL;

namespace Presentacion
{
    public partial class FrmRegistrarProducto : Form
    {
        private string ConnectionString;
        private ProductoService productoService;
        public FrmRegistrarProducto()
        {
            InitializeComponent();
            ConnectionString = ConfigConnection.connectionString;
            productoService = new ProductoService(ConnectionString);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PbxCerrarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Codigo = txReferencia.Text;
            producto.Peso = Convert.ToDouble(txPeso.Text);
            producto.Precio = Convert.ToDouble(txPrecio.Text);
            producto.Categoria = cmbCategoria.Text;
            producto.Nombre = txNombre.Text;
            producto.PesoMinimo = Convert.ToDouble(txPesoMinimo.Text);
            String mensaje = productoService.Guardar(producto);
            MessageBox.Show(mensaje);
        }
    }
}
