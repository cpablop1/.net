namespace Promedio
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
            txtNota1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(259, 63);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 45);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 103);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese la nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 166);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 3;
            label3.Text = "Ingrese la nota 3";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(259, 121);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 4;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(259, 184);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(255, 249);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular nota";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 458);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Button btnCalcular;
    }
}
