namespace RadioButton
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
            txtCompra = new TextBox();
            rdDescuento10 = new System.Windows.Forms.RadioButton();
            rdDescuento15 = new System.Windows.Forms.RadioButton();
            rdDescuento20 = new System.Windows.Forms.RadioButton();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 51);
            label1.Name = "label1";
            label1.Size = new Size(230, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el valor de la compra";
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(127, 92);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(230, 23);
            txtCompra.TabIndex = 1;
            // 
            // rdDescuento10
            // 
            rdDescuento10.AutoSize = true;
            rdDescuento10.Location = new Point(127, 159);
            rdDescuento10.Name = "rdDescuento10";
            rdDescuento10.Size = new Size(125, 19);
            rdDescuento10.TabIndex = 2;
            rdDescuento10.TabStop = true;
            rdDescuento10.Text = "Descuento del 10%";
            rdDescuento10.UseVisualStyleBackColor = true;
            // 
            // rdDescuento15
            // 
            rdDescuento15.AutoSize = true;
            rdDescuento15.Location = new Point(127, 209);
            rdDescuento15.Name = "rdDescuento15";
            rdDescuento15.Size = new Size(125, 19);
            rdDescuento15.TabIndex = 3;
            rdDescuento15.TabStop = true;
            rdDescuento15.Text = "Descuento del 15%";
            rdDescuento15.UseVisualStyleBackColor = true;
            // 
            // rdDescuento20
            // 
            rdDescuento20.AutoSize = true;
            rdDescuento20.Location = new Point(127, 259);
            rdDescuento20.Name = "rdDescuento20";
            rdDescuento20.Size = new Size(125, 19);
            rdDescuento20.TabIndex = 4;
            rdDescuento20.TabStop = true;
            rdDescuento20.Text = "Descuento del 20%";
            rdDescuento20.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(127, 320);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 30);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(btnCalcular);
            Controls.Add(rdDescuento20);
            Controls.Add(rdDescuento15);
            Controls.Add(rdDescuento10);
            Controls.Add(txtCompra);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calcular descuento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCompra;
        private System.Windows.Forms.RadioButton rdDescuento10;
        private System.Windows.Forms.RadioButton rdDescuento15;
        private System.Windows.Forms.RadioButton rdDescuento20;
        private Button btnCalcular;
    }
}
