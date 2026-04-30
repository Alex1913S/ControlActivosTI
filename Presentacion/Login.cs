using AccesoDatos;
using Dominio;
using Microsoft.Data.SqlClient;
using System.Runtime.ConstrainedExecution;
using static Dominio.ResultadoLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


        }


        private void Login_Load(object sender, EventArgs e)
        {
            AccessKey.UseSystemPasswordChar = true;
            this.Opacity = 0.0;
            LoginServices.Enabled = false;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.2;
            progressBar1.Value += 1;
            progressBar1.Text = progressBar1.Value.ToString();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
            }
        }

        private void ViewerKey_Click(object sender, EventArgs e)
        {

        }
            // ✅ Solo instancia Dominio
        private UsuarioDominio _dominio = new UsuarioDominio();

        private void LoginServices_Click(object sender, EventArgs e)
        {
            string username = Username.Text.ToLower().Trim();
            string accesKey = AccessKey.Text.Trim();

            var resultado = _dominio.Login(accesKey, username);

            if (resultado.Exitoso)
            {
                ConexionSql.VariablesGlobales.xEstIni = 1;
                this.Hide();
                Dashboard FrmMenu = new Dashboard(username,accesKey);
                FrmMenu.ShowDialog();
                FrmMenu.FormClosed += logout;
            }
            else
            {
                AccessKey.Focus();
                MessageBox.Show(
                    "Usuario o Clave Incorrecta - Tiene " + (3 - resultado.Intentos) + " intentos",
                    "Número de Intentos"
                );

                if (resultado.Bloqueado)
                {
                    Username.Enabled = false;
                    AccessKey.Enabled = false;
                    LoginServices.Enabled = true;
                    MessageBox.Show("Superó el número de intentos, consulte al administrador");
                    if (ViewerKey.Text == ".")
                    { //Compara si la variable ActDes es igual a false
                      //Ver.BackgroundImage = SOFTWARE_INVENTARIO.Properties.Resources.Nover; //Cambia la Imagen si ActDes es Igual a falso
                        ViewerKey.Text = ".."; //Pone texto Cerrar en el boton
                        toolTip1.SetToolTip(ViewerKey, "Visualizar Contraseña");
                        AccessKey.UseSystemPasswordChar = true;
                    }
                    else
                    {
                        //ViewerKey.BackgroundImage = SOFTWARE_INVENTARIO.Properties.Resources.Ver; //Cambia la Imagen si ActDes es Igual a true
                        ViewerKey.Text = ".";  //Pone texto Salir en el boton
                        toolTip1.SetToolTip(ViewerKey, "Ocultar Contraseña");
                        AccessKey.UseSystemPasswordChar = false;
                    }
                }
            }
        }

                    private void CloseForm_Click(object sender, EventArgs e)
        {
            DialogResult Rta = MessageBox.Show("¿Está seguro de salir?", "Saliendo el sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rta == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        //private void LoginServices_Click(object sender, EventArgs e)
        //{
        //    LoginServices.Enabled = checkBox1.Checked;
        //    string nomuser = Username.Text.ToLower();
        //    string nomuser1 = label3.Text.ToLower();
        //    Intentos += 1; // += --->  Intentos = Intentos + 1  --- -= ---> Intentos = Intentos - 1 
        //    string reg = "Correo='" + Username.Text.Trim() + "' and ClaUser = '" + Txb_Clave.Text.Trim() + "'";


        //    if (_connectionString.ConsultaItem("TUsuarios", reg))
        //    {
        //        ConexionSql.VariablesGlobales.xEstIni = 1;

        //        //FormWelcome welcome = new FormWelcome();
        //        //welcome.ShowDialog();
        //        this.Hide();
        //        Dashboard FrmMenu = new Dashboard((nomuser1), (nomuser)); //(ref instance);
        //        FrmMenu.ShowDialog();
        //        FrmMenu.FormClosed += logout;

        //    }
        //    else { Txb_Clave.Focus(); MessageBox.Show("Usuario o Clave Incorrecta - Tiene " + (3 - Intentos).ToString(), "Número de Intentos"); }
        //    if ((3 - Intentos) == 0)
        //    {
        //        Txb_Usuario.Enabled = false; Txb_Clave.Enabled = false; Btn_Inicio.Enabled = false;
        //        MessageBox.Show("Supero el numero de intentos permitidos, consulte al administrador");
        //    }
        
    }
}