using BLL;
using Entity;
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
    public partial class FrmRegistrarSecretario : Form
    {
        private string ConnectionString;
        private SecretarioService secretarioService;

        public FrmRegistrarSecretario()
        {
            InitializeComponent();
            ConnectionString = ConfigConnection.connectionString;
            secretarioService = new SecretarioService(ConnectionString);
            
        }

        private void PbxCerrarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Secretario secretario = new Secretario();

            secretario.Identificacion = txIdentificacion.Text;
            secretario.Nombre = txNombre.Text;
            secretario.Apellido = txApellido.Text;
            secretario.Telefono = txTelefono.Text;
            secretario.Tipo = "secretario";
            secretario.FechaContrato = Convert.ToDateTime(txFechaContrato.Text);

            String mensaje = secretarioService.Guardar(secretario);

            MessageBox.Show(mensaje);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
