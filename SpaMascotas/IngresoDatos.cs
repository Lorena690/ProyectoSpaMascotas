using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FASE2_SPAMASCOTAS
{
    internal partial class IngresoDatos : Form
    {
        private SpaMascotas spaMascotas;
        private string comboServicio;
        private bool validacionParaMostrar;

        public IngresoDatos(SpaMascotas spa)
        {
            this.spaMascotas  = spa;
            InitializeComponent();
            validacionParaMostrar = false;
        }


        private void Combo1RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Combo1RB.Checked)
            {
                Valor.Text = spaMascotas.consultarCosto("Combo 1",-1).ToString();
                comboServicio = "Combo 1";
            }
        }
        private void Combo2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Combo2RB.Checked)
            {
                Valor.Text = spaMascotas.consultarCosto("Combo 2", -1).ToString();
                comboServicio = "Combo 2";
            }
        }
        private void Combo3RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Combo3RB.Checked)
            {
                Valor.Text = spaMascotas.consultarCosto("Combo 3", -1).ToString();
                comboServicio = "Combo 3";
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            string nombrePropietario = NombreBox.Text;
            string idPropietario = IdBox.Text;
            string nombreMascota = NombreMascotaBox.Text;
            string estrato = EstratoBox.Text;
            int identificacion = 0;
            bool validaciones = true;
            DateTime fechaServicio = DateTime.Now;
            if(nombrePropietario.Trim().Length == 0)
            {
                validaciones = false;
                MessageBox.Show("Ingrese un nombre de propietario");
            }
            if (idPropietario.Trim().Length == 0)
            {
                validaciones = false;
                MessageBox.Show("Ingrese una identificación");
            }
            if (nombreMascota.Trim().Length == 0)
            {
                validaciones = false;
                MessageBox.Show("Ingrese un nombre de mascota");
            }
            if (estrato.Trim().Length == 0)
            {
                validaciones = false;
                MessageBox.Show("Ingrese un estrato");
            }
            try
            {
                identificacion = int.Parse(idPropietario);
            }
            catch
            {
                validaciones = false;
                MessageBox.Show("Ingrese una identificación válida");
            }
            if (comboServicio == null)
            {
                validaciones = false;
                MessageBox.Show("Seleccione un combo");
            }
            if (validaciones)
            {
                Mascota mascota = new Mascota(nombreMascota);
                Propietario propietario = new Propietario(nombrePropietario, mascota, int.Parse(estrato), identificacion, fechaServicio, comboServicio);
                spaMascotas.setPropietario(propietario);
                validacionParaMostrar = true;
                MessageBox.Show("El propietario se guardó exitosamente", " Propietario Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (validacionParaMostrar)
            {
                NombreBox.Text = "";
                IdBox.Text = "";
                NombreMascotaBox.Text = "";
                EstratoBox.Text = "";
                Combo1RB.Checked = false;
                Combo2RB.Checked = false;
                Combo3RB.Checked = false;
                Valor.Text = "";


                var frm = new Reporte(this.spaMascotas);
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Todavía no se ha guardado un Propietario");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var deseaSalir = MessageBox.Show("¿Desea salir?","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deseaSalir == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
