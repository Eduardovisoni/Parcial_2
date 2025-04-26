using Microsoft.Data.SqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;

            using (var connection = new SqlConnection(@"Data Source=DESKTOP-ICSDIP0\SQLEXPRESS01;Initial Catalog=dbparcial2;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND Clave = @Clave";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", usuario);
                    command.Parameters.AddWithValue("@Clave", clave);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        this.Hide();
                        new MenuForm().Show();
                    }
                    else
                    {
                        lblMensaje.Text = "Usuario o clave incorrectos";
                        lblMensaje.ForeColor = Color.Red;
                    }
                }
            }
        }

        //Nothing usefull

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
