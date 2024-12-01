namespace DataGridView
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
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtProducto = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            btnIngresar = new Button();
            btnEliminar = new Button();
            dgvProductos = new System.Windows.Forms.DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            label4 = new Label();
            txtTotalCompra = new TextBox();
            label5 = new Label();
            txtTotalProductos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 45);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(38, 63);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 45);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(160, 63);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(154, 23);
            txtProducto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 45);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(336, 63);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(38, 114);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(160, 114);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { codigo, descripcion, precio });
            dgvProductos.Location = new Point(38, 156);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(495, 258);
            dgvProductos.TabIndex = 8;
            // 
            // codigo
            // 
            codigo.Frozen = true;
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.Frozen = true;
            descripcion.HeaderText = "Descripción Productos";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 250;
            // 
            // precio
            // 
            precio.Frozen = true;
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(336, 451);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "Total Compra:";
            // 
            // txtTotalCompra
            // 
            txtTotalCompra.Location = new Point(425, 448);
            txtTotalCompra.Name = "txtTotalCompra";
            txtTotalCompra.Size = new Size(100, 23);
            txtTotalCompra.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 448);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 11;
            label5.Text = "Total Productos:";
            // 
            // txtTotalProductos
            // 
            txtTotalProductos.Location = new Point(140, 448);
            txtTotalProductos.Name = "txtTotalProductos";
            txtTotalProductos.Size = new Size(100, 23);
            txtTotalProductos.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 487);
            Controls.Add(txtTotalProductos);
            Controls.Add(label5);
            Controls.Add(txtTotalCompra);
            Controls.Add(label4);
            Controls.Add(dgvProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnIngresar);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtProducto;
        private Label label3;
        private TextBox txtPrecio;
        private Button btnIngresar;
        private Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn precio;
        private Label label4;
        private TextBox txtTotalCompra;
        private Label label5;
        private TextBox txtTotalProductos;
    }
}
