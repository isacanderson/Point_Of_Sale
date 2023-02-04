namespace PointOfSale.Presentation
{
    partial class Dashboard
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
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelSubMenuPuntoVenta = new System.Windows.Forms.Panel();
            this.panelSubMenuAdministracion = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.buttonOcultarMenuLateral = new System.Windows.Forms.Button();
            this.pictureBoxLogoRestaurant = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonCaja = new System.Windows.Forms.Button();
            this.buttonMonVentasPV = new System.Windows.Forms.Button();
            this.buttonTurno = new System.Windows.Forms.Button();
            this.buttonVender = new System.Windows.Forms.Button();
            this.buttonPuntoVenta = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.buttonMonVentasAdm = new System.Windows.Forms.Button();
            this.buttonCompras = new System.Windows.Forms.Button();
            this.buttonAdministracion = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenuLateral.SuspendLayout();
            this.panelSubMenuPuntoVenta.SuspendLayout();
            this.panelSubMenuAdministracion.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(120)))), ((int)(((byte)(47)))));
            this.panelMenuLateral.Controls.Add(this.buttonSalir);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuPuntoVenta);
            this.panelMenuLateral.Controls.Add(this.buttonPuntoVenta);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuAdministracion);
            this.panelMenuLateral.Controls.Add(this.buttonAdministracion);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(200, 611);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelSubMenuPuntoVenta
            // 
            this.panelSubMenuPuntoVenta.Controls.Add(this.buttonCaja);
            this.panelSubMenuPuntoVenta.Controls.Add(this.buttonMonVentasPV);
            this.panelSubMenuPuntoVenta.Controls.Add(this.buttonTurno);
            this.panelSubMenuPuntoVenta.Controls.Add(this.buttonVender);
            this.panelSubMenuPuntoVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuPuntoVenta.Location = new System.Drawing.Point(0, 460);
            this.panelSubMenuPuntoVenta.Name = "panelSubMenuPuntoVenta";
            this.panelSubMenuPuntoVenta.Size = new System.Drawing.Size(200, 240);
            this.panelSubMenuPuntoVenta.TabIndex = 4;
            // 
            // panelSubMenuAdministracion
            // 
            this.panelSubMenuAdministracion.Controls.Add(this.buttonProductos);
            this.panelSubMenuAdministracion.Controls.Add(this.buttonMonVentasAdm);
            this.panelSubMenuAdministracion.Controls.Add(this.buttonCompras);
            this.panelSubMenuAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAdministracion.Location = new System.Drawing.Point(0, 200);
            this.panelSubMenuAdministracion.Name = "panelSubMenuAdministracion";
            this.panelSubMenuAdministracion.Size = new System.Drawing.Size(200, 180);
            this.panelSubMenuAdministracion.TabIndex = 2;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.panelContenedor.Controls.Add(this.buttonOcultarMenuLateral);
            this.panelContenedor.Controls.Add(this.pictureBoxLogoRestaurant);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(784, 611);
            this.panelContenedor.TabIndex = 1;
            // 
            // buttonOcultarMenuLateral
            // 
            this.buttonOcultarMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(120)))), ((int)(((byte)(47)))));
            this.buttonOcultarMenuLateral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOcultarMenuLateral.FlatAppearance.BorderSize = 0;
            this.buttonOcultarMenuLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOcultarMenuLateral.Image = global::PointOfSale.Presentation.Properties.Resources.logoMenuLateralNegro;
            this.buttonOcultarMenuLateral.Location = new System.Drawing.Point(0, 270);
            this.buttonOcultarMenuLateral.Name = "buttonOcultarMenuLateral";
            this.buttonOcultarMenuLateral.Size = new System.Drawing.Size(35, 40);
            this.buttonOcultarMenuLateral.TabIndex = 1;
            this.buttonOcultarMenuLateral.UseVisualStyleBackColor = false;
            this.buttonOcultarMenuLateral.Click += new System.EventHandler(this.buttonOcultarMenuLateral_Click);
            // 
            // pictureBoxLogoRestaurant
            // 
            this.pictureBoxLogoRestaurant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogoRestaurant.Image = global::PointOfSale.Presentation.Properties.Resources.LogoMamaSabina;
            this.pictureBoxLogoRestaurant.Location = new System.Drawing.Point(105, 147);
            this.pictureBoxLogoRestaurant.Name = "pictureBoxLogoRestaurant";
            this.pictureBoxLogoRestaurant.Size = new System.Drawing.Size(584, 333);
            this.pictureBoxLogoRestaurant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogoRestaurant.TabIndex = 0;
            this.pictureBoxLogoRestaurant.TabStop = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Image = global::PointOfSale.Presentation.Properties.Resources.logoSalir;
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalir.Location = new System.Drawing.Point(0, 531);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(200, 80);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // buttonCaja
            // 
            this.buttonCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCaja.FlatAppearance.BorderSize = 0;
            this.buttonCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCaja.Image = global::PointOfSale.Presentation.Properties.Resources.logoCaja;
            this.buttonCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCaja.Location = new System.Drawing.Point(0, 180);
            this.buttonCaja.Name = "buttonCaja";
            this.buttonCaja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCaja.Size = new System.Drawing.Size(200, 60);
            this.buttonCaja.TabIndex = 3;
            this.buttonCaja.Text = "CAJA";
            this.buttonCaja.UseVisualStyleBackColor = true;
            this.buttonCaja.Click += new System.EventHandler(this.buttonCaja_Click);
            // 
            // buttonMonVentasPV
            // 
            this.buttonMonVentasPV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMonVentasPV.FlatAppearance.BorderSize = 0;
            this.buttonMonVentasPV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonVentasPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonVentasPV.Image = global::PointOfSale.Presentation.Properties.Resources.logoMonitorVentas;
            this.buttonMonVentasPV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMonVentasPV.Location = new System.Drawing.Point(0, 120);
            this.buttonMonVentasPV.Name = "buttonMonVentasPV";
            this.buttonMonVentasPV.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonMonVentasPV.Size = new System.Drawing.Size(200, 60);
            this.buttonMonVentasPV.TabIndex = 2;
            this.buttonMonVentasPV.Text = "    MONITOR DE \r\nVENTAS";
            this.buttonMonVentasPV.UseVisualStyleBackColor = true;
            this.buttonMonVentasPV.Click += new System.EventHandler(this.buttonMonVentasPV_Click);
            // 
            // buttonTurno
            // 
            this.buttonTurno.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTurno.FlatAppearance.BorderSize = 0;
            this.buttonTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTurno.Image = global::PointOfSale.Presentation.Properties.Resources.logoTurno;
            this.buttonTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTurno.Location = new System.Drawing.Point(0, 60);
            this.buttonTurno.Name = "buttonTurno";
            this.buttonTurno.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTurno.Size = new System.Drawing.Size(200, 60);
            this.buttonTurno.TabIndex = 1;
            this.buttonTurno.Text = "TURNO";
            this.buttonTurno.UseVisualStyleBackColor = true;
            this.buttonTurno.Click += new System.EventHandler(this.buttonTurno_Click);
            // 
            // buttonVender
            // 
            this.buttonVender.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVender.FlatAppearance.BorderSize = 0;
            this.buttonVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVender.Image = global::PointOfSale.Presentation.Properties.Resources.logoVender;
            this.buttonVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVender.Location = new System.Drawing.Point(0, 0);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonVender.Size = new System.Drawing.Size(200, 60);
            this.buttonVender.TabIndex = 0;
            this.buttonVender.Text = "VENDER";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.buttonVender_Click);
            // 
            // buttonPuntoVenta
            // 
            this.buttonPuntoVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPuntoVenta.FlatAppearance.BorderSize = 0;
            this.buttonPuntoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPuntoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPuntoVenta.Image = global::PointOfSale.Presentation.Properties.Resources.logoPuntoV;
            this.buttonPuntoVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPuntoVenta.Location = new System.Drawing.Point(0, 380);
            this.buttonPuntoVenta.Name = "buttonPuntoVenta";
            this.buttonPuntoVenta.Size = new System.Drawing.Size(200, 80);
            this.buttonPuntoVenta.TabIndex = 3;
            this.buttonPuntoVenta.Text = "PUNTO DE VENTA";
            this.buttonPuntoVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPuntoVenta.UseVisualStyleBackColor = true;
            this.buttonPuntoVenta.Click += new System.EventHandler(this.buttonPuntoVenta_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProductos.FlatAppearance.BorderSize = 0;
            this.buttonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.Image = global::PointOfSale.Presentation.Properties.Resources.logoProductos;
            this.buttonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductos.Location = new System.Drawing.Point(0, 120);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonProductos.Size = new System.Drawing.Size(200, 60);
            this.buttonProductos.TabIndex = 2;
            this.buttonProductos.Text = "  PRODUCTOS";
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // buttonMonVentasAdm
            // 
            this.buttonMonVentasAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMonVentasAdm.FlatAppearance.BorderSize = 0;
            this.buttonMonVentasAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonVentasAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonVentasAdm.Image = global::PointOfSale.Presentation.Properties.Resources.logoMonitorVentas;
            this.buttonMonVentasAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMonVentasAdm.Location = new System.Drawing.Point(0, 60);
            this.buttonMonVentasAdm.Name = "buttonMonVentasAdm";
            this.buttonMonVentasAdm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonMonVentasAdm.Size = new System.Drawing.Size(200, 60);
            this.buttonMonVentasAdm.TabIndex = 1;
            this.buttonMonVentasAdm.Text = "    MONITOR DE \r\nVENTAS";
            this.buttonMonVentasAdm.UseVisualStyleBackColor = true;
            this.buttonMonVentasAdm.Click += new System.EventHandler(this.buttonMonVentasAdm_Click);
            // 
            // buttonCompras
            // 
            this.buttonCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCompras.FlatAppearance.BorderSize = 0;
            this.buttonCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompras.Image = global::PointOfSale.Presentation.Properties.Resources.logoCompras;
            this.buttonCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompras.Location = new System.Drawing.Point(0, 0);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCompras.Size = new System.Drawing.Size(200, 60);
            this.buttonCompras.TabIndex = 0;
            this.buttonCompras.Text = "COMPRAS";
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.buttonCompras_Click);
            // 
            // buttonAdministracion
            // 
            this.buttonAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdministracion.FlatAppearance.BorderSize = 0;
            this.buttonAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdministracion.Image = global::PointOfSale.Presentation.Properties.Resources.logoadmin;
            this.buttonAdministracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdministracion.Location = new System.Drawing.Point(0, 120);
            this.buttonAdministracion.Name = "buttonAdministracion";
            this.buttonAdministracion.Size = new System.Drawing.Size(200, 80);
            this.buttonAdministracion.TabIndex = 1;
            this.buttonAdministracion.Text = "ADMINISTRACIÓN";
            this.buttonAdministracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdministracion.UseVisualStyleBackColor = true;
            this.buttonAdministracion.Click += new System.EventHandler(this.buttonAdministracion_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::PointOfSale.Presentation.Properties.Resources.LogoMamaSabina1;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuLateral);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polleria Restaurante Mamá Sabina";
            this.panelMenuLateral.ResumeLayout(false);
            this.panelSubMenuPuntoVenta.ResumeLayout(false);
            this.panelSubMenuAdministracion.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoRestaurant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button buttonAdministracion;
        private System.Windows.Forms.Panel panelSubMenuAdministracion;
        private System.Windows.Forms.Button buttonMonVentasAdm;
        private System.Windows.Forms.Button buttonCompras;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Button buttonPuntoVenta;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBoxLogoRestaurant;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Panel panelSubMenuPuntoVenta;
        private System.Windows.Forms.Button buttonCaja;
        private System.Windows.Forms.Button buttonMonVentasPV;
        private System.Windows.Forms.Button buttonTurno;
        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonOcultarMenuLateral;
    }
}