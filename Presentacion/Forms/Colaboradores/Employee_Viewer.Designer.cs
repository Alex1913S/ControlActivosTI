namespace Presentacion.Forms.Colaboradores
{
    partial class Employee_Viewer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CbxUbicacion = new ComboBox();
            CbxDepartamento = new ComboBox();
            dtpFechaIngreso = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            txtCargo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtApellidos = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            lblCo = new Label();
            txtCedula = new TextBox();
            label11 = new Label();
            label10 = new Label();
            btnExaminarFoto = new Button();
            label9 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            txtUsuarioApp = new TextBox();
            CbxPerfil = new ComboBox();
            CbxEstado = new ComboBox();
            PicFoto = new PictureBox();
            panel1 = new Panel();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            dgvColaboradores = new DataGridView();
            txtBuscar = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)PicFoto).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColaboradores).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // CbxUbicacion
            // 
            CbxUbicacion.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            CbxUbicacion.FormattingEnabled = true;
            CbxUbicacion.Location = new Point(24, 646);
            CbxUbicacion.Name = "CbxUbicacion";
            CbxUbicacion.Size = new Size(421, 39);
            CbxUbicacion.TabIndex = 49;
            // 
            // CbxDepartamento
            // 
            CbxDepartamento.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            CbxDepartamento.FormattingEnabled = true;
            CbxDepartamento.Location = new Point(24, 564);
            CbxDepartamento.Name = "CbxDepartamento";
            CbxDepartamento.Size = new Size(421, 39);
            CbxDepartamento.TabIndex = 48;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.CalendarFont = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaIngreso.CalendarMonthBackground = Color.White;
            dtpFechaIngreso.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            dtpFechaIngreso.Location = new Point(24, 810);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(421, 38);
            dtpFechaIngreso.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(24, 772);
            label8.Name = "label8";
            label8.Size = new Size(198, 32);
            label8.TabIndex = 46;
            label8.Text = "Fecha de ingreso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 690);
            label7.Name = "label7";
            label7.Size = new Size(79, 32);
            label7.TabIndex = 45;
            label7.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtCargo.Location = new Point(24, 728);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(421, 38);
            txtCargo.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 608);
            label6.Name = "label6";
            label6.Size = new Size(120, 32);
            label6.TabIndex = 43;
            label6.Text = "Ubicación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 526);
            label5.Name = "label5";
            label5.Size = new Size(174, 32);
            label5.TabIndex = 42;
            label5.Text = "Departamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 444);
            label3.Name = "label3";
            label3.Size = new Size(224, 32);
            label3.TabIndex = 41;
            label3.Text = "Correo Corporativo";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtCorreo.Location = new Point(24, 482);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(421, 38);
            txtCorreo.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 362);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 39;
            label2.Text = "Apellido";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtApellidos.Location = new Point(24, 400);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(421, 38);
            txtApellidos.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 280);
            label1.Name = "label1";
            label1.Size = new Size(103, 32);
            label1.TabIndex = 37;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtNombre.Location = new Point(24, 318);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(421, 38);
            txtNombre.TabIndex = 36;
            // 
            // lblCo
            // 
            lblCo.AutoSize = true;
            lblCo.BackColor = Color.Transparent;
            lblCo.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            lblCo.ForeColor = Color.White;
            lblCo.Location = new Point(24, 198);
            lblCo.Name = "lblCo";
            lblCo.Size = new Size(89, 32);
            lblCo.TabIndex = 35;
            lblCo.Text = "Cédula";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtCedula.Location = new Point(24, 236);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(421, 38);
            txtCedula.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(23, 96);
            label11.Name = "label11";
            label11.Size = new Size(186, 32);
            label11.TabIndex = 59;
            label11.Text = "Perfil de Acceso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(23, 10);
            label10.Name = "label10";
            label10.Size = new Size(86, 32);
            label10.TabIndex = 58;
            label10.Text = "Estado";
            // 
            // btnExaminarFoto
            // 
            btnExaminarFoto.BackColor = Color.Lavender;
            btnExaminarFoto.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            btnExaminarFoto.ForeColor = Color.DimGray;
            btnExaminarFoto.Location = new Point(283, 131);
            btnExaminarFoto.Name = "btnExaminarFoto";
            btnExaminarFoto.Size = new Size(155, 50);
            btnExaminarFoto.TabIndex = 57;
            btnExaminarFoto.Text = "Cargar";
            btnExaminarFoto.UseVisualStyleBackColor = false;
            btnExaminarFoto.Click += btnExaminarFoto_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(23, 988);
            label9.Name = "label9";
            label9.Size = new Size(138, 32);
            label9.TabIndex = 56;
            label9.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 885);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 55;
            label4.Text = "Usuario";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtPassword.Location = new Point(23, 1030);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(415, 38);
            txtPassword.TabIndex = 54;
            // 
            // txtUsuarioApp
            // 
            txtUsuarioApp.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtUsuarioApp.Location = new Point(23, 933);
            txtUsuarioApp.Name = "txtUsuarioApp";
            txtUsuarioApp.Size = new Size(415, 38);
            txtUsuarioApp.TabIndex = 53;
            // 
            // CbxPerfil
            // 
            CbxPerfil.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            CbxPerfil.FormattingEnabled = true;
            CbxPerfil.Location = new Point(23, 136);
            CbxPerfil.Name = "CbxPerfil";
            CbxPerfil.Size = new Size(225, 39);
            CbxPerfil.TabIndex = 52;
            // 
            // CbxEstado
            // 
            CbxEstado.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            CbxEstado.FormattingEnabled = true;
            CbxEstado.Location = new Point(23, 50);
            CbxEstado.Name = "CbxEstado";
            CbxEstado.Size = new Size(225, 39);
            CbxEstado.TabIndex = 51;
            // 
            // PicFoto
            // 
            PicFoto.BackColor = Color.White;
            PicFoto.BackgroundImageLayout = ImageLayout.Center;
            PicFoto.Location = new Point(310, 19);
            PicFoto.Name = "PicFoto";
            PicFoto.Size = new Size(100, 100);
            PicFoto.TabIndex = 50;
            PicFoto.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 4, 56);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnGuardar);
            panel1.Controls.Add(PicFoto);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dtpFechaIngreso);
            panel1.Controls.Add(CbxUbicacion);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(CbxDepartamento);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnExaminarFoto);
            panel1.Controls.Add(txtCargo);
            panel1.Controls.Add(txtUsuarioApp);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CbxEstado);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CbxPerfil);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(lblCo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(txtApellidos);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 1236);
            panel1.TabIndex = 60;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.FromArgb(244, 154, 36);
            BtnEliminar.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(66, 1157);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(344, 58);
            BtnEliminar.TabIndex = 61;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(244, 154, 36);
            BtnGuardar.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(66, 1093);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(344, 58);
            BtnGuardar.TabIndex = 60;
            BtnGuardar.Text = "Modificar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // dgvColaboradores
            // 
            dgvColaboradores.BackgroundColor = Color.FromArgb(12, 9, 53);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 4, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvColaboradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvColaboradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(7, 4, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 154, 36);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvColaboradores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvColaboradores.Dock = DockStyle.Fill;
            dgvColaboradores.GridColor = Color.FromArgb(7, 4, 40);
            dgvColaboradores.Location = new Point(460, 63);
            dgvColaboradores.Name = "dgvColaboradores";
            dgvColaboradores.RowHeadersWidth = 72;
            dgvColaboradores.Size = new Size(1262, 1173);
            dgvColaboradores.TabIndex = 61;
            dgvColaboradores.CellClick += dgvColaboradores_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.None;
            txtBuscar.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtBuscar.Location = new Point(23, 14);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(421, 38);
            txtBuscar.TabIndex = 62;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 9, 40);
            panel2.Controls.Add(txtBuscar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(460, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 63);
            panel2.TabIndex = 63;
            // 
            // Employee_Viewer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1722, 1236);
            Controls.Add(dgvColaboradores);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Employee_Viewer";
            Text = "Employee_Viewer";
            Load += Employee_Viewer_Load;
            ((System.ComponentModel.ISupportInitialize)PicFoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColaboradores).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CbxUbicacion;
        private ComboBox CbxDepartamento;
        private DateTimePicker dtpFechaIngreso;
        private Label label8;
        private Label label7;
        private TextBox txtCargo;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtApellidos;
        private Label label1;
        private TextBox txtNombre;
        private Label lblCo;
        private TextBox txtCedula;
        private Label label11;
        private Label label10;
        private Button btnExaminarFoto;
        private Label label9;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtUsuarioApp;
        private ComboBox CbxPerfil;
        private ComboBox CbxEstado;
        private PictureBox PicFoto;
        private Panel panel1;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private DataGridView dgvColaboradores;
        private TextBox txtBuscar;
        private Panel panel2;
    }
}