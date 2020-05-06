using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMA
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnTelefonos_Click(object sender, EventArgs e)
        {
            Agenda frmContactos = new Agenda();
            frmContactos.ShowDialog();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Registrar frmRegistro = new Registrar();
            frmRegistro.ShowDialog();
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            Cita_Medica frmCita = new Cita_Medica();
            frmCita.ShowDialog();
        }
    }
}
