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
    public partial class Employee_Viewer : Form
    {
        private readonly CN_Colaboradores _cnColaboradores = new CN_Colaboradores();
        private readonly ColaboradorDominio _colaboradorDominio = new ColaboradorDominio();
        public Employee_Viewer()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Activa el estilo Doble búfer para todo el árbol de controles)
                return cp;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas de campos requeridos
            if (string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Debe seleccionar un colaborador y completar los campos obligatorios (Cédula, Nombre y Apellidos).",
                                "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Capturar llaves foráneas numéricas desde los ComboBox
                int deptoId = Convert.ToInt32(CbxDepartamento.SelectedValue);
                int ubiId = Convert.ToInt32(CbxUbicacion.SelectedValue);
                int perfilId = Convert.ToInt32(CbxPerfil.SelectedValue);

                // Obtener el estado seleccionado ("Activo" / "Inactivo")
                string estado = CbxEstado.SelectedItem?.ToString() ?? "Activo";

                // Convertir la foto cargada a arreglo binario byte[]
                byte[] fotoBinaria = ObtenerBytesFoto();

                // Consumir el puente de modificación de la capa intermedio/Dominio (CN_Colaboradores)
                bool operacionExitosa = _cnColaboradores.EditarColaborador(
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
                    txtPassword.Text.Trim(), // Viaja plano y el procedimiento o capa de datos se encarga de resolverlo
                    fotoBinaria,
                    txtCargo.Text.Trim()
                );

                if (operacionExitosa)
                {
                    MessageBox.Show("Los datos del colaborador han sido actualizados con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarTabla(); // Recargar el grid de visualización automáticamente
                    LimpiarCampos();  // Restablecer el formulario
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la información del colaborador en la base de datos.", "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR en la transacción de modificación: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Employee_Viewer_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
            ConfigurarComboBoxesIniciales();
            ConvertirAEnteroRedondo(PicFoto);
        }

        private void RefrescarTabla()
        {
            try
            {
                // Si tienes un TextBox de búsqueda (ej: txtBuscar), lo usas, si no, pasa vacío ""
                string criterio = (this.Controls.Find("txtBuscar", true).Length > 0)
                    ? this.Controls.Find("txtBuscar", true)[0].Text.Trim()
                    : "";

                dgvColaboradores.DataSource = _cnColaboradores.MostrarColaboradores(criterio);
                EstilizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el listado de colaboradores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarComboBoxesIniciales()
        {
            CbxEstado.Items.Clear();
            CbxEstado.Items.Add("Activo");
            CbxEstado.Items.Add("Inactivo");
            CbxEstado.SelectedIndex = 0;

            try
            {
                CbxDepartamento.DataSource = _colaboradorDominio.ListarDepartamentos();
                CbxDepartamento.DisplayMember = "Nombre";
                CbxDepartamento.ValueMember = "DepartamentoID";

                CbxUbicacion.DataSource = _colaboradorDominio.ListarUbicaciones();
                CbxUbicacion.DisplayMember = "NombreNomenclatura";
                CbxUbicacion.ValueMember = "UbicacionID";

                CbxPerfil.DataSource = _colaboradorDominio.ListarPerfiles();
                CbxPerfil.DisplayMember = "NombrePerfil";
                CbxPerfil.ValueMember = "PerfilID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogos en el Viewer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstilizarGrid()
        {
            if (dgvColaboradores.Columns.Count > 0)
            {
                // 1. Configurar encabezados de lo que sí queremos mostrar
                if (dgvColaboradores.Columns["DocumentoIdentidad"] != null)
                    dgvColaboradores.Columns["DocumentoIdentidad"].HeaderText = "Identificación";

                if (dgvColaboradores.Columns["NombreCompleto"] != null)
                    dgvColaboradores.Columns["NombreCompleto"].HeaderText = "Colaborador";

                if (dgvColaboradores.Columns["Cargo"] != null)
                    dgvColaboradores.Columns["Cargo"].HeaderText = "Cargo";

                if (dgvColaboradores.Columns["Estado"] != null)
                    dgvColaboradores.Columns["Estado"].HeaderText = "Estado";

                // 2. OCULTAR las columnas que se usan por detrás pero no deben saturar la vista
                string[] columnasOcultas = { "Nombres", "Apellidos", "CorreoCorporativo", "DepartamentoID",
                                     "UbicacionID", "FechaIngreso", "PerfilID", "UsuarioApp", "Foto" };

                foreach (string col in columnasOcultas)
        {
                    if (dgvColaboradores.Columns.Contains(col))
                        dgvColaboradores.Columns[col].Visible = false;
                }

                // Diseño flat moderno
                dgvColaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvColaboradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvColaboradores.MultiSelect = false;
                dgvColaboradores.AllowUserToAddRows = false;
                dgvColaboradores.ReadOnly = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validar que exista un colaborador seleccionado en la pantalla
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Por favor, seleccione primero un colaborador de la tabla para poder eliminarlo.",
                                "Validación de Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ventana de Confirmación de Seguridad (Control estricto de SGSI)
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está completamente seguro de que desea eliminar permanentemente al colaborador con Identificación: {txtCedula.Text}?\n\nEsta acción es irreversible.",
                "Confirmar Eliminación de Registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    // 3. Ejecutar la eliminación llamando al puente de la capa de Dominio
                    bool operacionExitosa = _cnColaboradores.EliminarColaborador(txtCedula.Text.Trim());

                    if (operacionExitosa)
                    {
                        MessageBox.Show("El colaborador ha sido removido correctamente del sistema.",
                                        "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. Sincronizar y actualizar de inmediato la interfaz con los cambios
                        RefrescarTabla(); // Recarga la tabla de visualización sin el registro borrado
                        LimpiarCampos();  // Vacía los cuadros de texto, limpia la foto y desbloquea txtCedula
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la eliminación. Es posible que el registro ya no exista en la base de datos.",
                                        "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Captura errores relacionales directos de SQL Server (por ejemplo, si la cédula está vinculada como llave foránea en otra tabla de activos)
                    MessageBox.Show($"ERROR al intentar eliminar de la base de datos: {ex.Message}",
                                    "Error de Restricción / Integridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que se haga clic en una fila de datos válida y no en los títulos superiores
            if (dgvColaboradores.SelectedRows.Count > 0 && e.RowIndex >= 0)
            {
                DataGridViewRow filaActiva = dgvColaboradores.CurrentRow;

                // 1. Llave Primaria e inmutabilidad
                txtCedula.Text = filaActiva.Cells["DocumentoIdentidad"].Value?.ToString() ?? "";
                txtCedula.ReadOnly = true;

                // 2. CORREGIDO: Mapeo exacto de Nombres y Apellidos por separado
                txtNombre.Text = filaActiva.Cells["Nombres"].Value?.ToString() ?? "";
                txtApellidos.Text = filaActiva.Cells["Apellidos"].Value?.ToString() ?? "";

                // 3. CORREGIDO: Carga de TextBox faltantes (Correo, Usuario y Cargo)
                txtCorreo.Text = filaActiva.Cells["CorreoCorporativo"].Value?.ToString() ?? "";
                txtUsuarioApp.Text = filaActiva.Cells["UsuarioApp"].Value?.ToString() ?? "";
                txtCargo.Text = filaActiva.Cells["Cargo"].Value?.ToString() ?? "";

                // 4. Mapeo de la Fecha de Ingreso
                if (filaActiva.Cells["FechaIngreso"].Value != DBNull.Value)
                {
                    dtpFechaIngreso.Value = Convert.ToDateTime(filaActiva.Cells["FechaIngreso"].Value);
                }

                // 5. CORREGIDO: Actualización dinámica de ComboBoxes (Usa el ID numérico de la fila)
                if (filaActiva.Cells["DepartamentoID"].Value != DBNull.Value)
                    CbxDepartamento.SelectedValue = Convert.ToInt32(filaActiva.Cells["DepartamentoID"].Value);

                if (filaActiva.Cells["UbicacionID"].Value != DBNull.Value)
                    CbxUbicacion.SelectedValue = Convert.ToInt32(filaActiva.Cells["UbicacionID"].Value);

                if (filaActiva.Cells["PerfilID"].Value != DBNull.Value)
                    CbxPerfil.SelectedValue = Convert.ToInt32(filaActiva.Cells["PerfilID"].Value);

                // 6. Conversión estricta de Estado (Maneja el formato Boolean de SQL Server)
                if (filaActiva.Cells["Estado"].Value != DBNull.Value)
                {
                    object valEstado = filaActiva.Cells["Estado"].Value;
                    if (valEstado is bool bitEstado)
                    {
                        CbxEstado.SelectedItem = bitEstado ? "Activo" : "Inactivo";
                    }
                    else
                    {
                        string strEstado = valEstado.ToString().ToLower();
                        CbxEstado.SelectedItem = (strEstado == "true" || strEstado == "1") ? "Activo" : "Inactivo";
                    }
                }

                // 7. Reconstrucción fluida de la fotografía desde binario
                if (filaActiva.Cells["Foto"].Value != DBNull.Value)
                {
                    try
                    {
                        byte[] fotoBytes = (byte[])filaActiva.Cells["Foto"].Value;
                        if (fotoBytes != null && fotoBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(fotoBytes))
                            {
                                PicFoto.Image = Image.FromStream(ms);
                            }
                        }
                        else PicFoto.Image = null;
                    }
                    catch
                    {
                        PicFoto.Image = null;
                    }
                }
                else PicFoto.Image = null;

                // 8. Seguridad SGSI: La contraseña no se recupera por Hash irreversible, se limpia para nueva asignación
                txtPassword.Clear();


            }
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

        private void LimpiarCampos()
        {
            txtCedula.ReadOnly = false;
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtCargo.Clear();
            txtUsuarioApp.Clear();
            txtPassword.Clear();
            CbxEstado.SelectedIndex = 0;
            dtpFechaIngreso.Value = DateTime.Now;
            PicFoto.Image = null;
            
        }

        private void ConvertirAEnteroRedondo(PictureBox PicFoto)
        {
            // Forzar a que el PictureBox sea un cuadrado perfecto para evitar óvalos
            int tamaño = Math.Min(PicFoto.Width, PicFoto.Height);
            PicFoto.Width = tamaño;
            PicFoto.Height = tamaño;

            // Crear el camino en forma de elipse (círculo)
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, tamaño, tamaño);
                // Asignar la región circular al PictureBox
                PicFoto.Region = new Region(path);
            }
        }
    }
}
