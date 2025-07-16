namespace SistemaFacturacionParcial2.Views.Producto
{
    partial class frm_AgregarStock
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
            txtBuscarDescripcion = new TextBox();
            label1 = new Label();
            dgvProductos = new DataGridView();
            txtCodigo = new TextBox();
            txtCantidadAgregar = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblStockActual = new Label();
            txtDescripcion = new TextBox();
            btnGuardarStock = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarDescripcion
            // 
            txtBuscarDescripcion.Location = new Point(365, 49);
            txtBuscarDescripcion.Name = "txtBuscarDescripcion";
            txtBuscarDescripcion.Size = new Size(398, 39);
            txtBuscarDescripcion.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 52);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 1;
            label1.Text = "Buscar por Descripcion:";
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(40, 94);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(723, 246);
            dgvProductos.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(365, 365);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(398, 39);
            txtCodigo.TabIndex = 3;
            // 
            // txtCantidadAgregar
            // 
            txtCantidadAgregar.Location = new Point(450, 523);
            txtCantidadAgregar.Name = "txtCantidadAgregar";
            txtCantidadAgregar.Size = new Size(233, 39);
            txtCantidadAgregar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 368);
            label2.Name = "label2";
            label2.Size = new Size(239, 32);
            label2.TabIndex = 5;
            label2.Text = "Codigo del Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 523);
            label3.Name = "label3";
            label3.Size = new Size(224, 32);
            label3.TabIndex = 6;
            label3.Text = "Cantidad a Agregar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 417);
            label4.Name = "label4";
            label4.Size = new Size(282, 32);
            label4.TabIndex = 7;
            label4.Text = "Descripcion del producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 469);
            label5.Name = "label5";
            label5.Size = new Size(195, 32);
            label5.TabIndex = 8;
            label5.Text = "Existencia Actual:";
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Location = new Point(526, 469);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(24, 32);
            lblStockActual.TabIndex = 10;
            lblStockActual.Text = "-";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(450, 414);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(233, 39);
            txtDescripcion.TabIndex = 11;
            // 
            // btnGuardarStock
            // 
            btnGuardarStock.BackColor = Color.MediumSeaGreen;
            btnGuardarStock.Location = new Point(50, 574);
            btnGuardarStock.Name = "btnGuardarStock";
            btnGuardarStock.Size = new Size(713, 41);
            btnGuardarStock.TabIndex = 12;
            btnGuardarStock.Text = "Guardar";
            btnGuardarStock.UseVisualStyleBackColor = false;
            btnGuardarStock.Click += btnGuardarStock_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(263, 9);
            label6.Name = "label6";
            label6.Size = new Size(224, 31);
            label6.TabIndex = 13;
            label6.Text = "INGRESO DE STOCK";
            // 
            // frm_AgregarStock
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 627);
            Controls.Add(label6);
            Controls.Add(btnGuardarStock);
            Controls.Add(txtDescripcion);
            Controls.Add(lblStockActual);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCantidadAgregar);
            Controls.Add(txtCodigo);
            Controls.Add(dgvProductos);
            Controls.Add(label1);
            Controls.Add(txtBuscarDescripcion);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_AgregarStock";
            Text = "frm_AgregarStock";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarDescripcion;
        private Label label1;
        private DataGridView dgvProductos;
        private TextBox txtCodigo;
        private TextBox txtCantidadAgregar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblStockActual;
        private TextBox txtDescripcion;
        private Button btnGuardarStock;
        private Label label6;

    }
}