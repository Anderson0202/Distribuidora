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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistraProducto>();
            BtnRegistrar.BackColor = Color.FromArgb(139, 0, 0);
            BtnRegistrar.ForeColor = Color.FromArgb(244, 244, 244);
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

            if (Application.OpenForms["FrmRegistrarProducto"] == null)
                BtnRegistrar.BackColor = Color.FromArgb(224, 224, 224);

            if (Application.OpenForms["FrmConsultarProducto"] == null)
                BtnConsultar.BackColor = Color.FromArgb(224, 224, 224);

            if (Application.OpenForms["FrmCliente"] == null)
                BtnEditar.BackColor = Color.FromArgb(224, 224, 224);

            if (Application.OpenForms["FrmDomiciliario"] == null)
                BtnEliminar.BackColor = Color.FromArgb(224, 224, 224);


        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmConsultarProducto>();
            BtnConsultar.BackColor = Color.FromArgb(139, 0, 0);
            BtnConsultar.ForeColor = Color.FromArgb(244, 244, 244);
        }
    }
}
