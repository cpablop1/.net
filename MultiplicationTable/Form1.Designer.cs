namespace MultiplicationTable
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
            liTabla = new ListBox();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 58);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(208, 76);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(158, 23);
            txtNumero.TabIndex = 1;
            // 
            // liTabla
            // 
            liTabla.FormattingEnabled = true;
            liTabla.ItemHeight = 15;
            liTabla.Location = new Point(160, 175);
            liTabla.Name = "liTabla";
            liTabla.Size = new Size(255, 169);
            liTabla.TabIndex = 2;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(250, 124);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 23);
            btnProcesar.TabIndex = 3;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 439);
            Controls.Add(btnProcesar);
            Controls.Add(liTabla);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tabla de mulplicar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private ListBox liTabla;
        private Button btnProcesar;
    }
}
