namespace Presentacion.Forms.Activos
{
    partial class Log_Audit_Viewer
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
            dgvLogs = new DataGridView();
            panel1 = new Panel();
            dtpHasta = new DateTimePicker();
            label2 = new Label();
            dtpDesde = new DateTimePicker();
            btnExportar = new Button();
            btnLimpiarFiltros = new Button();
            btnFiltrar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            CloseForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Dock = DockStyle.Fill;
            dgvLogs.Location = new Point(284, 52);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 72;
            dgvLogs.Size = new Size(1164, 983);
            dgvLogs.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtpHasta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpDesde);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(btnLimpiarFiltros);
            panel1.Controls.Add(btnFiltrar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 983);
            panel1.TabIndex = 1;
            // 
            // dtpHasta
            // 
            dtpHasta.Dock = DockStyle.Top;
            dtpHasta.Location = new Point(0, 95);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(284, 35);
            dtpHasta.TabIndex = 4;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 65);
            label2.Name = "label2";
            label2.Size = new Size(284, 30);
            label2.TabIndex = 6;
            label2.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            dtpDesde.Dock = DockStyle.Top;
            dtpDesde.Location = new Point(0, 30);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(284, 35);
            dtpDesde.TabIndex = 3;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(244, 154, 36);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            btnExportar.Location = new Point(12, 908);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(255, 58);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.FromArgb(244, 154, 36);
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            btnLimpiarFiltros.Location = new Point(12, 832);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(255, 58);
            btnLimpiarFiltros.TabIndex = 1;
            btnLimpiarFiltros.Text = "Limpiar Filtro";
            btnLimpiarFiltros.UseVisualStyleBackColor = false;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(244, 154, 36);
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            btnFiltrar.Location = new Point(12, 168);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(255, 58);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 30);
            label1.TabIndex = 5;
            label1.Text = "Desde:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 154, 36);
            panel2.Controls.Add(CloseForm);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1448, 52);
            panel2.TabIndex = 2;
            // 
            // CloseForm
            // 
            CloseForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CloseForm.BackColor = Color.Transparent;
            CloseForm.BackgroundImage = Properties.Resources.Close_1;
            CloseForm.BackgroundImageLayout = ImageLayout.Zoom;
            CloseForm.FlatStyle = FlatStyle.Flat;
            CloseForm.Location = new Point(1399, 12);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(37, 38);
            CloseForm.TabIndex = 1;
            CloseForm.UseVisualStyleBackColor = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // Log_Audit_Viewer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 4, 40);
            ClientSize = new Size(1448, 1035);
            Controls.Add(dgvLogs);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Log_Audit_Viewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log_Audit_Viewer";
            Load += Log_Audit_Viewer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLogs;
        private Panel panel1;
        private Button btnExportar;
        private Button btnLimpiarFiltros;
        private Button btnFiltrar;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Panel panel2;
        private Button CloseForm;
    }
}