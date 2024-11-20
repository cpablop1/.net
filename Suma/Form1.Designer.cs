namespace Suma
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
            txtNumero1 = new TextBox();
            label2 = new Label();
            txtNumero2 = new TextBox();
            btnSumar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(107, 71);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el primer valor";
            // 
            // txtNumero1
            // 
            txtNumero1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNumero1.Location = new Point(136, 100);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(124, 29);
            txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(100, 137);
            label2.Name = "label2";
            label2.Size = new Size(197, 21);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el segundo valor";
            // 
            // txtNumero2
            // 
            txtNumero2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNumero2.Location = new Point(136, 166);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(124, 29);
            txtNumero2.TabIndex = 3;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSumar.Location = new Point(149, 203);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(98, 55);
            btnSumar.TabIndex = 4;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 417);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero2);
            Controls.Add(label2);
            Controls.Add(txtNumero1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private Button btnSumar;
    }
}
