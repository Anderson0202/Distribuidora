using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmRegistrarPedido : Form
    {
        private string ConnectionString;
        private PedidoService pedidoService;
        private ProductoService productoService;
        private ClienteService clienteService;
        Cliente cliente;
        Pedido pedido;
        Producto Producto;


        List<Producto> productos;
        public FrmRegistrarPedido()
        {
            InitializeComponent();
            ConnectionString = ConfigConnection.connectionString;
            pedidoService = new PedidoService(ConnectionString);
            productoService = new ProductoService(ConnectionString);
            clienteService = new ClienteService(ConnectionString);
            productos = new List<Producto>();
            cargar();
        }
        
        /// /////////////////////--------------------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        
        private void cargar()
        {
            DtgDetalle.Columns.Add("Codigo Producto", "Codigo Producto");
            DtgDetalle.Columns.Add("Cantidad", "Cantidad");
            DtgDetalle.Columns.Add("Valor unitario", "Valor unitario");
            DtgDetalle.Columns.Add("Subtotal", "Subtotal");
            DtgDetalle.Columns.Add("Total", "Total");
        }

        private void FrmRegistrarPedido_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PbxCerrarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Mensaje(Convert.ToString(pedidoService.Guardar(pedido)));
            var guardaPedido = pedidoService.Guardar(pedido);
            if (guardaPedido.Error) 
            {
                Mensaje(guardaPedido.Mensaje);
            }
            else
            {
                Mensaje("pedido registrado correctamente");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (txIdentificacion.Text.Trim() == "")
            {
                Mensaje("Digite la identificacion");
            }
            else
            {
                cliente = clienteService.BuscarxIdentificacion(txIdentificacion.Text.Trim());
                if (cliente == null)
                {
                    Mensaje("No existe el cliente.");
                }
                else
                {
                    txNombre.Text = cliente.Nombre;
                    txTelefono.Text = cliente.Apellido;
                    txDireccion.Text = cliente.Telefono;
                }
            }
        }

        private void Mensaje(String msm)
        {
            MessageBox.Show(msm);
        }

        private void AgregarEnTxt(List<Cliente> cliente)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txCantidad.Text.Trim() == "")
            {
                Mensaje("Debe ingresar la cantidad a agregar");
            }
            else if (Producto == null)
            {
                Mensaje("Debe buscar un producto.");
            }
            else if (cliente == null)
            {
                Mensaje("Debe buscar un cliente");
            }
            else
            {
                Producto.Peso = double.Parse(txCantidad.Text.Trim());
                productos.Add(Producto);
                pedido = pedidoService.GenerarPedido(productos, cliente);
                AgregarEnLaTabla(pedido.DetallesPedidos);
                TxtSubTotal.Text = pedido.SubTotal.ToString();
                TxtTotal.Text = pedido.Total.ToString();
                TxtTotalIva.Text = pedido.TotalIva.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (TxCodigoProducto.Text.Trim() == "")
            {
                Mensaje("Debe ingresar el codigo del producto.");
            }
            else
            {
                Producto = productoService.BuscarxCodigo(TxCodigoProducto.Text.Trim());
                if (Producto == null)
                {
                    MessageBox.Show("Producto inexistente");
                }
                else
                {
                    txPeso.Text = Producto.Peso.ToString();
                    txPrecio.Text = Producto.Precio.ToString();
                    txCategoria.Text = Producto.Categoria;
                }
            }
        }

        private void TxCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }
        
        /// //////////////////////////////////////////////////////////////
        
        private void AgregarEnLaTabla(List<DetallePedido> detalles)
        {

            DtgDetalle.Rows.Clear();
            foreach (DetallePedido detalle in detalles)
            {
                string[] row1 = new string[] { detalle.CodigoProducto, detalle.Cantidad.ToString(), detalle.ValorUnitario.ToString(),detalle.SubTotal.ToString(), detalle.Total.ToString() };
                DtgDetalle.Rows.Add(row1);
            }
            
        }


    }
}
