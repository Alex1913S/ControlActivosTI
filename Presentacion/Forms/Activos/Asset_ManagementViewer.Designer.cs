namespace Presentacion.Forms.Activos
{
    partial class Asset_ManagementViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asset_ManagementViewer));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            tabControl1 = new TabControl();
            Base = new TabPage();
            cmbEstadoOperativo = new ComboBox();
            lblEtiquetaActivo = new Label();
            txtCosto = new TextBox();
            cmbCategoria = new ComboBox();
            dtpFechaAdquisicion = new DateTimePicker();
            cmbUbicacion = new ComboBox();
            txtNumeroSerie = new TextBox();
            cmbProveedor = new ComboBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            Hardware = new TabPage();
            txtResolucionPantalla = new TextBox();
            txtDireccionIP = new TextBox();
            txtDireccionMAC = new TextBox();
            txtSistemaOperativo = new TextBox();
            txtTarjetaGrafica = new TextBox();
            txtAlmacenamiento2 = new TextBox();
            txtAlmacenamiento1 = new TextBox();
            txtMemoriaRAM = new TextBox();
            txtProcesador = new TextBox();
            panel2 = new Panel();
            cmbFiltroEstado = new ComboBox();
            cmbFiltroCategoria = new ComboBox();
            panel3 = new Panel();
            dgvActivos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            Base.SuspendLayout();
            Hardware.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 9, 53);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 1236);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(129, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 71);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 154, 36);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(70, 1161);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(353, 58);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(244, 154, 36);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(70, 1099);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(353, 58);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(244, 154, 36);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(70, 1037);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(353, 58);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(Base);
            tabControl1.Controls.Add(Hardware);
            tabControl1.Location = new Point(0, 112);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(486, 899);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            tabControl1.DrawItem += tabControl1_DrawItem_1;
            // 
            // Base
            // 
            Base.AccessibleRole = AccessibleRole.None;
            Base.BackColor = Color.FromArgb(12, 9, 53);
            Base.Controls.Add(cmbEstadoOperativo);
            Base.Controls.Add(lblEtiquetaActivo);
            Base.Controls.Add(txtCosto);
            Base.Controls.Add(cmbCategoria);
            Base.Controls.Add(dtpFechaAdquisicion);
            Base.Controls.Add(cmbUbicacion);
            Base.Controls.Add(txtNumeroSerie);
            Base.Controls.Add(cmbProveedor);
            Base.Controls.Add(txtModelo);
            Base.Controls.Add(txtMarca);
            Base.Location = new Point(4, 42);
            Base.Margin = new Padding(0);
            Base.Name = "Base";
            Base.Size = new Size(478, 853);
            Base.TabIndex = 0;
            Base.Text = "Base";
            // 
            // cmbEstadoOperativo
            // 
            cmbEstadoOperativo.FormattingEnabled = true;
            cmbEstadoOperativo.Location = new Point(66, 763);
            cmbEstadoOperativo.Name = "cmbEstadoOperativo";
            cmbEstadoOperativo.Size = new Size(351, 38);
            cmbEstadoOperativo.TabIndex = 9;
            // 
            // lblEtiquetaActivo
            // 
            lblEtiquetaActivo.Location = new Point(65, 131);
            lblEtiquetaActivo.Name = "lblEtiquetaActivo";
            lblEtiquetaActivo.Size = new Size(353, 32);
            lblEtiquetaActivo.TabIndex = 0;
            lblEtiquetaActivo.Text = "label1";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(68, 691);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(350, 35);
            txtCosto.TabIndex = 8;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(66, 178);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(353, 38);
            cmbCategoria.TabIndex = 1;
            // 
            // dtpFechaAdquisicion
            // 
            dtpFechaAdquisicion.Location = new Point(68, 619);
            dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            dtpFechaAdquisicion.Size = new Size(350, 35);
            dtpFechaAdquisicion.TabIndex = 7;
            // 
            // cmbUbicacion
            // 
            cmbUbicacion.FormattingEnabled = true;
            cmbUbicacion.Location = new Point(65, 253);
            cmbUbicacion.Name = "cmbUbicacion";
            cmbUbicacion.Size = new Size(353, 38);
            cmbUbicacion.TabIndex = 2;
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(66, 472);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(353, 35);
            txtNumeroSerie.TabIndex = 6;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(66, 544);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(353, 38);
            cmbProveedor.TabIndex = 3;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(66, 400);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(353, 35);
            txtModelo.TabIndex = 5;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(66, 328);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(353, 35);
            txtMarca.TabIndex = 4;
            // 
            // Hardware
            // 
            Hardware.BackColor = Color.FromArgb(12, 9, 53);
            Hardware.Controls.Add(txtResolucionPantalla);
            Hardware.Controls.Add(txtDireccionIP);
            Hardware.Controls.Add(txtDireccionMAC);
            Hardware.Controls.Add(txtSistemaOperativo);
            Hardware.Controls.Add(txtTarjetaGrafica);
            Hardware.Controls.Add(txtAlmacenamiento2);
            Hardware.Controls.Add(txtAlmacenamiento1);
            Hardware.Controls.Add(txtMemoriaRAM);
            Hardware.Controls.Add(txtProcesador);
            Hardware.Location = new Point(4, 42);
            Hardware.Margin = new Padding(0);
            Hardware.Name = "Hardware";
            Hardware.Size = new Size(478, 853);
            Hardware.TabIndex = 1;
            Hardware.Text = "Hardware";
            // 
            // txtResolucionPantalla
            // 
            txtResolucionPantalla.Location = new Point(66, 770);
            txtResolucionPantalla.Name = "txtResolucionPantalla";
            txtResolucionPantalla.Size = new Size(353, 35);
            txtResolucionPantalla.TabIndex = 8;
            // 
            // txtDireccionIP
            // 
            txtDireccionIP.Location = new Point(66, 696);
            txtDireccionIP.Name = "txtDireccionIP";
            txtDireccionIP.Size = new Size(353, 35);
            txtDireccionIP.TabIndex = 7;
            // 
            // txtDireccionMAC
            // 
            txtDireccionMAC.Location = new Point(66, 622);
            txtDireccionMAC.Name = "txtDireccionMAC";
            txtDireccionMAC.Size = new Size(353, 35);
            txtDireccionMAC.TabIndex = 6;
            // 
            // txtSistemaOperativo
            // 
            txtSistemaOperativo.Location = new Point(66, 548);
            txtSistemaOperativo.Name = "txtSistemaOperativo";
            txtSistemaOperativo.Size = new Size(353, 35);
            txtSistemaOperativo.TabIndex = 5;
            // 
            // txtTarjetaGrafica
            // 
            txtTarjetaGrafica.Location = new Point(66, 474);
            txtTarjetaGrafica.Name = "txtTarjetaGrafica";
            txtTarjetaGrafica.Size = new Size(353, 35);
            txtTarjetaGrafica.TabIndex = 4;
            // 
            // txtAlmacenamiento2
            // 
            txtAlmacenamiento2.Location = new Point(66, 400);
            txtAlmacenamiento2.Name = "txtAlmacenamiento2";
            txtAlmacenamiento2.Size = new Size(353, 35);
            txtAlmacenamiento2.TabIndex = 3;
            // 
            // txtAlmacenamiento1
            // 
            txtAlmacenamiento1.Location = new Point(66, 326);
            txtAlmacenamiento1.Name = "txtAlmacenamiento1";
            txtAlmacenamiento1.Size = new Size(353, 35);
            txtAlmacenamiento1.TabIndex = 2;
            // 
            // txtMemoriaRAM
            // 
            txtMemoriaRAM.Location = new Point(66, 252);
            txtMemoriaRAM.Name = "txtMemoriaRAM";
            txtMemoriaRAM.Size = new Size(353, 35);
            txtMemoriaRAM.TabIndex = 1;
            // 
            // txtProcesador
            // 
            txtProcesador.Location = new Point(66, 178);
            txtProcesador.Name = "txtProcesador";
            txtProcesador.Size = new Size(353, 35);
            txtProcesador.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 4, 40);
            panel2.Controls.Add(cmbFiltroEstado);
            panel2.Controls.Add(cmbFiltroCategoria);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(486, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1236, 112);
            panel2.TabIndex = 1;
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.BackColor = Color.FromArgb(244, 154, 36);
            cmbFiltroEstado.FlatStyle = FlatStyle.System;
            cmbFiltroEstado.FormattingEnabled = true;
            cmbFiltroEstado.Location = new Point(237, 47);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new Size(212, 38);
            cmbFiltroEstado.TabIndex = 1;
            cmbFiltroEstado.SelectedIndexChanged += cmbFiltroEstado_SelectedIndexChanged;
            // 
            // cmbFiltroCategoria
            // 
            cmbFiltroCategoria.BackColor = Color.FromArgb(244, 154, 36);
            cmbFiltroCategoria.FlatStyle = FlatStyle.System;
            cmbFiltroCategoria.FormattingEnabled = true;
            cmbFiltroCategoria.Location = new Point(6, 47);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(212, 38);
            cmbFiltroCategoria.TabIndex = 0;
            cmbFiltroCategoria.SelectedIndexChanged += cmbFiltroCategoria_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvActivos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(486, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(1236, 1124);
            panel3.TabIndex = 2;
            // 
            // dgvActivos
            // 
            dgvActivos.BackgroundColor = Color.FromArgb(12, 9, 53);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 4, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(7, 4, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 154, 36);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvActivos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvActivos.Dock = DockStyle.Fill;
            dgvActivos.GridColor = Color.FromArgb(7, 4, 40);
            dgvActivos.Location = new Point(0, 0);
            dgvActivos.Name = "dgvActivos";
            dgvActivos.RowHeadersWidth = 72;
            dgvActivos.Size = new Size(1236, 1124);
            dgvActivos.TabIndex = 0;
            dgvActivos.SelectionChanged += dgvActivos_SelectionChanged;
            // 
            // Asset_ManagementViewer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1722, 1236);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Asset_ManagementViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asset_ManagementViewer";
            Load += Asset_ManagementViewer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            Base.ResumeLayout(false);
            Base.PerformLayout();
            Hardware.ResumeLayout(false);
            Hardware.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtNumeroSerie;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private ComboBox cmbProveedor;
        private ComboBox cmbUbicacion;
        private ComboBox cmbCategoria;
        private Label lblEtiquetaActivo;
        private ComboBox cmbEstadoOperativo;
        private TextBox txtCosto;
        private DateTimePicker dtpFechaAdquisicion;
        private TabControl tabControl1;
        private TabPage Base;
        private TabPage Hardware;
        private TextBox txtResolucionPantalla;
        private TextBox txtDireccionIP;
        private TextBox txtDireccionMAC;
        private TextBox txtSistemaOperativo;
        private TextBox txtTarjetaGrafica;
        private TextBox txtAlmacenamiento2;
        private TextBox txtAlmacenamiento1;
        private TextBox txtMemoriaRAM;
        private TextBox txtProcesador;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private DataGridView dgvActivos;
        private ComboBox cmbFiltroEstado;
        private ComboBox cmbFiltroCategoria;
        private PictureBox pictureBox1;
    }
}