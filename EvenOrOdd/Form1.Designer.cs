namespace EvenOrOdd
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
            txtNumero = new TextBox();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(21, 84);
            label1.Name = "label1";
            label1.Size = new Size(411, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número para ver si es par o impar";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 14F);
            txtNumero.Location = new Point(157, 139);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(139, 32);
            txtNumero.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnProcesar.Location = new Point(177, 193);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(98, 38);
            btnProcesar.TabIndex = 2;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 414);
            Controls.Add(btnProcesar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnProcesar;
    }
}
