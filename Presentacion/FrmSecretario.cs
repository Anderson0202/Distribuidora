using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmSecretario : Form
    {
        private string ConnectionString;
        private SecretarioService secretarioService;

        public FrmSecretario()
        {
            InitializeComponent();
            ConnectionString = ConfigConnection.connectionString;
            secretarioService = new SecretarioService(ConnectionString);
            TblListaSecretarios.DataSource = secretarioService.ConsultarTodos();
        }


        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;

            formulario = PnlFormulario.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PnlFormulario.Controls.Add(formulario);
                PnlFormulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {

                formulario.BringToFront();
            }

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms["FrmRegistrarSecretario"] == null)
                BtnRegistrar.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void BtnPedido_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarSecretario>();
            BtnRegistrar.BackColor = Color.FromArgb(139, 0, 0);
            BtnRegistrar.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarSecretario>();
            BtnRegistrar.BackColor = Color.FromArgb(139, 0, 0);
            BtnRegistrar.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void PbxCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarSecretario>();
        }
    }
}
