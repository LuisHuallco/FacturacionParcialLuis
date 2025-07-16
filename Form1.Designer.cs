namespace SistemaFacturacionParcial2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVentas = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnSalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI", 14F);
            btnVentas.Location = new Point(54, 50);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(300, 127);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 14F);
            btnProductos.Location = new Point(54, 183);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(300, 127);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 14F);
            btnClientes.Location = new Point(54, 316);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(300, 127);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(111, 459);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(188, 57);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 31);
            label1.TabIndex = 4;
            label1.Text = "Menu Principal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 549);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnClientes);
            Controls.Add(btnProductos);
            Controls.Add(btnVentas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVentas;
        private Button btnProductos;
        private Button btnClientes;
        private Button btnSalir;
        private Label label1;
    }
}
