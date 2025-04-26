namespace minecraft
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnJugadores = new Button();
            btnInventario = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnJugadores
            // 
            btnJugadores.Location = new Point(144, 126);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(221, 34);
            btnJugadores.TabIndex = 0;
            btnJugadores.Text = "Gestionar Jugadores";
            btnJugadores.UseVisualStyleBackColor = true;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(144, 195);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(210, 34);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Gestionar Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(181, 291);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnInventario);
            Controls.Add(btnJugadores);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnJugadores;
        private Button btnInventario;
        private Button btnSalir;
    }
}