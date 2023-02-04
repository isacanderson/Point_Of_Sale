namespace PointOfSale.Presentation
{
    partial class Gastos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHastaGastos = new System.Windows.Forms.Label();
            this.labelDesdeGastos = new System.Windows.Forms.Label();
            this.dateTimePickerHastaGastos = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesdeGastos = new System.Windows.Forms.DateTimePicker();
            this.buttonImprimiGastos = new System.Windows.Forms.Button();
            this.buttonBuscarGastos = new System.Windows.Forms.Button();
            this.labelTituloGastos = new System.Windows.Forms.Label();
            this.buttonAgregarGastos = new System.Windows.Forms.Button();
            this.panelAgregarGastos = new System.Windows.Forms.Panel();
            this.label1SimboloSolCompra = new System.Windows.Forms.Label();
            this.labelMontoCompra = new System.Windows.Forms.Label();
            this.labelDescripcionCompra = new System.Windows.Forms.Label();
            this.buttonGuardarGastos = new System.Windows.Forms.Button();
            this.textBoxMontoGastos = new System.Windows.Forms.TextBox();
            this.richTextBoxDescripcionGastos = new System.Windows.Forms.RichTextBox();
            this.panelMostrarGastos = new System.Windows.Forms.Panel();
            this.dataGridViewGastos = new System.Windows.Forms.DataGridView();
            this.comboBoxCategoriaGastos = new System.Windows.Forms.ComboBox();
            this.labelCategoriaGastos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAgregarGastos.SuspendLayout();
            this.panelMostrarGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(35)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.labelHastaGastos);
            this.panel1.Controls.Add(this.labelDesdeGastos);
            this.panel1.Controls.Add(this.dateTimePickerHastaGastos);
            this.panel1.Controls.Add(this.dateTimePickerDesdeGastos);
            this.panel1.Controls.Add(this.buttonImprimiGastos);
            this.panel1.Controls.Add(this.buttonBuscarGastos);
            this.panel1.Controls.Add(this.labelTituloGastos);
            this.panel1.Controls.Add(this.buttonAgregarGastos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 120);
            this.panel1.TabIndex = 0;
            // 
            // labelHastaGastos
            // 
            this.labelHastaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHastaGastos.AutoSize = true;
            this.labelHastaGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHastaGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.labelHastaGastos.Location = new System.Drawing.Point(208, 78);
            this.labelHastaGastos.Name = "labelHastaGastos";
            this.labelHastaGastos.Size = new System.Drawing.Size(48, 13);
            this.labelHastaGastos.TabIndex = 7;
            this.labelHastaGastos.Text = "HASTA";
            // 
            // labelDesdeGastos
            // 
            this.labelDesdeGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDesdeGastos.AutoSize = true;
            this.labelDesdeGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesdeGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.labelDesdeGastos.Location = new System.Drawing.Point(24, 78);
            this.labelDesdeGastos.Name = "labelDesdeGastos";
            this.labelDesdeGastos.Size = new System.Drawing.Size(49, 13);
            this.labelDesdeGastos.TabIndex = 6;
            this.labelDesdeGastos.Text = "DESDE";
            // 
            // dateTimePickerHastaGastos
            // 
            this.dateTimePickerHastaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerHastaGastos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHastaGastos.Location = new System.Drawing.Point(278, 72);
            this.dateTimePickerHastaGastos.Name = "dateTimePickerHastaGastos";
            this.dateTimePickerHastaGastos.Size = new System.Drawing.Size(102, 20);
            this.dateTimePickerHastaGastos.TabIndex = 5;
            // 
            // dateTimePickerDesdeGastos
            // 
            this.dateTimePickerDesdeGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerDesdeGastos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesdeGastos.Location = new System.Drawing.Point(84, 72);
            this.dateTimePickerDesdeGastos.Name = "dateTimePickerDesdeGastos";
            this.dateTimePickerDesdeGastos.Size = new System.Drawing.Size(102, 20);
            this.dateTimePickerDesdeGastos.TabIndex = 4;
            // 
            // buttonImprimiGastos
            // 
            this.buttonImprimiGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImprimiGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.buttonImprimiGastos.FlatAppearance.BorderSize = 0;
            this.buttonImprimiGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimiGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimiGastos.ForeColor = System.Drawing.Color.White;
            this.buttonImprimiGastos.Location = new System.Drawing.Point(528, 66);
            this.buttonImprimiGastos.Name = "buttonImprimiGastos";
            this.buttonImprimiGastos.Size = new System.Drawing.Size(107, 37);
            this.buttonImprimiGastos.TabIndex = 3;
            this.buttonImprimiGastos.Text = "IMPRIMIR";
            this.buttonImprimiGastos.UseVisualStyleBackColor = false;
            // 
            // buttonBuscarGastos
            // 
            this.buttonBuscarGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBuscarGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.buttonBuscarGastos.FlatAppearance.BorderSize = 0;
            this.buttonBuscarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarGastos.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarGastos.Location = new System.Drawing.Point(402, 66);
            this.buttonBuscarGastos.Name = "buttonBuscarGastos";
            this.buttonBuscarGastos.Size = new System.Drawing.Size(107, 37);
            this.buttonBuscarGastos.TabIndex = 2;
            this.buttonBuscarGastos.Text = "BUSCAR";
            this.buttonBuscarGastos.UseVisualStyleBackColor = false;
            // 
            // labelTituloGastos
            // 
            this.labelTituloGastos.AutoSize = true;
            this.labelTituloGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloGastos.ForeColor = System.Drawing.Color.White;
            this.labelTituloGastos.Location = new System.Drawing.Point(12, 9);
            this.labelTituloGastos.Name = "labelTituloGastos";
            this.labelTituloGastos.Size = new System.Drawing.Size(82, 20);
            this.labelTituloGastos.TabIndex = 1;
            this.labelTituloGastos.Text = "GASTOS";
            // 
            // buttonAgregarGastos
            // 
            this.buttonAgregarGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregarGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.buttonAgregarGastos.FlatAppearance.BorderSize = 0;
            this.buttonAgregarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarGastos.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarGastos.Location = new System.Drawing.Point(654, 66);
            this.buttonAgregarGastos.Name = "buttonAgregarGastos";
            this.buttonAgregarGastos.Size = new System.Drawing.Size(107, 37);
            this.buttonAgregarGastos.TabIndex = 0;
            this.buttonAgregarGastos.Text = "AGREGAR COMPRAS";
            this.buttonAgregarGastos.UseVisualStyleBackColor = false;
            this.buttonAgregarGastos.Click += new System.EventHandler(this.buttonAgregarCompras_Click);
            // 
            // panelAgregarGastos
            // 
            this.panelAgregarGastos.Controls.Add(this.labelCategoriaGastos);
            this.panelAgregarGastos.Controls.Add(this.comboBoxCategoriaGastos);
            this.panelAgregarGastos.Controls.Add(this.label1SimboloSolCompra);
            this.panelAgregarGastos.Controls.Add(this.labelMontoCompra);
            this.panelAgregarGastos.Controls.Add(this.labelDescripcionCompra);
            this.panelAgregarGastos.Controls.Add(this.buttonGuardarGastos);
            this.panelAgregarGastos.Controls.Add(this.textBoxMontoGastos);
            this.panelAgregarGastos.Controls.Add(this.richTextBoxDescripcionGastos);
            this.panelAgregarGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAgregarGastos.Location = new System.Drawing.Point(0, 120);
            this.panelAgregarGastos.Name = "panelAgregarGastos";
            this.panelAgregarGastos.Size = new System.Drawing.Size(784, 139);
            this.panelAgregarGastos.TabIndex = 1;
            this.panelAgregarGastos.Visible = false;
            // 
            // label1SimboloSolCompra
            // 
            this.label1SimboloSolCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1SimboloSolCompra.AutoSize = true;
            this.label1SimboloSolCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1SimboloSolCompra.Location = new System.Drawing.Point(441, 109);
            this.label1SimboloSolCompra.Name = "label1SimboloSolCompra";
            this.label1SimboloSolCompra.Size = new System.Drawing.Size(25, 13);
            this.label1SimboloSolCompra.TabIndex = 5;
            this.label1SimboloSolCompra.Text = "S/.";
            // 
            // labelMontoCompra
            // 
            this.labelMontoCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMontoCompra.AutoSize = true;
            this.labelMontoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoCompra.Location = new System.Drawing.Point(466, 90);
            this.labelMontoCompra.Name = "labelMontoCompra";
            this.labelMontoCompra.Size = new System.Drawing.Size(52, 13);
            this.labelMontoCompra.TabIndex = 4;
            this.labelMontoCompra.Text = "MONTO";
            // 
            // labelDescripcionCompra
            // 
            this.labelDescripcionCompra.AutoSize = true;
            this.labelDescripcionCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionCompra.Location = new System.Drawing.Point(24, 27);
            this.labelDescripcionCompra.Name = "labelDescripcionCompra";
            this.labelDescripcionCompra.Size = new System.Drawing.Size(91, 13);
            this.labelDescripcionCompra.TabIndex = 3;
            this.labelDescripcionCompra.Text = "DESCRIPCIÓN";
            // 
            // buttonGuardarGastos
            // 
            this.buttonGuardarGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuardarGastos.AutoSize = true;
            this.buttonGuardarGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(135)))), ((int)(((byte)(53)))));
            this.buttonGuardarGastos.FlatAppearance.BorderSize = 0;
            this.buttonGuardarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarGastos.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarGastos.Location = new System.Drawing.Point(615, 75);
            this.buttonGuardarGastos.Name = "buttonGuardarGastos";
            this.buttonGuardarGastos.Size = new System.Drawing.Size(146, 51);
            this.buttonGuardarGastos.TabIndex = 2;
            this.buttonGuardarGastos.Text = "GUARDAR COMPRA";
            this.buttonGuardarGastos.UseVisualStyleBackColor = false;
            this.buttonGuardarGastos.Click += new System.EventHandler(this.buttonGuardarCompra_Click);
            // 
            // textBoxMontoGastos
            // 
            this.textBoxMontoGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMontoGastos.Location = new System.Drawing.Point(469, 106);
            this.textBoxMontoGastos.Name = "textBoxMontoGastos";
            this.textBoxMontoGastos.Size = new System.Drawing.Size(95, 20);
            this.textBoxMontoGastos.TabIndex = 1;
            // 
            // richTextBoxDescripcionGastos
            // 
            this.richTextBoxDescripcionGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescripcionGastos.Location = new System.Drawing.Point(27, 43);
            this.richTextBoxDescripcionGastos.Name = "richTextBoxDescripcionGastos";
            this.richTextBoxDescripcionGastos.Size = new System.Drawing.Size(183, 79);
            this.richTextBoxDescripcionGastos.TabIndex = 0;
            this.richTextBoxDescripcionGastos.Text = "";
            // 
            // panelMostrarGastos
            // 
            this.panelMostrarGastos.Controls.Add(this.dataGridViewGastos);
            this.panelMostrarGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMostrarGastos.Location = new System.Drawing.Point(0, 259);
            this.panelMostrarGastos.Name = "panelMostrarGastos";
            this.panelMostrarGastos.Size = new System.Drawing.Size(784, 352);
            this.panelMostrarGastos.TabIndex = 2;
            // 
            // dataGridViewGastos
            // 
            this.dataGridViewGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGastos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGastos.Name = "dataGridViewGastos";
            this.dataGridViewGastos.Size = new System.Drawing.Size(784, 352);
            this.dataGridViewGastos.TabIndex = 0;
            // 
            // comboBoxCategoriaGastos
            // 
            this.comboBoxCategoriaGastos.FormattingEnabled = true;
            this.comboBoxCategoriaGastos.Items.AddRange(new object[] {
            "COMPRAS",
            "OTROS EGRESOS"});
            this.comboBoxCategoriaGastos.Location = new System.Drawing.Point(278, 43);
            this.comboBoxCategoriaGastos.Name = "comboBoxCategoriaGastos";
            this.comboBoxCategoriaGastos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoriaGastos.TabIndex = 6;
            // 
            // labelCategoriaGastos
            // 
            this.labelCategoriaGastos.AutoSize = true;
            this.labelCategoriaGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaGastos.Location = new System.Drawing.Point(275, 27);
            this.labelCategoriaGastos.Name = "labelCategoriaGastos";
            this.labelCategoriaGastos.Size = new System.Drawing.Size(78, 13);
            this.labelCategoriaGastos.TabIndex = 7;
            this.labelCategoriaGastos.Text = "CATEGORIA";
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panelMostrarGastos);
            this.Controls.Add(this.panelAgregarGastos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gastos";
            this.Text = "Compras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAgregarGastos.ResumeLayout(false);
            this.panelAgregarGastos.PerformLayout();
            this.panelMostrarGastos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAgregarGastos;
        private System.Windows.Forms.Panel panelAgregarGastos;
        private System.Windows.Forms.Button buttonGuardarGastos;
        private System.Windows.Forms.TextBox textBoxMontoGastos;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcionGastos;
        private System.Windows.Forms.Panel panelMostrarGastos;
        private System.Windows.Forms.DataGridView dataGridViewGastos;
        private System.Windows.Forms.Label labelTituloGastos;
        private System.Windows.Forms.Button buttonImprimiGastos;
        private System.Windows.Forms.Button buttonBuscarGastos;
        private System.Windows.Forms.Label labelHastaGastos;
        private System.Windows.Forms.Label labelDesdeGastos;
        private System.Windows.Forms.DateTimePicker dateTimePickerHastaGastos;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesdeGastos;
        private System.Windows.Forms.Label label1SimboloSolCompra;
        private System.Windows.Forms.Label labelMontoCompra;
        private System.Windows.Forms.Label labelDescripcionCompra;
        private System.Windows.Forms.ComboBox comboBoxCategoriaGastos;
        private System.Windows.Forms.Label labelCategoriaGastos;
    }
}