namespace SelectMonth
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
            cmbNumero = new ComboBox();
            label2 = new Label();
            txtMes = new TextBox();
            bntProcesar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 81);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione un número";
            // 
            // cmbNumero
            // 
            cmbNumero.FormattingEnabled = true;
            cmbNumero.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbNumero.Location = new Point(256, 114);
            cmbNumero.Name = "cmbNumero";
            cmbNumero.Size = new Size(216, 23);
            cmbNumero.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 155);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Mes seleccionado";
            // 
            // txtMes
            // 
            txtMes.Location = new Point(256, 188);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(216, 23);
            txtMes.TabIndex = 3;
            // 
            // bntProcesar
            // 
            bntProcesar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntProcesar.Location = new Point(256, 229);
            bntProcesar.Name = "bntProcesar";
            bntProcesar.Size = new Size(216, 35);
            bntProcesar.TabIndex = 4;
            bntProcesar.Text = "Procesar";
            bntProcesar.UseVisualStyleBackColor = true;
            bntProcesar.Click += bntProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntProcesar);
            Controls.Add(txtMes);
            Controls.Add(label2);
            Controls.Add(cmbNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbNumero;
        private Label label2;
        private TextBox txtMes;
        private Button bntProcesar;
    }
}
