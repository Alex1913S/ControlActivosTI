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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Usuario.ForeColor = SystemColors.ButtonHighlight;
            lbl_Usuario.Location = new Point(16, 268);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(114, 38);
            lbl_Usuario.TabIndex = 1;
            lbl_Usuario.Text = "Usuario";
            // 
            // Username
            // 
            Username.BackColor = SystemColors.ButtonHighlight;
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            Username.Location = new Point(22, 310);
            Username.Name = "Username";
            Username.Size = new Size(329, 31);
            Username.TabIndex = 0;
            Username.KeyDown += Username_KeyDown;
            // 
            // AccessKey
            // 
            AccessKey.BackColor = SystemColors.ButtonHighlight;
            AccessKey.BorderStyle = BorderStyle.None;
            AccessKey.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            AccessKey.Location = new Point(22, 395);
            AccessKey.Name = "AccessKey";
            AccessKey.Size = new Size(329, 31);
            AccessKey.TabIndex = 1;
            AccessKey.KeyDown += AccessKey_KeyDown;
            // 
            // lbl_Contraseña
            // 
            lbl_Contraseña.AutoSize = true;
            lbl_Contraseña.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Contraseña.ForeColor = SystemColors.ButtonHighlight;
            lbl_Contraseña.Location = new Point(16, 352);
            lbl_Contraseña.Name = "lbl_Contraseña";
            lbl_Contraseña.Size = new Size(160, 38);
            lbl_Contraseña.TabIndex = 4;
            lbl_Contraseña.Text = "Contraseña";
            // 
            // ViewerKey
            // 
            ViewerKey.BackColor = Color.Transparent;
            ViewerKey.FlatAppearance.BorderSize = 0;
            ViewerKey.FlatStyle = FlatStyle.Flat;
            ViewerKey.ForeColor = Color.White;
            ViewerKey.Location = new Point(165, 443);
            ViewerKey.Name = "ViewerKey";
            ViewerKey.Size = new Size(33, 34);
            ViewerKey.TabIndex = 5;
            ViewerKey.Text = "👁";
            ViewerKey.UseVisualStyleBackColor = false;
            ViewerKey.Click += ViewerKey_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.125F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 532);
            label1.Name = "label1";
            label1.Size = new Size(302, 25);
            label1.TabIndex = 6;
            label1.Text = "Acepta los terminos y condiciones.";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(557, 732);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(449, 9);
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
            CloseForm.BackColor = Color.Transparent;
            CloseForm.BackgroundImage = Properties.Resources.close;
            CloseForm.BackgroundImageLayout = ImageLayout.Stretch;
            CloseForm.FlatAppearance.BorderSize = 0;
            CloseForm.FlatStyle = FlatStyle.Flat;
            CloseForm.ForeColor = Color.Transparent;
            CloseForm.Location = new Point(1156, 11);
            CloseForm.Name = "CloseForm";
            CloseForm.RightToLeft = RightToLeft.No;
            CloseForm.Size = new Size(33, 34);
            CloseForm.TabIndex = 8;
            CloseForm.UseVisualStyleBackColor = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(169, 569);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // LoginServices
            // 
            LoginServices.BackColor = Color.FromArgb(244, 154, 36);
            LoginServices.FlatStyle = FlatStyle.Popup;
            LoginServices.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginServices.Location = new Point(18, 637);
            LoginServices.Name = "LoginServices";
            LoginServices.Size = new Size(329, 58);
            LoginServices.TabIndex = 2;
            LoginServices.Text = "Iniciar Sesión";
            LoginServices.UseVisualStyleBackColor = false;
            LoginServices.Click += LoginServices_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 117);
            label2.Name = "label2";
            label2.Size = new Size(264, 51);
            label2.TabIndex = 11;
            label2.Text = "Bienvenido a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(18, 167);
            label3.Name = "label3";
            label3.Size = new Size(101, 51);
            label3.TabIndex = 12;
            label3.Text = "IDIT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(363, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 689);
            panel1.TabIndex = 13;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 4, 40);
            ClientSize = new Size(1200, 753);
            Controls.Add(CloseForm);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(LoginServices);
            Controls.Add(checkBox1);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(ViewerKey);
            Controls.Add(lbl_Contraseña);
            Controls.Add(AccessKey);
            Controls.Add(Username);
            Controls.Add(lbl_Usuario);
            ForeColor = SystemColors.ControlText;
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
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}
