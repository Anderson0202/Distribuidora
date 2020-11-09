using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            PnlMenu.Width = 0;
           
            
        }

        #region funcionalidad de formulario

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.PnlContenedorPrincipal.Region = region;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        int lx, ly;
        int sw, sh;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void PnlFormularios_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void PnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnlFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            BtnProductos.BackColor = Color.FromArgb(139, 0, 0);
            BtnProductos.ForeColor = Color.FromArgb(244,244,244);
            ReducirPanelMenu();
            
            AbrirFormulario<FrmProductos>();

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms["FrmProducto"]==null)
                BtnProductos.BackColor = Color.FromArgb(224, 224, 224);

            if (Application.OpenForms["FrmPedido"] == null)
                BtnPedido.BackColor = Color.FromArgb(224, 224, 224);

            if (Application.OpenForms["FrmCliente"] == null)
                BtnCliente.BackColor = Color.FromArgb(224, 224, 224);

            if (Application.OpenForms["FrmDomiciliario"] == null)
                BtnDomiciliario.BackColor = Color.FromArgb(224, 224, 224);
            

        }

        private void BtnMenu_Click(object sender, EventArgs e){}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PnlMenu.Width == 0)
            {
                PnlMenu.Width = 152;
             //   if (true)
             //   {

              //  }
             //   new FrmDomiciliario();
            }
            else
            {
                PnlMenu.Width = 0;
            }
        }
          
        private void ReducirPanelMenu()
        {
            if (PnlMenu.Width != 0)
            {
                PnlMenu.Width = 0;
            }
        } 
          

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            ReducirPanelMenu();
            AbrirFormulario<FrmCliente>();
            BtnCliente.BackColor = Color.FromArgb(139, 0, 0);
            BtnCliente.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void BtnPedido_Click(object sender, EventArgs e)
        {
            ReducirPanelMenu();
            AbrirFormulario<FrmPedido>();
            BtnPedido.BackColor = Color.FromArgb(139, 0, 0);
            BtnPedido.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void BtnDomiciliario_Click(object sender, EventArgs e)
        {
            ReducirPanelMenu();
            AbrirFormulario<FrmDomiciliario>();
            BtnDomiciliario.BackColor = Color.FromArgb(139, 0, 0);
            BtnDomiciliario.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

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

    }

}
