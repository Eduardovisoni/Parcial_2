namespace minecraft
{
    partial class FormInventario
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
            dgvInventario = new DataGridView();
            cmbFiltro = new ComboBox();
            btnCerrar = new Button();
            txtRareza = new Label();
            btnExportarCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(387, 12);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 62;
            dgvInventario.Size = new Size(401, 207);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            dgvInventario.SelectionChanged += dgvInventario_SelectionChanged;
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(91, 150);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(183, 33);
            cmbFiltro.TabIndex = 1;
            cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(33, 337);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(177, 92);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar pestaña y regresar a menu principal";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtRareza
            // 
            txtRareza.AutoSize = true;
            txtRareza.Location = new Point(76, 78);
            txtRareza.Name = "txtRareza";
            txtRareza.Size = new Size(231, 25);
            txtRareza.TabIndex = 3;
            txtRareza.Text = "Selecciona el tipo de Rareza";
            // 
            // btnExportarCSV
            // 
            btnExportarCSV.Location = new Point(250, 337);
            btnExportarCSV.Margin = new Padding(4, 5, 4, 5);
            btnExportarCSV.Name = "btnExportarCSV";
            btnExportarCSV.Size = new Size(157, 93);
            btnExportarCSV.TabIndex = 4;
            btnExportarCSV.Text = "Exportar a archivo CSV";
            btnExportarCSV.UseVisualStyleBackColor = true;
            btnExportarCSV.Click += btnExportarCSV_Click;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportarCSV);
            Controls.Add(txtRareza);
            Controls.Add(btnCerrar);
            Controls.Add(cmbFiltro);
            Controls.Add(dgvInventario);
            Name = "FormInventario";
            Text = "FormInventario";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbFiltro;
        private Button btnCerrar;
        private Label txtRareza;
        private DataGridView dgvInventario;
        private Button btnExportarCSV;
    }
}