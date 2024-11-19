namespace WinFormsApp1
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
            txtValorC = new TextBox();
            label2 = new Label();
            txtDescuento = new TextBox();
            label3 = new Label();
            txtValorCD = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 71);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor de la compra";
            // 
            // txtValorC
            // 
            txtValorC.Location = new Point(199, 100);
            txtValorC.Name = "txtValorC";
            txtValorC.Size = new Size(130, 23);
            txtValorC.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 137);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Descuento";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(199, 166);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(130, 23);
            txtDescuento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 203);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor de la compra con descuento";
            // 
            // txtValorCD
            // 
            txtValorCD.Location = new Point(199, 232);
            txtValorCD.Name = "txtValorCD";
            txtValorCD.Size = new Size(130, 23);
            txtValorCD.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(227, 290);
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
            ClientSize = new Size(539, 453);
            Controls.Add(btnCalcular);
            Controls.Add(txtValorCD);
            Controls.Add(label3);
            Controls.Add(txtDescuento);
            Controls.Add(label2);
            Controls.Add(txtValorC);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValorC;
        private Label label2;
        private TextBox txtDescuento;
        private Label label3;
        private TextBox txtValorCD;
        private Button btnCalcular;
    }
}
