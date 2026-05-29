using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Forms.Colaboradores
{
    public partial class Enter_Employee : Form
    {

        private readonly ColaboradorDominio _colaboradorDominio = new ColaboradorDominio();
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int a, int b, int c, int d, int radio1, int radio2);

        public Enter_Employee()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(TuFormulario_Paint);
        }

        private void Enter_Employee_Load(object sender, EventArgs e)
        {
            // Bordes redondeados sutiles para los paneles
            PnlReg1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnlReg1.Width, PnlReg1.Height, 40, 40));
            PnlReg2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnlReg2.Width, PnlReg2.Height, 40, 40));
            PicFoto.SizeMode = PictureBoxSizeMode.Normal;
            PnlReg1.Size = PnlReg2.Size;
            PnlReg2.Location = PnlReg1.Location;


            ConfigurarComboBoxesIniciales();
            MostrarPanel1();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            this.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 40, 40)
            );
        }

        private void TuFormulario_Paint(object sender, PaintEventArgs e)
        {
            // 1. Suavizado de alta calidad para las curvas
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 2. Coloca aquí el radio exacto que usaste para redondear tu formulario (ej: 20)
            int radioEsquina = 40;

            int ancho = this.ClientSize.Width; // 1100
            int alto = this.ClientSize.Height;  // 900

            // 3. Al iniciar en (1, 1) y restar 3 al tamaño, creamos un marco perfectamente
            // centrado y simétrico que esquiva el recorte de Windows en los 4 costados.
            using (GraphicsPath rutaBorde = ObtenerRutaRendondeada(1, 1, ancho - 3, alto - 3, radioEsquina))
            {
                // Usamos el pincel normal (sin Inset) con un grosor limpio de 1 píxel
                using (Pen pincelBorde = new Pen(Color.DarkGray, 1f))
                {
                    e.Graphics.DrawPath(pincelBorde, rutaBorde);
                }
            }
        }

        private GraphicsPath ObtenerRutaRendondeada(int x, int y, int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diametro = radius * 2;

            path.StartFigure();
            // Esquina superior izquierda
            path.AddArc(x, y, diametro, diametro, 180, 90);
            // Esquina superior derecha
            path.AddArc(x + width - diametro, y, diametro, diametro, 270, 90);
            // Esquina inferior derecha
            path.AddArc(x + width - diametro, y + height - diametro, diametro, diametro, 0, 90);
            // Esquina inferior izquierda
            path.AddArc(x, y + height - diametro, diametro, diametro, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void ConfigurarComboBoxesIniciales()
        {
            // Configuración del ComboBox de Estado
            CbxEstado.Items.Clear();
            CbxEstado.Items.Add("Activo");
            CbxEstado.Items.Add("Inactivo");
            CbxEstado.SelectedIndex = 0;

            try
            {
                // 2. Cargar Departamentos desde la Base de Datos
                CbxDepartamento.DataSource = _colaboradorDominio.ListarDepartamentos();
                CbxDepartamento.DisplayMember = "Nombre";           // Lo que ve el usuario
                CbxDepartamento.ValueMember = "DepartamentoID";     // El ID real (int)

                // 3. Cargar Ubicaciones desde la Base de Datos
                CbxUbicacion.DataSource = _colaboradorDominio.ListarUbicaciones();
                CbxUbicacion.DisplayMember = "NombreNomenclatura";              // Lo que ve el usuario
                CbxUbicacion.ValueMember = "UbicacionID";           // El ID real (int)

                // 4. Cargar Perfiles desde la Base de Datos
                CbxPerfil.DataSource = _colaboradorDominio.ListarPerfiles();
                CbxPerfil.DisplayMember = "NombrePerfil";           // Lo que ve el usuario (según tu clase UsuarioAccesoDatos)
                CbxPerfil.ValueMember = "PerfilID";                 // El ID real (int)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogos iniciales: {ex.Message}",
                                "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarPanel1()
        {
            PnlReg1.Visible = true;
            PnlReg1.Enabled = true;
            PnlReg2.Visible = false;
            PnlReg2.Enabled = false;
        }

        private void MostrarPanel2()
        {
            PnlReg1.Visible = false;
            PnlReg1.Enabled = false;
            PnlReg2.Visible = true;
            PnlReg2.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Cédula y Nombre) antes de continuar.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            MostrarPanel2();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MostrarPanel1();
        }
        private Image AjustarImagenAFormatoCover(Image imgOriginal, int anchoDestino, int altoDestino)
        {
            Bitmap bmpDestino = new Bitmap(anchoDestino, altoDestino);

            using (Graphics g = Graphics.FromImage(bmpDestino))
            {

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                double ratioX = (double)anchoDestino / imgOriginal.Width;
                double ratioY = (double)altoDestino / imgOriginal.Height;
                double ratio = Math.Max(ratioX, ratioY);

                int nuevoAncho = (int)(imgOriginal.Width * ratio);
                int nuevoAlto = (int)(imgOriginal.Height * ratio);

                int posX = (anchoDestino - nuevoAncho) / 2;
                int posY = (altoDestino - nuevoAlto) / 2;

                g.DrawImage(imgOriginal, posX, posY, nuevoAncho, nuevoAlto);
            }

            return bmpDestino;
        }

        private void btnExaminarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    using (Image imgOriginal = Image.FromFile(ofd.FileName))
                    {
                        PicFoto.Image = AjustarImagenAFormatoCover(imgOriginal, PicFoto.Width, PicFoto.Height);
                    }
                }
            }
        }

        private byte[] ObtenerBytesFoto()
        {
            if (PicFoto.Image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bmp = new Bitmap(PicFoto.Image))
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                }
                return ms.ToArray();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Capturar llaves foráneas numéricas desde los ComboBox
            int deptoId = Convert.ToInt32(CbxDepartamento.SelectedValue);
            int ubiId = Convert.ToInt32(CbxUbicacion.SelectedValue);
            int perfilId = Convert.ToInt32(CbxPerfil.SelectedValue);

            // Obtener el estado seleccionado ("Activo" / "Inactivo")
            string estado = CbxEstado.SelectedItem?.ToString() ?? "Activo";

            // Convertir la foto cargada en el PictureBox a Binario
            byte[] fotoBinaria = ObtenerBytesFoto();

            // Enviar la petición de registro directamente a la Capa de Dominio
            ResultadoColaborador resultado = _colaboradorDominio.RegistrarColaborador(
                txtCedula.Text.Trim(),
                txtNombre.Text.Trim(),
                txtApellidos.Text.Trim(),
                txtCorreo.Text.Trim(),
                deptoId,
                ubiId,
                dtpFechaIngreso.Value,
                estado,
                perfilId,
                txtUsuarioApp.Text.Trim(),
                txtPassword.Text.Trim(), // Viaja plano, se encripta en Dominio de forma segura
                fotoBinaria,
                txtCargo.Text.Trim()
            );

            if (resultado.Exitoso)
            {
                MessageBox.Show(resultado.Mensaje, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(resultado.Mensaje, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Desea cerrar el formulario Nuevo Empleado?", "Cerrar Formulario",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta == DialogResult.Yes)
            this.Close();
        }
    }
}
