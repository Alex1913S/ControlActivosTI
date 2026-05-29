using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion.Forms.Activos
{
    public partial class Log_Audit_Viewer : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private readonly AuditoriaDominio _auditoriaDominio = new AuditoriaDominio();


        public Log_Audit_Viewer()
        {
            InitializeComponent();
            this.Load += Log_Audit_Viewer_Load;

            this.FormBorderStyle = FormBorderStyle.None;

            this.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 20, 20)
            );

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Activa el estilo WS_EX_COMPOSITED (Doble búfer para todo el árbol de controles)
                return cp;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            this.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 20, 20)
            );
        }


        private void Log_Audit_Viewer_Load(object sender, EventArgs e)
        {

            dtpDesde.Value = DateTime.Today.AddDays(-7);
            dtpHasta.Value = DateTime.Today;

            ConsultarLogs();
        }
        private void ConsultarLogs()
        {
            try
            {
                DataTable dtLogs = _auditoriaDominio.ListarLogsAuditoria(dtpDesde.Value, dtpHasta.Value);
                dgvLogs.DataSource = dtLogs;

                if (dgvLogs.Columns["LogID"] != null) dgvLogs.Columns["LogID"].HeaderText = "ID Log";
                if (dgvLogs.Columns["TablaAfectada"] != null) dgvLogs.Columns["TablaAfectada"].HeaderText = "Tabla";
                if (dgvLogs.Columns["RegistroID"] != null) dgvLogs.Columns["RegistroID"].HeaderText = "ID Registro Activo";
                if (dgvLogs.Columns["Accion"] != null) dgvLogs.Columns["Accion"].HeaderText = "Operación";
                if (dgvLogs.Columns["UsuarioBD"] != null) dgvLogs.Columns["UsuarioBD"].HeaderText = "Usuario";
                if (dgvLogs.Columns["FechaAccion"] != null) dgvLogs.Columns["FechaAccion"].HeaderText = "Fecha y Hora";


                if (dgvLogs.Columns["DetalleAnterior"] != null) dgvLogs.Columns["DetalleAnterior"].Visible = false;
                if (dgvLogs.Columns["DetalleNuevo"] != null) dgvLogs.Columns["DetalleNuevo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ConsultarLogs();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-7);
            dtpHasta.Value = DateTime.Today;
            ConsultarLogs();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvLogs.Rows.Count == 0)
            {
                MessageBox.Show("No existen registros en el rango de fechas seleccionado para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo CSV (*.csv)|*.csv";
                sfd.FileName = $"Log_Auditoria_Activos_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var csvContent = new StringBuilder();

   
                        csvContent.AppendLine("ID Log;Tabla;ID Registro Activo;Operación;Usuario;Fecha y Hora;Detalle Anterior;Detalle Nuevo");

                        foreach (DataGridViewRow fila in dgvLogs.Rows)
                        {
                            if (fila.IsNewRow) continue;

                            string id = fila.Cells["LogID"].Value?.ToString() ?? "";
                            string tabla = fila.Cells["TablaAfectada"].Value?.ToString() ?? "";
                            string registroId = fila.Cells["RegistroID"].Value?.ToString() ?? "";
                            string accion = fila.Cells["Accion"].Value?.ToString() ?? "";
                            string usuario = fila.Cells["UsuarioBD"].Value?.ToString() ?? "";
                            string fecha = fila.Cells["FechaAccion"].Value?.ToString() ?? "";


                            string detAnt = (fila.Cells["DetalleAnterior"].Value?.ToString() ?? "").Replace("\"", "'").Replace("\r\n", " ");
                            string detNue = (fila.Cells["DetalleNuevo"].Value?.ToString() ?? "").Replace("\"", "'").Replace("\r\n", " ");

                            csvContent.AppendLine($"\"{id}\";\"{tabla}\";\"{registroId}\";\"{accion}\";\"{usuario}\";\"{fecha}\";\"{detAnt}\";\"{detNue}\"");
                        }

                        File.WriteAllText(sfd.FileName, csvContent.ToString(), Encoding.UTF8);
                        MessageBox.Show("Evidencia de auditoría exportada correctamente.", "SGSI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al escribir el archivo: {ex.Message}", "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Desea cerrar el Log de Auditoría?", "Cerrar Formulario",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta == DialogResult.Yes)
            this.Close();
        }
    }
}
