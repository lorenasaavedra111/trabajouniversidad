namespace PROYECTO_FIGMA_FINAL
{
    partial class HOTEL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOTEL));
            this.REGISTRONUEVO = new System.Windows.Forms.Button();
            this.NUESTROSHOTELES = new System.Windows.Forms.Button();
            this.RESERVAR = new System.Windows.Forms.Button();
            this.FACTURADIGITAL = new System.Windows.Forms.Button();
            this.INICIOSESION = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // REGISTRONUEVO
            // 
            this.REGISTRONUEVO.BackColor = System.Drawing.Color.Cornsilk;
            this.REGISTRONUEVO.ForeColor = System.Drawing.Color.Brown;
            this.REGISTRONUEVO.Location = new System.Drawing.Point(55, 256);
            this.REGISTRONUEVO.Name = "REGISTRONUEVO";
            this.REGISTRONUEVO.Size = new System.Drawing.Size(147, 28);
            this.REGISTRONUEVO.TabIndex = 0;
            this.REGISTRONUEVO.Text = "REGISTRO NUEVO USUARIO";
            this.REGISTRONUEVO.UseVisualStyleBackColor = false;
            this.REGISTRONUEVO.Click += new System.EventHandler(this.REGISTRONUEVO_Click);
            // 
            // NUESTROSHOTELES
            // 
            this.NUESTROSHOTELES.BackColor = System.Drawing.Color.Cornsilk;
            this.NUESTROSHOTELES.ForeColor = System.Drawing.Color.Brown;
            this.NUESTROSHOTELES.Location = new System.Drawing.Point(200, 310);
            this.NUESTROSHOTELES.Name = "NUESTROSHOTELES";
            this.NUESTROSHOTELES.Size = new System.Drawing.Size(147, 28);
            this.NUESTROSHOTELES.TabIndex = 1;
            this.NUESTROSHOTELES.Text = "NUESTROS HOTELES";
            this.NUESTROSHOTELES.UseVisualStyleBackColor = false;
            this.NUESTROSHOTELES.Click += new System.EventHandler(this.NUESTROSHOTELES_Click);
            // 
            // RESERVAR
            // 
            this.RESERVAR.BackColor = System.Drawing.Color.Cornsilk;
            this.RESERVAR.ForeColor = System.Drawing.Color.Brown;
            this.RESERVAR.Location = new System.Drawing.Point(383, 310);
            this.RESERVAR.Name = "RESERVAR";
            this.RESERVAR.Size = new System.Drawing.Size(147, 28);
            this.RESERVAR.TabIndex = 2;
            this.RESERVAR.Text = "RESERVAR";
            this.RESERVAR.UseVisualStyleBackColor = false;
            // 
            // FACTURADIGITAL
            // 
            this.FACTURADIGITAL.BackColor = System.Drawing.Color.Cornsilk;
            this.FACTURADIGITAL.ForeColor = System.Drawing.Color.Brown;
            this.FACTURADIGITAL.Location = new System.Drawing.Point(570, 256);
            this.FACTURADIGITAL.Name = "FACTURADIGITAL";
            this.FACTURADIGITAL.Size = new System.Drawing.Size(147, 28);
            this.FACTURADIGITAL.TabIndex = 3;
            this.FACTURADIGITAL.Text = "FACTURA DIGITAL";
            this.FACTURADIGITAL.UseVisualStyleBackColor = false;
            // 
            // INICIOSESION
            // 
            this.INICIOSESION.BackColor = System.Drawing.Color.Cornsilk;
            this.INICIOSESION.ForeColor = System.Drawing.Color.Brown;
            this.INICIOSESION.Location = new System.Drawing.Point(305, 183);
            this.INICIOSESION.Name = "INICIOSESION";
            this.INICIOSESION.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.INICIOSESION.Size = new System.Drawing.Size(147, 28);
            this.INICIOSESION.TabIndex = 4;
            this.INICIOSESION.Text = "INICIO DE SESION";
            this.INICIOSESION.UseVisualStyleBackColor = false;
            this.INICIOSESION.Click += new System.EventHandler(this.INICIOSESION_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // HOTEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.INICIOSESION);
            this.Controls.Add(this.FACTURADIGITAL);
            this.Controls.Add(this.RESERVAR);
            this.Controls.Add(this.NUESTROSHOTELES);
            this.Controls.Add(this.REGISTRONUEVO);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "HOTEL";
            this.Text = "HOTEL ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button REGISTRONUEVO;
        private System.Windows.Forms.Button NUESTROSHOTELES;
        private System.Windows.Forms.Button RESERVAR;
        private System.Windows.Forms.Button FACTURADIGITAL;
        private System.Windows.Forms.Button INICIOSESION;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

