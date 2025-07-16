namespace SistemaFacturacionParcial2.Views.Cliente
{
    partial class frm_Clientes
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
            txtNombre = new TextBox();
            txtIdentificacion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvClientes = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(241, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(370, 39);
            txtNombre.TabIndex = 0;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(241, 121);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(370, 39);
            txtIdentificacion.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(241, 236);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(370, 39);
            txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(241, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 39);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 69);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 124);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 5;
            label2.Text = "Cedula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 239);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 7;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 183);
            label4.Name = "label4";
            label4.Size = new Size(76, 32);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.Location = new Point(84, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(157, 50);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.MenuHighlight;
            btnEditar.Location = new Point(301, 290);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(157, 50);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(510, 290);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(157, 50);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(27, 360);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(682, 200);
            dgvClientes.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(241, 9);
            label5.Name = "label5";
            label5.Size = new Size(252, 31);
            label5.TabIndex = 12;
            label5.Text = "GESTION DE CLIENTES";
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 577);
            Controls.Add(label5);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtNombre);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_Clientes";
            Text = "frm_Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvClientes;
        private Label label5;
    }
}