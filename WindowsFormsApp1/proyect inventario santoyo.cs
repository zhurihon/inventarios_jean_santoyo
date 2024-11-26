using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ventana_de_carga : Form
    {
        Form2 ventana_acceso;
        public ventana_de_carga()
        {
            InitializeComponent();
            ventana_acceso = new Form2();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                label1.Text = $"Carga del sistema al {progressBar1.Value}%";
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                ventana_acceso.ShowDialog();
            }
        }
    }

    public partial class Form2 : Form
    {

    }
    
}

