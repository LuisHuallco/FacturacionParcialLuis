namespace SistemaFacturacionParcial2.Views.Producto
{
    partial class frm_NuevoProducto
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCodigo = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecioVenta = new TextBox();
            txtPrecioCompra = new TextBox();
            txtStock = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 95);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 141);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 189);
            label3.Name = "label3";
            label3.Size = new Size(175, 32);
            label3.TabIndex = 2;
            label3.Text = "Precio Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 235);
            label4.Name = "label4";
            label4.Size = new Size(146, 32);
            label4.TabIndex = 3;
            label4.Text = "Precio Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 282);
            label5.Name = "label5";
            label5.Size = new Size(192, 32);
            label5.TabIndex = 4;
            label5.Text = "Cantidad (Stock):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(204, 27);
            label6.Name = "label6";
            label6.Size = new Size(189, 31);
            label6.TabIndex = 5;
            label6.Text = "Nuevo Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(246, 92);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(318, 39);
            txtCodigo.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(246, 138);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(318, 39);
            txtDescripcion.TabIndex = 7;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(246, 232);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(318, 39);
            txtPrecioVenta.TabIndex = 9;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(246, 183);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(318, 39);
            txtPrecioCompra.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(246, 279);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(318, 39);
            txtStock.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightSkyBlue;
            btnGuardar.Location = new Point(147, 336);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(305, 51);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar Producto";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frm_NuevoProducto
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 445);
            Controls.Add(btnGuardar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 3, 5, 3);
            Name = "frm_NuevoProducto";
            Text = "frm_NuevoProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCompra;
        private TextBox txtStock;
        private Button btnGuardar;
    }
}