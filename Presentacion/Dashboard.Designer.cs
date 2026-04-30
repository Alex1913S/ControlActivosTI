namespace Presentacion
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
            username = new Label();
            accesKey = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(86, 32);
            username.Name = "username";
            username.Size = new Size(78, 32);
            username.TabIndex = 0;
            username.Text = "label1";
            // 
            // accesKey
            // 
            accesKey.AutoSize = true;
            accesKey.Location = new Point(86, 87);
            accesKey.Name = "accesKey";
            accesKey.Size = new Size(78, 32);
            accesKey.TabIndex = 1;
            accesKey.Text = "label1";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1886, 1243);
            Controls.Add(accesKey);
            Controls.Add(username);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label accesKey;
    }
}