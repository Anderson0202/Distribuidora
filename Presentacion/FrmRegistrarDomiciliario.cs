﻿using BLL;
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
    public partial class FrmRegistrarDomiciliario : Form
    {
        private string ConnectionString;
        private VehiculoService vehiculoService;
        private DomiciliarioService domiciliarioService;
        public FrmRegistrarDomiciliario()
        {
            InitializeComponent();
            ConnectionString = ConfigConnection.connectionString;
            vehiculoService = new VehiculoService(ConnectionString);
            domiciliarioService = new DomiciliarioService(ConnectionString);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void PbxCerrarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Vehiculo vehiculo = new Vehiculo();

            vehiculo.Placa = TxtPlaca.Text;
            vehiculo.FechaVencimientoSoat = Convert.ToDateTime(TxtSoat.Text);
            vehiculo.FechaVenciciemtoTecnoMecanica = Convert.ToDateTime(TxtTecnoMecanica.Text);
            
            
            Domiciliario domiciliario = new Domiciliario();

            domiciliario.Identificacion = txIdentificacion.Text;
            domiciliario.Nombre = txNombre.Text;
            domiciliario.Apellido = txApellido.Text;
            domiciliario.Telefono = txTelefono.Text;
            domiciliario.Tipo = "domiciliario";
            domiciliario.FechaVencimientoPermisoConduccion = Convert.ToDateTime(txFvpc.Text);
            domiciliario.Moto = vehiculo;

            String mensaje1 = domiciliarioService.Guardar(domiciliario);
            String mensaje = vehiculoService.Guardar(vehiculo, domiciliario.Identificacion);


            MessageBox.Show(mensaje, mensaje1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PnlFormularioRegistrarDomicliario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSoat_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTecnoMecanica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
