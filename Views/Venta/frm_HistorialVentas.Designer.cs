namespace SistemaFacturacionParcial2.Views.Venta
{
    partial class frm_HistorialVentas
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
            dgvHistorialVentas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtBuscarFactura = new TextBox();
            btnAnularVenta = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorialVentas
            // 
            dgvHistorialVentas.AllowUserToAddRows = false;
            dgvHistorialVentas.AllowUserToDeleteRows = false;
            dgvHistorialVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialVentas.Location = new Point(12, 106);
            dgvHistorialVentas.Name = "dgvHistorialVentas";
            dgvHistorialVentas.ReadOnly = true;
            dgvHistorialVentas.RowHeadersWidth = 51;
            dgvHistorialVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialVentas.Size = new Size(926, 388);
            dgvHistorialVentas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 31);
            label1.TabIndex = 1;
            label1.Text = "HISTORIAL DE VENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 68);
            label2.Name = "label2";
            label2.Size = new Size(336, 32);
            label2.TabIndex = 2;
            label2.Text = "Buscar por numero de factura:";
            // 
            // txtBuscarFactura
            // 
            txtBuscarFactura.Location = new Point(391, 61);
            txtBuscarFactura.Name = "txtBuscarFactura";
            txtBuscarFactura.Size = new Size(547, 39);
            txtBuscarFactura.TabIndex = 3;
            // 
            // btnAnularVenta
            // 
            btnAnularVenta.BackColor = Color.RosyBrown;
            btnAnularVenta.ForeColor = Color.Black;
            btnAnularVenta.Location = new Point(638, 517);
            btnAnularVenta.Name = "btnAnularVenta";
            btnAnularVenta.Size = new Size(300, 50);
            btnAnularVenta.TabIndex = 4;
            btnAnularVenta.Text = "Anular Factura";
            btnAnularVenta.UseVisualStyleBackColor = false;
            btnAnularVenta.Click += btnAnularVenta_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Location = new Point(12, 517);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(300, 50);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frm_HistorialVentas
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 579);
            Controls.Add(btnActualizar);
            Controls.Add(btnAnularVenta);
            Controls.Add(txtBuscarFactura);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvHistorialVentas);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_HistorialVentas";
            Text = "frm_HistorialVentas";
            Load += frm_HistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorialVentas;
        private Label label1;
        private Label label2;
        private TextBox txtBuscarFactura;
        private Button btnAnularVenta;
        private Button btnActualizar;
    }
}