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
    public partial class acceso : Form
    {
        public acceso()
        {
            InitializeComponent();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new menu();
            formulario.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textuser_enter(object sender, EventArgs e)
        {
            if (textuser.Text== "Usuario") {
                textuser.Text = "";
                textuser.ForeColor =Color.LightGray;
            }
        }
        private void textuser_Leave(object sender, EventArgs e)
        {
            if (textuser.Text == "") {
                textuser.Text = "Usuario";
                textuser.ForeColor = Color.Black;
            }
        
        }

        private void textpass_enter(object sender, EventArgs e)
        {
            if (textpass.Text == "contraseña")
            {
                textpass.Text = "";
                textpass.ForeColor = Color.LightGray;
                textpass.UseSystemPasswordChar = true;
            }
        }
        private void textpass_Leave(object sender, EventArgs e)
        {
            if (textpass.Text == "")
            {
                textpass.Text = "contraseña ";
                textpass.ForeColor = Color.Black;
                textpass.UseSystemPasswordChar = false;
            }

        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
              ReleaseCapture();
  SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void v_Load(object sender, EventArgs e)
        {

        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
