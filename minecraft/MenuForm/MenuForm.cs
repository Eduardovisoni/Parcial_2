using minecraft.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraft
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            if (db.TestConnection())
            {
                MessageBox.Show("Conexión exitosa, ahora puedes usar el programa", "Succesfull Login");
            }
            else
            {
                MessageBox.Show("Error de conexión");
            }
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            FormJugadores form = new FormJugadores();
            form.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormInventario form = new FormInventario();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
