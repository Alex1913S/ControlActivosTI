using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Dominio.UsuarioDominio;

namespace Presentacion.Forms.Activos
{
    public partial class Asset_ManagementViewer : Form
    {
        private Guid _activoSeleccionadoId = Guid.Empty;
        private string _estadoActivoSeleccionado = "";

        private DataTable _dtTodosLosActivos = null;
        private readonly ActivosDominio _activosDominio = new ActivosDominio(); 

        private bool _cargando = true;

        public Asset_ManagementViewer()
        {
            InitializeComponent();
            this.Load += Asset_ManagementViewer_Load;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        private void Asset_ManagementViewer_Load(object sender, EventArgs e)
        {

            try
            {
                _cargando = true;

                DataTable dtCategorias = _activosDominio.ObtenerCategorias();
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "CategoriaID";
                cmbCategoria.DataSource = dtCategorias;

                DataTable dtFiltroCat = dtCategorias.Copy();
                DataRow rowTodas = dtFiltroCat.NewRow();
                rowTodas["CategoriaID"] = 0;
                rowTodas["Nombre"] = "— Todas las Categorías —";
                dtFiltroCat.Rows.InsertAt(rowTodas, 0);

                cmbFiltroCategoria.DisplayMember = "Nombre";
                cmbFiltroCategoria.ValueMember = "CategoriaID";
                cmbFiltroCategoria.DataSource = dtFiltroCat;
                cmbFiltroCategoria.SelectedIndex = 0;


                DataTable dtUbicaciones = _activosDominio.ObtenerUbicaciones();
                cmbUbicacion.DisplayMember = "NombreNomenclatura";
                cmbUbicacion.ValueMember = "UbicacionID";
                cmbUbicacion.DataSource = dtUbicaciones;

                cmbEstadoOperativo.Items.Clear();
                cmbEstadoOperativo.Items.AddRange(new object[] { "En Bodega", "Asignado", "En Mantenimiento" });
                cmbEstadoOperativo.SelectedIndex = 0;


                cmbFiltroEstado.Items.Clear();
                cmbFiltroEstado.Items.AddRange(new object[] { "— Todos los Estados —", "En Bodega", "Asignado", "En Mantenimiento" });
                cmbFiltroEstado.SelectedIndex = 0;

                RefrescarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar catálogos: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargando = false;


                if (dgvActivos.CurrentRow != null)
                {
                    dgvActivos_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }

        private void RefrescarGrid()
        {
            _dtTodosLosActivos = _activosDominio.ListarActivos();
            dgvActivos.AutoGenerateColumns = true;
            AplicarFiltrosCombinados();
        }

        private void AplicarFiltrosCombinados()
        {
            if (_dtTodosLosActivos == null) return;

            DataView dv = new DataView(_dtTodosLosActivos);
            List<string> filtros = new List<string>();

            if (cmbFiltroCategoria.SelectedValue != null &&
                int.TryParse(cmbFiltroCategoria.SelectedValue.ToString(), out int catId) &&
                catId > 0)
            {
                filtros.Add($"CategoriaID = {catId}");
            }

            string estadoSel = cmbFiltroEstado.SelectedItem?.ToString() ?? "— Todos los Estados —";
            if (estadoSel != "— Todos los Estados —")
            {
                filtros.Add($"EstadoOperativo = '{estadoSel.Replace("'", "''")}'");
            }

            if (filtros.Count > 0)
            {
                dv.RowFilter = string.Join(" AND ", filtros);
            }
            else
            {
                dv.RowFilter = "";
            }


            dgvActivos.DataSource = dv;


            if (dgvActivos.Columns["ActivoID"] != null) dgvActivos.Columns["ActivoID"].Visible = false;
            if (dgvActivos.Columns["CategoriaID"] != null) dgvActivos.Columns["CategoriaID"].Visible = false;
            if (dgvActivos.Columns["UbicacionID"] != null) dgvActivos.Columns["UbicacionID"].Visible = false;

            if (dgvActivos.Columns["ActivoID"] != null) dgvActivos.Columns["ActivoID"].Visible = false;
            if (dgvActivos.Columns["CategoriaID"] != null) dgvActivos.Columns["CategoriaID"].Visible = false;
            if (dgvActivos.Columns["UbicacionID"] != null) dgvActivos.Columns["UbicacionID"].Visible = false;

            if (dgvActivos.Columns["Procesador"] != null) dgvActivos.Columns["Procesador"].Visible = true;
            if (dgvActivos.Columns["MemoriaRAM"] != null) dgvActivos.Columns["MemoriaRAM"].Visible = true;
            if (dgvActivos.Columns["Almacenamiento1"] != null) dgvActivos.Columns["Almacenamiento1"].Visible = true;
            if (dgvActivos.Columns["Almacenamiento2"] != null) dgvActivos.Columns["Almacenamiento2"].Visible = true;
            if (dgvActivos.Columns["TarjetaGrafica"] != null) dgvActivos.Columns["TarjetaGrafica"].Visible = true;
            if (dgvActivos.Columns["SistemaOperativo"] != null) dgvActivos.Columns["SistemaOperativo"].Visible = true;
            if (dgvActivos.Columns["DireccionMAC"] != null) dgvActivos.Columns["DireccionMAC"].Visible = true;
            if (dgvActivos.Columns["DireccionIP_Estatica"] != null) dgvActivos.Columns["DireccionIP_Estatica"].Visible = true;
            if (dgvActivos.Columns["ResolucionPantalla"] != null) dgvActivos.Columns["ResolucionPantalla"].Visible = true;
        }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltrosCombinados();
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltrosCombinados();
        }

        private void dgvActivos_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargando) return;

            if (dgvActivos.CurrentRow == null || dgvActivos.CurrentRow.Index < 0) return;

            DataGridViewRow fila = dgvActivos.CurrentRow;

            _activoSeleccionadoId = (Guid)fila.Cells["ActivoID"].Value;
            _estadoActivoSeleccionado = fila.Cells["EstadoOperativo"].Value.ToString();

            cmbCategoria.SelectedValue = fila.Cells["CategoriaID"].Value;
            cmbUbicacion.SelectedValue = fila.Cells["UbicacionID"].Value;
            cmbEstadoOperativo.Text = _estadoActivoSeleccionado;


            txtMarca.Text = fila.Cells["Marca"].Value?.ToString() ?? "";
            txtModelo.Text = fila.Cells["Modelo"].Value?.ToString() ?? "";
            txtNumeroSerie.Text = fila.Cells["NumeroSerie"].Value?.ToString() ?? "";
            txtCosto.Text = fila.Cells["Costo"].Value?.ToString() ?? "0";

            if (fila.Cells["FechaAdquisicion"].Value != DBNull.Value)
            {
                dtpFechaAdquisicion.Value = Convert.ToDateTime(fila.Cells["FechaAdquisicion"].Value);
                dtpFechaAdquisicion.Checked = true;
            }
            else
            {
                dtpFechaAdquisicion.Checked = false;
            }
            txtProcesador.Text = fila.Cells["Procesador"].Value?.ToString() ?? "";
            txtMemoriaRAM.Text = fila.Cells["MemoriaRAM"].Value?.ToString() ?? "";
            txtAlmacenamiento1.Text = fila.Cells["Almacenamiento1"].Value?.ToString() ?? "";
            txtAlmacenamiento2.Text = fila.Cells["Almacenamiento2"].Value?.ToString() ?? "";
            txtTarjetaGrafica.Text = fila.Cells["TarjetaGrafica"].Value?.ToString() ?? "";
            txtSistemaOperativo.Text = fila.Cells["SistemaOperativo"].Value?.ToString() ?? "";
            txtDireccionMAC.Text = fila.Cells["DireccionMAC"].Value?.ToString() ?? "";
            txtDireccionIP.Text = fila.Cells["DireccionIP_Estatica"].Value?.ToString() ?? "";
            txtResolucionPantalla.Text = fila.Cells["ResolucionPantalla"].Value?.ToString() ?? "";
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_activoSeleccionadoId == Guid.Empty)
            {
                MessageBox.Show("Por favor, seleccione un activo de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedIndex == -1 || cmbUbicacion.SelectedIndex == -1)
            {
                MessageBox.Show("Categoría y Ubicación son campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal? costo = string.IsNullOrWhiteSpace(txtCosto.Text) ? null : (decimal?)decimal.Parse(txtCosto.Text);
            DateTime? fecha = dtpFechaAdquisicion.Checked ? (DateTime?)dtpFechaAdquisicion.Value : null;

            ResultadoActivo resultado = _activosDominio.ModificarActivo(
                _activoSeleccionadoId,
                (int)cmbCategoria.SelectedValue,
                (int)cmbUbicacion.SelectedValue,
                txtMarca.Text.Trim(),
                txtModelo.Text.Trim(),
                txtNumeroSerie.Text.Trim(),
                null,
                fecha,
                costo,
                cmbEstadoOperativo.Text,
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

            if (resultado.Exitoso)
            {
                MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarGrid(); 
                LimpiarControles();
            }
            else
            {
                MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_activoSeleccionadoId == Guid.Empty)
            {
                MessageBox.Show("Seleccione el activo que desea eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult pregunta = MessageBox.Show(
                $"¿Está completamente seguro de dar de baja el activo con número de serie '{txtNumeroSerie.Text}'?\n\nEsta acción resguardará el historial pero cambiará su disponibilidad operativa.",
                "Confirmación de Baja Técnica",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (pregunta == DialogResult.Yes)
            {
                ResultadoActivo resultado = _activosDominio.EliminarActivoLogico(_activoSeleccionadoId, _estadoActivoSeleccionado);

                if (resultado.Exitoso)
                {
                    MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarGrid();
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje, "Restricción de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            
            _activoSeleccionadoId = Guid.Empty;
            _estadoActivoSeleccionado = "";

            dgvActivos.ClearSelection();

            txtMarca.Clear();
            txtModelo.Clear();
            txtNumeroSerie.Clear();
            txtCosto.Text = "0";
            dtpFechaAdquisicion.Value = DateTime.Today;
            dtpFechaAdquisicion.Checked = false;

            txtProcesador.Clear();
            txtMemoriaRAM.Clear();
            txtAlmacenamiento1.Clear();
            txtAlmacenamiento2.Clear();
            txtTarjetaGrafica.Clear();
            txtSistemaOperativo.Clear();
            txtDireccionMAC.Clear();
            txtDireccionIP.Clear();
            txtResolucionPantalla.Clear();

            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;
            if (cmbUbicacion.Items.Count > 0) cmbUbicacion.SelectedIndex = 0;
            if (cmbEstadoOperativo.Items.Count > 0) cmbEstadoOperativo.SelectedIndex = 0;
        }

        private void tabControl1_DrawItem_1(object sender, DrawItemEventArgs e)
        {

        }
    }
}
