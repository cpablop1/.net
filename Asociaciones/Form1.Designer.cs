namespace Asociaciones
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
            groupBox1 = new GroupBox();
            btnCrearVenta = new Button();
            txtTotal = new TextBox();
            label5 = new Label();
            txtCelular = new TextBox();
            label4 = new Label();
            txtNumId = new TextBox();
            label3 = new Label();
            txtApellidos = new TextBox();
            label2 = new Label();
            txtNombres = new TextBox();
            label1 = new Label();
            dgv = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearVenta);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNumId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Venta";
            // 
            // btnCrearVenta
            // 
            btnCrearVenta.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCrearVenta.Location = new Point(162, 101);
            btnCrearVenta.Name = "btnCrearVenta";
            btnCrearVenta.Size = new Size(201, 97);
            btnCrearVenta.TabIndex = 10;
            btnCrearVenta.Text = "Crear Venta";
            btnCrearVenta.UseVisualStyleBackColor = true;
            btnCrearVenta.Click += btnCrearVenta_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(25, 139);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 121);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 8;
            label5.Text = "Total De Venta";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(394, 53);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(100, 23);
            txtCelular.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 35);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Celular";
            // 
            // txtNumId
            // 
            txtNumId.Location = new Point(263, 53);
            txtNumId.Name = "txtNumId";
            txtNumId.Size = new Size(100, 23);
            txtNumId.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 35);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Num Id";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(133, 53);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(100, 23);
            txtApellidos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 35);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(6, 53);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(100, 23);
            txtNombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 256);
            dgv.Name = "dgv";
            dgv.Size = new Size(776, 155);
            dgv.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCrearVenta;
        private TextBox txtTotal;
        private Label label5;
        private TextBox txtCelular;
        private Label label4;
        private TextBox txtNumId;
        private Label label3;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtNombres;
        private Label label1;
        private DataGridView dgv;
    }
}
