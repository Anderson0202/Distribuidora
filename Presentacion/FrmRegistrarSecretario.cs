﻿using System;
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
        //private VehiculoService vehiculoService;

        public FrmRegistrarSecretario()
        {
            InitializeComponent();
            ConnectionString = ConfigConnection.connectionString;
            //vehiculoService = new VehiculoService(ConnectionString);
        }

        private void PbxCerrarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
