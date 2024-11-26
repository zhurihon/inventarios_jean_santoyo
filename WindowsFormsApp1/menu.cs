using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butt2close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butt2min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttclose_Click(object sender, EventArgs e)
        {

        }

        private void buttmin_Click(object sender, EventArgs e)
        {

        }

        private void bttmax(object sender, EventArgs e)
        {

        }

        private void bttrest(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panelconter_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public static implicit operator Menu(menu v)
        {
            throw new NotImplementedException();
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void flowLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmhidemen_Tick(object sender, EventArgs e)
        {
            if (panel1.Width <= 60)
            {
                tmhidemen.Enabled = false;
            }
            else
            {
                panel1.Width -= 20;
            }

        }

        private void tmshowmen_Tick(object sender, EventArgs e)
        {
            if (panel1.Width >= 160)
            {
                tmshowmen.Enabled = false;
            }
            else
            {
                panel1.Width += 20;
            }

        }

        private void btextenmenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 160)
            {
                tmhidemen.Enabled = true;
            }
            else if (panel1.Width == 60)
                    {
                tmshowmen.Enabled = true;
            }


        }

        private void buttfact_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Verificamos si el panel tiene controles
            if (panelconter.Controls.Count > 0)
            {
                panelconter.Controls.Clear(); // Eliminamos todos los controles existentes
            }

            // Agregamos el formulario hijo al panel

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelconter.Controls.Add(formularioHijo);
            panelconter.Tag = formularioHijo;
            formularioHijo.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new factura());
        }

        private void panelconter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Inventario());
        }
    }
}


    

