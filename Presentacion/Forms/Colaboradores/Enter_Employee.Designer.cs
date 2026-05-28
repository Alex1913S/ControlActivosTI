namespace Presentacion.Forms.Colaboradores
{
    partial class Enter_Employee
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
            PnlReg1 = new Panel();
            CbxUbicacion = new ComboBox();
            CbxDepartamento = new ComboBox();
            BtnSiguiente = new Button();
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
            PnlReg2 = new Panel();
            label11 = new Label();
            label10 = new Label();
            btnExaminarFoto = new Button();
            BtnGuardar = new Button();
            label9 = new Label();
            label4 = new Label();
            BtnAtras = new Button();
            txtPassword = new TextBox();
            txtUsuarioApp = new TextBox();
            CbxPerfil = new ComboBox();
            CbxEstado = new ComboBox();
            PicFoto = new PictureBox();
            PnlReg1.SuspendLayout();
            PnlReg2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicFoto).BeginInit();
            SuspendLayout();
            // 
            // PnlReg1
            // 
            PnlReg1.BackColor = Color.FromArgb(7, 4, 40);
            PnlReg1.Controls.Add(CbxUbicacion);
            PnlReg1.Controls.Add(CbxDepartamento);
            PnlReg1.Controls.Add(BtnSiguiente);
            PnlReg1.Controls.Add(dtpFechaIngreso);
            PnlReg1.Controls.Add(label8);
            PnlReg1.Controls.Add(label7);
            PnlReg1.Controls.Add(txtCargo);
            PnlReg1.Controls.Add(label6);
            PnlReg1.Controls.Add(label5);
            PnlReg1.Controls.Add(label3);
            PnlReg1.Controls.Add(txtCorreo);
            PnlReg1.Controls.Add(label2);
            PnlReg1.Controls.Add(txtApellidos);
            PnlReg1.Controls.Add(label1);
            PnlReg1.Controls.Add(txtNombre);
            PnlReg1.Controls.Add(lblCo);
            PnlReg1.Controls.Add(txtCedula);
            PnlReg1.Location = new Point(87, 37);
            PnlReg1.Name = "PnlReg1";
            PnlReg1.Size = new Size(1000, 824);
            PnlReg1.TabIndex = 0;
            // 
            // CbxUbicacion
            // 
            CbxUbicacion.FormattingEnabled = true;
            CbxUbicacion.Location = new Point(528, 266);
            CbxUbicacion.Name = "CbxUbicacion";
            CbxUbicacion.Size = new Size(441, 38);
            CbxUbicacion.TabIndex = 33;
            // 
            // CbxDepartamento
            // 
            CbxDepartamento.FormattingEnabled = true;
            CbxDepartamento.Location = new Point(528, 154);
            CbxDepartamento.Name = "CbxDepartamento";
            CbxDepartamento.Size = new Size(441, 38);
            CbxDepartamento.TabIndex = 32;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.BackColor = Color.Transparent;
            BtnSiguiente.BackgroundImage = Properties.Resources.next;
            BtnSiguiente.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSiguiente.FlatStyle = FlatStyle.Flat;
            BtnSiguiente.Location = new Point(462, 641);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(90, 90);
            BtnSiguiente.TabIndex = 31;
            BtnSiguiente.UseVisualStyleBackColor = false;
            BtnSiguiente.Click += BtnSiguiente_Click;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.CalendarFont = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaIngreso.CalendarMonthBackground = Color.White;
            dtpFechaIngreso.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            dtpFechaIngreso.Location = new Point(528, 488);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(441, 38);
            dtpFechaIngreso.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(528, 438);
            label8.Name = "label8";
            label8.Size = new Size(198, 32);
            label8.TabIndex = 29;
            label8.Text = "Fecha de ingreso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(528, 327);
            label7.Name = "label7";
            label7.Size = new Size(79, 32);
            label7.TabIndex = 27;
            label7.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtCargo.Location = new Point(528, 377);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(441, 38);
            txtCargo.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(528, 216);
            label6.Name = "label6";
            label6.Size = new Size(120, 32);
            label6.TabIndex = 25;
            label6.Text = "Ubicación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(528, 104);
            label5.Name = "label5";
            label5.Size = new Size(174, 32);
            label5.TabIndex = 23;
            label5.Text = "Departamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 438);
            label3.Name = "label3";
            label3.Size = new Size(224, 32);
            label3.TabIndex = 19;
            label3.Text = "Correo Corporativo";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtCorreo.Location = new Point(35, 488);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(441, 38);
            txtCorreo.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 327);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 17;
            label2.Text = "Apellido";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtApellidos.Location = new Point(35, 377);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(441, 38);
            txtApellidos.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 216);
            label1.Name = "label1";
            label1.Size = new Size(103, 32);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtNombre.Location = new Point(35, 266);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(441, 38);
            txtNombre.TabIndex = 14;
            // 
            // lblCo
            // 
            lblCo.AutoSize = true;
            lblCo.BackColor = Color.Transparent;
            lblCo.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            lblCo.ForeColor = Color.White;
            lblCo.Location = new Point(35, 104);
            lblCo.Name = "lblCo";
            lblCo.Size = new Size(89, 32);
            lblCo.TabIndex = 13;
            lblCo.Text = "Cédula";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtCedula.Location = new Point(35, 154);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(441, 38);
            txtCedula.TabIndex = 12;
            // 
            // PnlReg2
            // 
            PnlReg2.BackColor = Color.FromArgb(7, 4, 40);
            PnlReg2.Controls.Add(label11);
            PnlReg2.Controls.Add(label10);
            PnlReg2.Controls.Add(btnExaminarFoto);
            PnlReg2.Controls.Add(BtnGuardar);
            PnlReg2.Controls.Add(label9);
            PnlReg2.Controls.Add(label4);
            PnlReg2.Controls.Add(BtnAtras);
            PnlReg2.Controls.Add(txtPassword);
            PnlReg2.Controls.Add(txtUsuarioApp);
            PnlReg2.Controls.Add(CbxPerfil);
            PnlReg2.Controls.Add(CbxEstado);
            PnlReg2.Controls.Add(PicFoto);
            PnlReg2.Location = new Point(87, 37);
            PnlReg2.Name = "PnlReg2";
            PnlReg2.Size = new Size(1000, 824);
            PnlReg2.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(579, 327);
            label11.Name = "label11";
            label11.Size = new Size(186, 32);
            label11.TabIndex = 11;
            label11.Text = "Perfil de Acceso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(250, 327);
            label10.Name = "label10";
            label10.Size = new Size(86, 32);
            label10.TabIndex = 10;
            label10.Text = "Estado";
            // 
            // btnExaminarFoto
            // 
            btnExaminarFoto.BackColor = Color.Lavender;
            btnExaminarFoto.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            btnExaminarFoto.ForeColor = Color.DimGray;
            btnExaminarFoto.Location = new Point(357, 266);
            btnExaminarFoto.Name = "btnExaminarFoto";
            btnExaminarFoto.Size = new Size(300, 50);
            btnExaminarFoto.TabIndex = 9;
            btnExaminarFoto.Text = "Seleccionar foto";
            btnExaminarFoto.UseVisualStyleBackColor = false;
            btnExaminarFoto.Click += btnExaminarFoto_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(244, 154, 36);
            BtnGuardar.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            BtnGuardar.ForeColor = Color.DimGray;
            BtnGuardar.Location = new Point(335, 746);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(344, 58);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar nuevo empleado";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(250, 541);
            label9.Name = "label9";
            label9.Size = new Size(138, 32);
            label9.TabIndex = 7;
            label9.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(250, 438);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 6;
            label4.Text = "Usuario";
            // 
            // BtnAtras
            // 
            BtnAtras.BackgroundImage = Properties.Resources.Back;
            BtnAtras.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAtras.FlatStyle = FlatStyle.Flat;
            BtnAtras.Location = new Point(462, 641);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(90, 90);
            BtnAtras.TabIndex = 5;
            BtnAtras.UseVisualStyleBackColor = true;
            BtnAtras.Click += BtnAtras_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtPassword.Location = new Point(250, 583);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(515, 38);
            txtPassword.TabIndex = 4;
            // 
            // txtUsuarioApp
            // 
            txtUsuarioApp.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            txtUsuarioApp.Location = new Point(250, 486);
            txtUsuarioApp.Name = "txtUsuarioApp";
            txtUsuarioApp.Size = new Size(515, 38);
            txtUsuarioApp.TabIndex = 3;
            // 
            // CbxPerfil
            // 
            CbxPerfil.FormattingEnabled = true;
            CbxPerfil.Location = new Point(540, 378);
            CbxPerfil.Name = "CbxPerfil";
            CbxPerfil.Size = new Size(225, 38);
            CbxPerfil.TabIndex = 2;
            // 
            // CbxEstado
            // 
            CbxEstado.FormattingEnabled = true;
            CbxEstado.Location = new Point(250, 377);
            CbxEstado.Name = "CbxEstado";
            CbxEstado.Size = new Size(225, 38);
            CbxEstado.TabIndex = 1;
            // 
            // PicFoto
            // 
            PicFoto.BackColor = Color.White;
            PicFoto.BackgroundImageLayout = ImageLayout.Stretch;
            PicFoto.Location = new Point(407, 48);
            PicFoto.Name = "PicFoto";
            PicFoto.Size = new Size(200, 200);
            PicFoto.TabIndex = 0;
            PicFoto.TabStop = false;
            // 
            // Enter_Employee
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 4, 56);
            ClientSize = new Size(1200, 900);
            Controls.Add(PnlReg1);
            Controls.Add(PnlReg2);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Enter_Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter_Employee";
            Load += Enter_Employee_Load;
            PnlReg1.ResumeLayout(false);
            PnlReg1.PerformLayout();
            PnlReg2.ResumeLayout(false);
            PnlReg2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlReg1;
        private Label lblCo;
        private TextBox txtCedula;
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
        private Button BtnSiguiente;
        private DateTimePicker dtpFechaIngreso;
        private ComboBox CbxUbicacion;
        private ComboBox CbxDepartamento;
        private Panel PnlReg2;
        private PictureBox PicFoto;
        private TextBox txtPassword;
        private TextBox txtUsuarioApp;
        private ComboBox CbxPerfil;
        private ComboBox CbxEstado;
        private Button BtnAtras;
        private Label label9;
        private Label label4;
        private Button btnExaminarFoto;
        private Button BtnGuardar;
        private Label label11;
        private Label label10;
    }
}