using AccesoDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static Dominio.UsuarioDominio;

namespace Presentacion
{
    public partial class Dashboard : Form
    {
        private readonly string _nombre;
        private readonly string _apellido;
        private readonly string _rol;
        private readonly string _cargo;
        private readonly byte[] _foto;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int a, int b, int c, int d, int radio1, int radio2);
        //private static extern IntPtr CreateRoundRectRgn(int a, int b, int c, int d, int radio1, int radio2);
        public Dashboard(string username, string accesskey, string rol, string Company_Position, byte[] PictureBPhoto)
        {
            InitializeComponent();
            _nombre = username;
            _apellido = accesskey;
            _rol = rol;
            _cargo = Company_Position;
            _foto = PictureBPhoto;
        }


        private void AplicarPermisos()
        {
            bool esAdmin = _rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase);
            bool esOperador = _rol.Equals("Operador", StringComparison.OrdinalIgnoreCase);

            //// Visibles para todos
            //btnVerActivos.Visible = true;
            //btnAsignaciones.Visible = true;
            //btnVerReportes.Visible = true;

            //// Operador y Administrador
            //btnEditarActivo.Visible = esAdmin || esOperador;

            //// Solo Administrador
            //btnCrearActivo.Visible = esAdmin;
            //btnEliminarActivo.Visible = esAdmin;
            //btnColaboradores.Visible = esAdmin;
            //btnDepartamentos.Visible = esAdmin;
            //btnPerfiles.Visible = esAdmin;
            //btnUsuarios.Visible = esAdmin;
            //btnExportarReporte.Visible = esAdmin;
            //btnConfiguracion.Visible = esAdmin;
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

            // Bordes redondeados del Pnlprofile
            PnlProfile.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0,
                PnlProfile.Width,
                PnlProfile.Height,
                20, 20  // ← ajusta el radio a tu gusto
            ));
            PnlTotalActivos.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0,
                PnlTotalActivos.Width,
                PnlTotalActivos.Height,
                40, 40  // ← ajusta el radio a tu gusto
            ));
            // Bordes redondeados del Pnlprofile
            PnlEnBodega.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0,
                PnlEnBodega.Width,
                PnlEnBodega.Height,
                60, 60  // ← ajusta el radio a tu gusto
            ));
            PnlMantenimiento.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0,
                PnlMantenimiento.Width,
                PnlMantenimiento.Height,
                60, 60  // ← ajusta el radio a tu gusto
            ));

            this.username.Text = $"{_nombre} {_apellido}";
            Company_Position.Text = _cargo;
            this.accesKey.Text = $"{_rol}";

            // Saludo y fecha en PnlEstadisticas
            lblSaludo.Text = $"Bienvenido, {_nombre} 👋";
            lblFecha1.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");

            CargarEstadisticas();
            CargarFotoRedonda();
            AplicarPermisos();
        }

        private void CargarEstadisticas()
        {
            try
            {
                var datos = new AccesoDatos.UsuarioAccesoDatos();
                datos.ConsultaDatos(@"
                    SELECT
                        COUNT(*) AS Total,
                        SUM(CASE WHEN EstadoOperativo = 'Asignado'
                                 THEN 1 ELSE 0 END) AS Asignados,
                        SUM(CASE WHEN EstadoOperativo = 'En Bodega'
                                 THEN 1 ELSE 0 END) AS EnBodega,
                        SUM(CASE WHEN EstadoOperativo = 'En Mantenimiento'
                                 THEN 1 ELSE 0 END) AS EnMant
                    FROM ITAM.ActivosBase",
                    "Stats");

                var fila = datos.Ds.Tables["Stats"].Rows[0];

                // Asigna a los labels de cada tarjeta
                lblTotal.Text = fila["Total"].ToString();
                lblAsignados.Text = fila["Asignados"].ToString();
                lblBodega.Text = fila["EnBodega"].ToString();
                lblMant.Text = fila["EnMant"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando estadísticas: {ex.Message}",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarActivosRecientes()
        {
            try
            {
                var datos = new AccesoDatos.UsuarioAccesoDatos();
                datos.ConsultaDatos(@"
                    SELECT TOP 8
                        a.EtiquetaActivo,
                        c.Nombre AS Categoria,
                        a.Marca,
                        a.Modelo,
                        a.EstadoOperativo,
                        CONVERT(varchar, a.FechaRegistro, 103) AS FechaRegistro
                    FROM ITAM.ActivosBase a
                    INNER JOIN ITAM.CategoriasActivo c
                        ON a.CategoriaID = c.CategoriaID
                    ORDER BY a.FechaRegistro DESC",
                    "Recientes");

                dgvRecientes.DataSource = datos.Ds.Tables["Recientes"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando activos: {ex.Message}",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarPanel(Panel panelActivo)
        {
            // Oculta todos
            PnlEstadisticas.Visible = false;
            PnlAgregarActivo.Visible = false;

            // Muestra solo el elegido
            panelActivo.Visible = true;
            panelActivo.BringToFront();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {

        }

        private void CargarFotoRedonda()
        {
            Image imagen;

            if (_foto != null && _foto.Length > 0)
            {
                using var ms = new System.IO.MemoryStream(_foto);
                imagen = Image.FromStream(ms);
            }
            else
            {
                // Foto por defecto si no tiene | Evitar error de inicio en el form
                imagen = Properties.Resources.default_user;
            }

            PictureBPhoto.Image = HacerImagenRedonda(imagen, PictureBPhoto.Width);
            PictureBPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image HacerImagenRedonda(Image imagen, int tamaño)
        {
            Bitmap bmp = new Bitmap(tamaño, tamaño);
            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            using var path = new GraphicsPath();
            path.AddEllipse(0, 0, tamaño, tamaño);
            g.SetClip(path);
            g.DrawImage(imagen, 0, 0, tamaño, tamaño);

            return bmp;
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
                "¿Desea cerrar sesión?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta == DialogResult.Yes)
                this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarCombo(ComboBox cmb, string sql,
                          string display, string value)
        {
            var datos = new AccesoDatos.UsuarioAccesoDatos();
            datos.ConsultaDatos(sql, "Tabla");
            cmb.DataSource = datos.Ds.Tables["Tabla"];
            cmb.DisplayMember = display;
            cmb.ValueMember = value;
            cmb.SelectedIndex = -1;
        }

        private void CargarCombosActivo()
        {
            // Tab 1 — Información Base
            CargarCombo(cmbCategoria,
                "SELECT CategoriaID, Nombre FROM ITAM.CategoriasActivo",
                "Nombre", "CategoriaID");

            CargarCombo(cmbUbicacion,
                "SELECT UbicacionID, NombreNomenclatura FROM Core.Ubicaciones",
                "NombreNomenclatura", "UbicacionID");

            CargarCombo(cmbProveedor,
                "SELECT ProveedorID, RazonSocial FROM Core.Proveedores",
                "RazonSocial", "ProveedorID");

            // Solo agrega los items una vez
            if (cmbEstadoOperativo.Items.Count == 0)
            {
                cmbEstadoOperativo.Items.AddRange(new string[]
                {
                    "En Bodega",
                    "Asignado",
                    "En Mantenimiento",
                    "De Baja"
                });
            }
            cmbEstadoOperativo.SelectedIndex = 0;
        }


        private void BtnAgregarActivo_Click(object sender, EventArgs e)
        {
            MostrarPanel(PnlAgregarActivo);
            CargarCombosActivo();
        }

        private bool ValidarFormActivo()
        {
            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            if (cmbUbicacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una ubicación.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUbicacion.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtCosto.Text) &&
                !decimal.TryParse(txtCosto.Text, out _))
            {
                MessageBox.Show("El costo debe ser un valor numérico.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarFormActivo()
        {
            // Tab 1 — ActivosBase
            cmbCategoria.SelectedIndex = -1;
            cmbUbicacion.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            cmbEstadoOperativo.SelectedIndex = 0;
            dtpFechaAdquisicion.Checked = false;
            txtCosto.Clear();

            // Tab 2 — EspecificacionesHardware
            txtMarca.Clear();
            txtModelo.Clear();
            txtNumeroSerie.Clear();
            txtProcesador.Clear();
            txtMemoriaRAM.Clear();
            txtAlmacenamiento1.Clear();
            txtAlmacenamiento2.Clear();
            txtTarjetaGrafica.Clear();
            txtSistemaOperativo.Clear();
            txtDireccionMAC.Clear();
            txtDireccionIP.Clear();
            txtResolucionPantalla.Clear();
        }

        private void BtnCancelarActivo_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
                "¿Desea cancelar el registro?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rta == DialogResult.Yes)
            {
                LimpiarFormActivo();
                MostrarPanel(PnlEstadisticas);
            }
        }

        private void BtnGuardarActivo_Click(object sender, EventArgs e)
        {
            if (!ValidarFormActivo()) return;

            decimal? costo = string.IsNullOrWhiteSpace(txtCosto.Text)
                             ? null
                             : decimal.Parse(txtCosto.Text);

            DateTime? fecha = dtpFechaAdquisicion.Checked
                              ? dtpFechaAdquisicion.Value
                              : null;

            int? proveedorId = cmbProveedor.SelectedIndex == -1
                               ? null
                               : (int?)cmbProveedor.SelectedValue;

            var dominio = new ActivosDominio();
            var resultado = dominio.CrearActivo(
                // ── Tab 1 → ITAM.ActivosBase ─────────────────────────
                (int)cmbCategoria.SelectedValue,
                (int)cmbUbicacion.SelectedValue,
                txtMarca.Text.Trim(),
                txtModelo.Text.Trim(),
                txtNumeroSerie.Text.Trim(),
                proveedorId,
                fecha,
                costo,
                cmbEstadoOperativo.Text,

                // ── Tab 2 → ITAM.EspecificacionesHardware ────────────
                txtProcesador.Text.Trim(),
                txtMemoriaRAM.Text.Trim(),
                txtAlmacenamiento1.Text.Trim(),
                txtAlmacenamiento2.Text.Trim(),
                txtTarjetaGrafica.Text.Trim(),
                txtSistemaOperativo.Text.Trim(),
                txtDireccionMAC.Text.Trim(),
                txtDireccionIP.Text.Trim(),
                txtResolucionPantalla.Text.Trim()
            );

            MessageBox.Show(
                resultado.Mensaje,
                resultado.Exitoso ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                resultado.Exitoso
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Error);

            if (resultado.Exitoso)
            {
                LimpiarFormActivo();
                MostrarPanel(PnlEstadisticas);  // ← Vuelve al inicio
                //CargarEstadisticas();            // ← Refresca números
                //CargarActivosRecientes();        // ← Refresca tabla
            }
        }

        private void BtnEstadistica_Click(object sender, EventArgs e)
        {
            MostrarPanel(PnlEstadisticas);
            CargarEstadisticas();
            CargarActivosRecientes();
        }
    }
}
