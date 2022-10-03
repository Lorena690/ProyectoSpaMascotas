
namespace FASE2_SPAMASCOTAS
{
    partial class IngresoDatos
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoDatos));
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.NombreMascota = new System.Windows.Forms.Label();
            this.NombreMascotaBox = new System.Windows.Forms.TextBox();
            this.Estrato = new System.Windows.Forms.Label();
            this.EstratoBox = new System.Windows.Forms.ComboBox();
            this.TipoServicioGB = new System.Windows.Forms.GroupBox();
            this.Combo3RB = new System.Windows.Forms.RadioButton();
            this.Combo2RB = new System.Windows.Forms.RadioButton();
            this.Combo1RB = new System.Windows.Forms.RadioButton();
            this.Identificacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Costo = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TipoServicioGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreBox
            // 
            this.NombreBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NombreBox.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreBox.Location = new System.Drawing.Point(326, 41);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(268, 36);
            this.NombreBox.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombre.Location = new System.Drawing.Point(93, 38);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(238, 40);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre Propietario:";
            // 
            // IdBox
            // 
            this.IdBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IdBox.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdBox.Location = new System.Drawing.Point(326, 92);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(268, 36);
            this.IdBox.TabIndex = 2;
            // 
            // NombreMascota
            // 
            this.NombreMascota.AutoSize = true;
            this.NombreMascota.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreMascota.Location = new System.Drawing.Point(93, 146);
            this.NombreMascota.Name = "NombreMascota";
            this.NombreMascota.Size = new System.Drawing.Size(205, 40);
            this.NombreMascota.TabIndex = 5;
            this.NombreMascota.Text = "Nombre Mascota:";
            // 
            // NombreMascotaBox
            // 
            this.NombreMascotaBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NombreMascotaBox.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreMascotaBox.Location = new System.Drawing.Point(326, 149);
            this.NombreMascotaBox.Name = "NombreMascotaBox";
            this.NombreMascotaBox.Size = new System.Drawing.Size(268, 36);
            this.NombreMascotaBox.TabIndex = 4;
            // 
            // Estrato
            // 
            this.Estrato.AutoSize = true;
            this.Estrato.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Estrato.Location = new System.Drawing.Point(93, 206);
            this.Estrato.Name = "Estrato";
            this.Estrato.Size = new System.Drawing.Size(222, 40);
            this.Estrato.TabIndex = 6;
            this.Estrato.Text = "Estrato económico:";
            // 
            // EstratoBox
            // 
            this.EstratoBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EstratoBox.FormattingEnabled = true;
            this.EstratoBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.EstratoBox.Location = new System.Drawing.Point(326, 211);
            this.EstratoBox.Name = "EstratoBox";
            this.EstratoBox.Size = new System.Drawing.Size(268, 37);
            this.EstratoBox.TabIndex = 7;
            this.EstratoBox.Text = "3";
            // 
            // TipoServicioGB
            // 
            this.TipoServicioGB.Controls.Add(this.Combo3RB);
            this.TipoServicioGB.Controls.Add(this.Combo2RB);
            this.TipoServicioGB.Controls.Add(this.Combo1RB);
            this.TipoServicioGB.Location = new System.Drawing.Point(93, 288);
            this.TipoServicioGB.Name = "TipoServicioGB";
            this.TipoServicioGB.Size = new System.Drawing.Size(809, 233);
            this.TipoServicioGB.TabIndex = 8;
            this.TipoServicioGB.TabStop = false;
            this.TipoServicioGB.Text = "Tipo Servicio";
            // 
            // Combo3RB
            // 
            this.Combo3RB.AutoSize = true;
            this.Combo3RB.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combo3RB.Location = new System.Drawing.Point(17, 172);
            this.Combo3RB.Name = "Combo3RB";
            this.Combo3RB.Size = new System.Drawing.Size(579, 37);
            this.Combo3RB.TabIndex = 2;
            this.Combo3RB.Text = "Baño, corte, vacunas antigarrapatas y antiparasitos - $100.000";
            this.Combo3RB.UseVisualStyleBackColor = true;
            this.Combo3RB.CheckedChanged += new System.EventHandler(this.Combo3RB_CheckedChanged);
            // 
            // Combo2RB
            // 
            this.Combo2RB.AutoSize = true;
            this.Combo2RB.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combo2RB.Location = new System.Drawing.Point(17, 111);
            this.Combo2RB.Name = "Combo2RB";
            this.Combo2RB.Size = new System.Drawing.Size(431, 37);
            this.Combo2RB.TabIndex = 1;
            this.Combo2RB.Text = "Baño, corte, vacuna antigarrapatas - $80.000";
            this.Combo2RB.UseVisualStyleBackColor = true;
            this.Combo2RB.CheckedChanged += new System.EventHandler(this.Combo2RB_CheckedChanged);
            // 
            // Combo1RB
            // 
            this.Combo1RB.AutoSize = true;
            this.Combo1RB.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combo1RB.Location = new System.Drawing.Point(17, 46);
            this.Combo1RB.Name = "Combo1RB";
            this.Combo1RB.Size = new System.Drawing.Size(235, 37);
            this.Combo1RB.TabIndex = 0;
            this.Combo1RB.Text = "Baño y corte - $45.000";
            this.Combo1RB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Combo1RB.UseVisualStyleBackColor = true;
            this.Combo1RB.CheckedChanged += new System.EventHandler(this.Combo1RB_CheckedChanged);
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Identificacion.Location = new System.Drawing.Point(93, 89);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(170, 40);
            this.Identificacion.TabIndex = 3;
            this.Identificacion.Text = "Identificación:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FASE2_SPAMASCOTAS.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(684, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 210);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Costo.Location = new System.Drawing.Point(187, 552);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(174, 40);
            this.Costo.TabIndex = 11;
            this.Costo.Text = "Costo Servicio:";
            // 
            // Valor
            // 
            this.Valor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Valor.Enabled = false;
            this.Valor.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Valor.Location = new System.Drawing.Point(503, 552);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(268, 36);
            this.Valor.TabIndex = 10;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FASE2_SPAMASCOTAS.Properties.Resources.save_floppy_disk_icon_glassy_orange_round_button_isolated_abstract_illustration_88540566;
            this.pictureBox2.Location = new System.Drawing.Point(188, 626);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 100);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FASE2_SPAMASCOTAS.Properties.Resources.view_more_button_copy;
            this.pictureBox3.Location = new System.Drawing.Point(365, 647);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 62);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FASE2_SPAMASCOTAS.Properties.Resources.istockphoto_1142448470_612x612;
            this.pictureBox4.Location = new System.Drawing.Point(657, 626);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 100);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // IngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1006, 785);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TipoServicioGB);
            this.Controls.Add(this.EstratoBox);
            this.Controls.Add(this.Estrato);
            this.Controls.Add(this.NombreMascota);
            this.Controls.Add(this.NombreMascotaBox);
            this.Controls.Add(this.Identificacion);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.NombreBox);
            this.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IngresoDatos";
            this.Text = "IngresoDatos";
            this.TipoServicioGB.ResumeLayout(false);
            this.TipoServicioGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NombreBox;
        private Label Nombre;
        private TextBox IdBox;
        private Label NombreMascota;
        private TextBox NombreMascotaBox;
        private Label Estrato;
        private ComboBox EstratoBox;
        private GroupBox TipoServicioGB;
        private Label Identificacion;
        private PictureBox pictureBox1;
        private RadioButton Combo3RB;
        private RadioButton Combo2RB;
        private RadioButton Combo1RB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label Costo;
        private TextBox Valor;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}