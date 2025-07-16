namespace SistemaFacturacionParcial2.Views.Producto
{
    partial class frm_Productos
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
            dgvProductos = new DataGridView();
            btnNuevo = new Button();
            btnAgregarStock = new Button();
            btnDesactivar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(26, 83);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1072, 438);
            dgvProductos.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.LimeGreen;
            btnNuevo.Location = new Point(26, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(245, 55);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo Producto";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.BackColor = Color.Cyan;
            btnAgregarStock.Location = new Point(293, 12);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(245, 55);
            btnAgregarStock.TabIndex = 2;
            btnAgregarStock.Text = "Agregar Stock";
            btnAgregarStock.UseVisualStyleBackColor = false;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // btnDesactivar
            // 
            btnDesactivar.BackColor = Color.LightCoral;
            btnDesactivar.Location = new Point(563, 12);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(245, 55);
            btnDesactivar.TabIndex = 3;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = false;
            btnDesactivar.Click += btnDesactivar_Click;
            // 
            // frm_Productos
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 616);
            Controls.Add(btnDesactivar);
            Controls.Add(btnAgregarStock);
            Controls.Add(btnNuevo);
            Controls.Add(dgvProductos);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_Productos";
            Text = "frm_Productos";
            Load += frm_Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnNuevo;
        private Button btnAgregarStock;
        private Button btnDesactivar;
    }
}