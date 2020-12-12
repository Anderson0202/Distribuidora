using BLL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmDomiciliario : Form
    {
        private string ConnectionString;
        private VehiculoService vehiculoService;
        private DomiciliarioService domiciliarioService;
        public FrmDomiciliario()
        {
            InitializeComponent();
            ConnectionString = ConfigConnection.connectionString;
            vehiculoService = new VehiculoService(ConnectionString);
            domiciliarioService = new DomiciliarioService(ConnectionString);
            TblListaDomiciliarios.DataSource = domiciliarioService.ConsultarTodos();
            TblListaVehiculos.DataSource = vehiculoService.ConsultarTodos();
        }



        private void FrmDomiciliario_Load(object sender, EventArgs e)
        {

        }


        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;

            formulario = PnlFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PnlFormularios.Controls.Add(formulario);
                PnlFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {

                formulario.BringToFront();
            }

        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarDomiciliario>();
            BtnRegistrar.BackColor = Color.FromArgb(139, 0, 0);
            BtnRegistrar.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms["FrmRegistrarDomiciliario"] == null)
                BtnRegistrar.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TblListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarDomiciliario>();
            BtnRegistrar.BackColor = Color.FromArgb(139, 0, 0);
            BtnRegistrar.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void PbxCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarDomiciliario>(); 
        }

        private void BtnVerDetalle_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void PnlBuscarUnCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
