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
using minecraft.Models;
using minecraft.Utils;

namespace minecraft
{
    public partial class FormJugadores : Form
    {
        private readonly JugadorService jugadorService;
        public FormJugadores()
        {
            InitializeComponent();
            var dbManager = new DatabaseManager(); // Instancia de DatabaseManager
            jugadorService = new JugadorService(dbManager); // Pasa dbManager al constructor
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            var lista = jugadorService.ObtenerTodos();
            dgvJugadores.DataSource = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var jugador = new Jugador
            {
                Nombre = txtNombre.Text,
                Nivel = int.Parse(txtNivel.Text)
            };

            jugadorService.Crear(jugador);
            CargarJugadores();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.SelectedRows.Count > 0)
            {
                int id = (int)dgvJugadores.SelectedRows[0].Cells["Id"].Value;
                var jugador = new Jugador
                {
                    Id = id,
                    Nombre = txtNombre.Text,
                    Nivel = int.Parse(txtNivel.Text)
                };

                jugadorService.Actualizar(jugador);
                CargarJugadores();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona un jugador para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.SelectedRows.Count > 0)
            {
                int id = (int)dgvJugadores.SelectedRows[0].Cells["Id"].Value;
                jugadorService.Eliminar(id);
                CargarJugadores();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona un jugador para eliminar.");
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtNivel.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Nothing usefull
        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormJugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
