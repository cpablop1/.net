namespace ShowMessage
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
            liMensaje = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 62);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(111, 80);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(166, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(136, 134);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(116, 23);
            btnProcesar.TabIndex = 2;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // liMensaje
            // 
            liMensaje.FormattingEnabled = true;
            liMensaje.ItemHeight = 15;
            liMensaje.Location = new Point(55, 182);
            liMensaje.Name = "liMensaje";
            liMensaje.Size = new Size(279, 244);
            liMensaje.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 451);
            Controls.Add(liMensaje);
            Controls.Add(btnProcesar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mostrar Mensaje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnProcesar;
        private ListBox liMensaje;
    }
}
