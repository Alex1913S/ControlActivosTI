namespace Presentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_Usuario = new Label();
            Username = new TextBox();
            AccessKey = new TextBox();
            lbl_Contraseña = new Label();
            ViewerKey = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            CloseForm = new Button();
            checkBox1 = new CheckBox();
            LoginServices = new Button();
            SuspendLayout();
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lbl_Usuario.Location = new Point(143, 393);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(141, 45);
            lbl_Usuario.TabIndex = 1;
            lbl_Usuario.Text = "Usuario";
            // 
            // Username
            // 
            Username.BackColor = SystemColors.GradientInactiveCaption;
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            Username.Location = new Point(143, 455);
            Username.Name = "Username";
            Username.Size = new Size(486, 39);
            Username.TabIndex = 2;
            // 
            // AccessKey
            // 
            AccessKey.BackColor = SystemColors.GradientInactiveCaption;
            AccessKey.BorderStyle = BorderStyle.None;
            AccessKey.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            AccessKey.Location = new Point(143, 579);
            AccessKey.Name = "AccessKey";
            AccessKey.Size = new Size(486, 39);
            AccessKey.TabIndex = 3;
            // 
            // lbl_Contraseña
            // 
            lbl_Contraseña.AutoSize = true;
            lbl_Contraseña.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lbl_Contraseña.Location = new Point(143, 534);
            lbl_Contraseña.Name = "lbl_Contraseña";
            lbl_Contraseña.Size = new Size(196, 45);
            lbl_Contraseña.TabIndex = 4;
            lbl_Contraseña.Text = "Contraseña";
            // 
            // ViewerKey
            // 
            ViewerKey.FlatAppearance.BorderSize = 0;
            ViewerKey.Location = new Point(369, 646);
            ViewerKey.Name = "ViewerKey";
            ViewerKey.Size = new Size(36, 36);
            ViewerKey.TabIndex = 5;
            ViewerKey.Text = "button1";
            ViewerKey.UseVisualStyleBackColor = true;
            ViewerKey.Click += ViewerKey_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 1030);
            label1.Name = "label1";
            label1.Size = new Size(425, 37);
            label1.TabIndex = 6;
            label1.Text = "Acepta los terminos y condiciones.";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(143, 809);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(486, 46);
            progressBar1.TabIndex = 7;
            progressBar1.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // CloseForm
            // 
            CloseForm.FlatAppearance.BorderSize = 0;
            CloseForm.Location = new Point(797, 12);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(36, 36);
            CloseForm.TabIndex = 8;
            CloseForm.Text = "button1";
            CloseForm.UseVisualStyleBackColor = true;
            CloseForm.Click += CloseForm_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(295, 714);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 36);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // LoginServices
            // 
            LoginServices.Location = new Point(143, 1127);
            LoginServices.Name = "LoginServices";
            LoginServices.Size = new Size(486, 62);
            LoginServices.TabIndex = 10;
            LoginServices.Text = "Iniciar Sesión";
            LoginServices.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(845, 1366);
            Controls.Add(LoginServices);
            Controls.Add(checkBox1);
            Controls.Add(CloseForm);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(ViewerKey);
            Controls.Add(lbl_Contraseña);
            Controls.Add(AccessKey);
            Controls.Add(Username);
            Controls.Add(lbl_Usuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Usuario;
        private TextBox Username;
        private TextBox AccessKey;
        private Label lbl_Contraseña;
        private Button ViewerKey;
        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTip1;
        private Button CloseForm;
        private CheckBox checkBox1;
        private Button LoginServices;
    }
}
