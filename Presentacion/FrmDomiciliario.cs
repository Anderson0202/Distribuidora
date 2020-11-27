using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmDomiciliario : Form
    {

        public FrmDomiciliario()
        {
            InitializeComponent();
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
    }
}
