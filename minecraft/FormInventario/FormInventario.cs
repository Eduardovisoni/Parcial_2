using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using minecraft.Services;
using minecraft.Utils;

namespace minecraft
{
    public partial class FormInventario : Form
    {

        private readonly InventarioService inventarioService;
        public FormInventario()
        {
            InitializeComponent();
            var dbManager = new DatabaseManager();
            var jugadorService = new JugadorService(dbManager);
            var bloqueService = new BloqueService(dbManager);
            inventarioService = new InventarioService(dbManager, jugadorService, bloqueService);
            CargarInventario();
            CargarFiltro();
        }

        private void CargarInventario()
        {
            var lista = inventarioService.ObtenerTodos();
            dgvInventario.DataSource = lista;
        }

        private void CargarFiltro()
        {
            cmbFiltro.Items.Add("Todos");
            cmbFiltro.Items.Add("Común");
            cmbFiltro.Items.Add("Raro");
            cmbFiltro.Items.Add("Épico");
            cmbFiltro.SelectedIndex = 0;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltro.SelectedItem.ToString();

            if (filtro == "Todos")
            {
                CargarInventario();
            }
            else
            {
                var listaFiltrada = inventarioService.ObtenerInventarioPorRareza(filtro);
                dgvInventario.DataSource = listaFiltrada;
            }
        }
        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "inventario.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        
                        var headers = dgvInventario.Columns.Cast<DataGridViewColumn>();
                        sw.WriteLine(string.Join(",", headers.Select(col => col.HeaderText)));

                        foreach (DataGridViewRow row in dgvInventario.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cells = row.Cells.Cast<DataGridViewCell>();
                                sw.WriteLine(string.Join(",", cells.Select(cell => cell.Value?.ToString())));
                            }
                        }
                    }

                    MessageBox.Show("Inventario exportado exitosamente.", "Exportación completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Nothing Usefull

        private void FormInventario_Load(object sender, EventArgs e)
        {
        }
        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
