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
    public partial class FrmDomiciliario : Form
    {

        public FrmDomiciliario()
        {
            InitializeComponent();
        }

        public FrmDomiciliario(int ancho)
        {
            PnlMenuDomiciliario.Width = ancho;
        }

        private void FrmDomiciliario_Load(object sender, EventArgs e)
        {

        }

    }
}
