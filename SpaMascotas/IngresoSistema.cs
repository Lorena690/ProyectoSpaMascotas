
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FASE2_SPAMASCOTAS
{
    internal partial class IngresoSistema : Form
    {
        private SpaMascotas spaMascotas ;

        public IngresoSistema(SpaMascotas spa)
        {
            this.spaMascotas = spa;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (spaMascotas.validarPassword(passwordBox.Text))
            {
                passwordBox.Text = "";
                var frm = new IngresoDatos(this.spaMascotas);
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La contraseña ingresada no es válida" , "Contraseña Incorrecta");
            }
        }
    }
}