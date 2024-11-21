namespace Descuento2
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
            txtTotalCompra = new TextBox();
            label2 = new Label();
            txtDescuento = new TextBox();
            label3 = new Label();
            txtTotalNeto = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 73);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Total compra";
            // 
            // txtTotalCompra
            // 
            txtTotalCompra.Location = new Point(132, 110);
            txtTotalCompra.Name = "txtTotalCompra";
            txtTotalCompra.Size = new Size(100, 23);
            txtTotalCompra.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 155);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Descuento";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(132, 192);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 237);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Total neto";
            // 
            // txtTotalNeto
            // 
            txtTotalNeto.Location = new Point(132, 274);
            txtTotalNeto.Name = "txtTotalNeto";
            txtTotalNeto.Size = new Size(100, 23);
            txtTotalNeto.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(145, 319);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 460);
            Controls.Add(btnCalcular);
            Controls.Add(txtTotalNeto);
            Controls.Add(label3);
            Controls.Add(txtDescuento);
            Controls.Add(label2);
            Controls.Add(txtTotalCompra);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTotalCompra;
        private Label label2;
        private TextBox txtDescuento;
        private Label label3;
        private TextBox txtTotalNeto;
        private Button btnCalcular;
    }
}
