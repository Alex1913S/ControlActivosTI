using AccesoDatos;
using Dominio;
using Microsoft.Data.SqlClient;
using System.Runtime.ConstrainedExecution;
using static Dominio.ResultadoLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;




namespace Presentacion
{
    public partial class Login : Form
    {
        private readonly UsuarioDominio _dominio = new UsuarioDominio();
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int a, int b, int c, int d, int radio1, int radio2);

        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            // Estilo visual de redondeo de bordes - Textboxt | Botones y Formulario.
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoginServices.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginServices.Width, LoginServices.Height, 20, 20));
            Username.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Username.Width, Username.Height, 10, 10));
            AccessKey.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AccessKey.Width, AccessKey.Height, 10, 10));

            Username.TabIndex = 0;
            AccessKey.TabIndex = 1;
            LoginServices.TabIndex = 2;
            Username.Focus();
            Username.KeyDown += Username_KeyDown;
            AccessKey.KeyDown += AccessKey_KeyDown;

            AccessKey.UseSystemPasswordChar = true;
            this.Opacity = 0.0;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            LoginServices.Enabled = false;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.2;

            if (progressBar1.Value < 100)
                progressBar1.Value++;

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                progressBar1.Visible = false;
                LoginServices.Enabled = true;
            }
        }



        private void ViewerKey_Click(object sender, EventArgs e)
        {
            AccessKey.UseSystemPasswordChar = !AccessKey.UseSystemPasswordChar;
            ViewerKey.Text = AccessKey.UseSystemPasswordChar ? "👁" : "🔒";
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            DialogResult Rta = MessageBox.Show("¿Está seguro de salir?", "Saliendo el sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rta == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void logout(object sender, FormClosedEventArgs e)
        {
            Username.Clear();
            AccessKey.Clear();
            Username.Focus();

            ConexionSql.VariablesGlobales.xEstIni = 0;
            ConexionSql.VariablesGlobales.xNomU = "";
            ConexionSql.VariablesGlobales.xTipoU = "";

            this.Show();
        }

        private void LoginServices_Click_1(object sender, EventArgs e)
        {
            string correo = Username.Text.Trim().ToLower();
            string passwordHash = AccessKey.Text.Trim();

            var resultado = _dominio.Login(correo, passwordHash);

            if (resultado.Exitoso)
            {
                ConexionSql.VariablesGlobales.xEstIni = 1;

                Dashboard FrmMenu = new Dashboard(
                    resultado.Nombres.Split(' ')[0],
                    resultado.Apellidos.Split(' ')[0],
                    resultado.Rol,
                    resultado.Cargo,    // ✅ nuevo
                    resultado.Foto      // ✅ nuevo
                );
                this.Hide();
                FrmMenu.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show(resultado.Mensaje, "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (resultado.Bloqueado)
                {
                    Username.Enabled = false;
                    AccessKey.Enabled = false;
                    LoginServices.Enabled = false;
                }
                else
                {
                    AccessKey.Clear();
                    AccessKey.Focus();
                }
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AccessKey.Focus();
            }
        }

        private void AccessKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginServices_Click_1(sender, e);
            }
        }
    }
}