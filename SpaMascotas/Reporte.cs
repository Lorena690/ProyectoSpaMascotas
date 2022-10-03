using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASE2_SPAMASCOTAS
{
    internal partial class Reporte : Form
    {

        private SpaMascotas spaMascotas;
        public Reporte(SpaMascotas spa)
        {
            spaMascotas = spa;
            InitializeComponent();
            NombreBox.Text = spa.getPropietario().getNombre();
            IdBox.Text = spa.getPropietario().getIdentificacion().ToString();
            NombreMascotaBox.Text = spa.getPropietario().getMascota().getNombre();
            estratoBox.Text = spa.getPropietario().getEstratoSocioeconomico().ToString();
            tipoServicioBox.Text = spa.consultarNombre(spa.getPropietario().getServicio());
            double valorOriginal = spa.consultarCosto(spa.getPropietario().getServicio(), -1);
            double valorConDescuento = spa.consultarCosto(spa.getPropietario().getServicio(), spa.getPropietario().getEstratoSocioeconomico());
            ValorOriginalBox.Text = valorOriginal.ToString();
            DescuentoBox.Text = (valorOriginal - valorConDescuento).ToString();
            valorBox.Text = valorConDescuento.ToString();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
