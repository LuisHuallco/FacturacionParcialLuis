namespace SistemaFacturacionParcial2.Views.Venta
{
    partial class frm_Ventas
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
            label1 = new Label();
            lblBuscarCli = new Label();
            txtBuscarCli = new TextBox();
            dgvClientes = new DataGridView();
            dgvProductos = new DataGridView();
            txtBuscarProd = new TextBox();
            lblBuscarProd = new Label();
            lblClienteSel = new Label();
            lblProductoSel = new Label();
            lblStockDisp = new Label();
            lblPrecioUnit = new Label();
            lblCantidad = new Label();
            cbClientes = new ComboBox();
            btnNuevoCliente = new Button();
            txtCantidad = new TextBox();
            lblTotal1 = new Label();
            btnVerHistorial = new Button();
            btnGuardarVenta = new Button();
            lblProductoSeleccionado = new Label();
            lblStock = new Label();
            lblPrecioUnitario = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 25);
            label1.Name = "label1";
            label1.Size = new Size(248, 31);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE VENTAS";
            // 
            // lblBuscarCli
            // 
            lblBuscarCli.AutoSize = true;
            lblBuscarCli.Location = new Point(52, 296);
            lblBuscarCli.Name = "lblBuscarCli";
            lblBuscarCli.Size = new Size(154, 30);
            lblBuscarCli.TabIndex = 1;
            lblBuscarCli.Text = "Buscar Cliente:";
            // 
            // txtBuscarCli
            // 
            txtBuscarCli.Location = new Point(277, 296);
            txtBuscarCli.Name = "txtBuscarCli";
            txtBuscarCli.Size = new Size(737, 36);
            txtBuscarCli.TabIndex = 2;
            txtBuscarCli.TextChanged += txtBuscarCli_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 338);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1039, 113);
            dgvClientes.TabIndex = 3;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(19, 117);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1034, 173);
            dgvProductos.TabIndex = 6;
            // 
            // txtBuscarProd
            // 
            txtBuscarProd.Location = new Point(277, 74);
            txtBuscarProd.Name = "txtBuscarProd";
            txtBuscarProd.Size = new Size(737, 36);
            txtBuscarProd.TabIndex = 5;
            txtBuscarProd.TextChanged += txtBuscarProd_TextChanged;
            // 
            // lblBuscarProd
            // 
            lblBuscarProd.AutoSize = true;
            lblBuscarProd.Location = new Point(53, 74);
            lblBuscarProd.Name = "lblBuscarProd";
            lblBuscarProd.Size = new Size(175, 30);
            lblBuscarProd.TabIndex = 4;
            lblBuscarProd.Text = "Buscar Producto:";
            // 
            // lblClienteSel
            // 
            lblClienteSel.AutoSize = true;
            lblClienteSel.Location = new Point(29, 483);
            lblClienteSel.Name = "lblClienteSel";
            lblClienteSel.Size = new Size(211, 30);
            lblClienteSel.TabIndex = 7;
            lblClienteSel.Text = "Cliente seleccionado";
            // 
            // lblProductoSel
            // 
            lblProductoSel.AutoSize = true;
            lblProductoSel.Location = new Point(29, 586);
            lblProductoSel.Name = "lblProductoSel";
            lblProductoSel.Size = new Size(240, 30);
            lblProductoSel.TabIndex = 8;
            lblProductoSel.Text = "Producto Seleccionado:";
            // 
            // lblStockDisp
            // 
            lblStockDisp.AutoSize = true;
            lblStockDisp.Location = new Point(29, 638);
            lblStockDisp.Name = "lblStockDisp";
            lblStockDisp.Size = new Size(178, 30);
            lblStockDisp.TabIndex = 9;
            lblStockDisp.Text = "Stock Disponible:";
            // 
            // lblPrecioUnit
            // 
            lblPrecioUnit.AutoSize = true;
            lblPrecioUnit.Location = new Point(29, 686);
            lblPrecioUnit.Name = "lblPrecioUnit";
            lblPrecioUnit.Size = new Size(153, 30);
            lblPrecioUnit.TabIndex = 10;
            lblPrecioUnit.Text = "Precio Unidad:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(29, 737);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(195, 30);
            lblCantidad.TabIndex = 11;
            lblCantidad.Text = "Cantidad a vender:";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(370, 475);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(681, 38);
            cbClientes.TabIndex = 12;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = SystemColors.ActiveCaption;
            btnNuevoCliente.Location = new Point(363, 524);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(690, 37);
            btnNuevoCliente.TabIndex = 13;
            btnNuevoCliente.Text = "Nuevo Cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(363, 731);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(688, 36);
            txtCantidad.TabIndex = 14;
            // 
            // lblTotal1
            // 
            lblTotal1.AutoSize = true;
            lblTotal1.Location = new Point(29, 794);
            lblTotal1.Name = "lblTotal1";
            lblTotal1.Size = new Size(138, 30);
            lblTotal1.TabIndex = 15;
            lblTotal1.Text = "Total a pagar";
            // 
            // btnVerHistorial
            // 
            btnVerHistorial.BackColor = Color.Yellow;
            btnVerHistorial.Location = new Point(216, 850);
            btnVerHistorial.Name = "btnVerHistorial";
            btnVerHistorial.Size = new Size(291, 37);
            btnVerHistorial.TabIndex = 16;
            btnVerHistorial.Text = "Ver Historial";
            btnVerHistorial.UseVisualStyleBackColor = false;
            btnVerHistorial.Click += btnVerHistorial_Click;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.BackColor = Color.LimeGreen;
            btnGuardarVenta.Location = new Point(534, 850);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(291, 37);
            btnGuardarVenta.TabIndex = 17;
            btnGuardarVenta.Text = "Guardar Venta";
            btnGuardarVenta.UseVisualStyleBackColor = false;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // lblProductoSeleccionado
            // 
            lblProductoSeleccionado.AutoSize = true;
            lblProductoSeleccionado.Location = new Point(370, 586);
            lblProductoSeleccionado.Name = "lblProductoSeleccionado";
            lblProductoSeleccionado.Size = new Size(22, 30);
            lblProductoSeleccionado.TabIndex = 18;
            lblProductoSeleccionado.Text = "-";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(370, 638);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(22, 30);
            lblStock.TabIndex = 19;
            lblStock.Text = "-";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(370, 686);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(22, 30);
            lblPrecioUnitario.TabIndex = 20;
            lblPrecioUnitario.Text = "-";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(370, 794);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(22, 30);
            lblTotal.TabIndex = 21;
            lblTotal.Text = "-";
            // 
            // frm_Ventas
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 899);
            Controls.Add(lblTotal);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblStock);
            Controls.Add(lblProductoSeleccionado);
            Controls.Add(btnGuardarVenta);
            Controls.Add(btnVerHistorial);
            Controls.Add(lblTotal1);
            Controls.Add(txtCantidad);
            Controls.Add(btnNuevoCliente);
            Controls.Add(cbClientes);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecioUnit);
            Controls.Add(lblStockDisp);
            Controls.Add(lblProductoSel);
            Controls.Add(lblClienteSel);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscarProd);
            Controls.Add(lblBuscarProd);
            Controls.Add(dgvClientes);
            Controls.Add(txtBuscarCli);
            Controls.Add(lblBuscarCli);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(5);
            Name = "frm_Ventas";
            Text = "frm_Ventas";
            Load += frm_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBuscarCli;
        private TextBox txtBuscarCli;
        private DataGridView dgvClientes;
        private DataGridView dgvProductos;
        private TextBox txtBuscarProd;
        private Label lblBuscarProd;
        private Label lblClienteSel;
        private Label lblProductoSel;
        private Label lblStockDisp;
        private Label lblPrecioUnit;
        private Label lblCantidad;
        private ComboBox cbClientes;
        private Button btnNuevoCliente;
        private TextBox txtCantidad;
        private Label lblTotal1;
        private Button btnVerHistorial;
        private Button btnGuardarVenta;
        private Label lblProductoSeleccionado;
        private Label lblStock;
        private Label lblPrecioUnitario;
        private Label lblTotal;
    }
}