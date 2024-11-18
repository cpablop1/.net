namespace FirstApp
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
            BntVerMensaje = new Button();
            txtMensaje = new TextBox();
            SuspendLayout();
            // 
            // BntVerMensaje
            // 
            BntVerMensaje.Location = new Point(92, 133);
            BntVerMensaje.Name = "BntVerMensaje";
            BntVerMensaje.Size = new Size(113, 43);
            BntVerMensaje.TabIndex = 0;
            BntVerMensaje.Text = "Ver mensaje";
            BntVerMensaje.UseVisualStyleBackColor = true;
            BntVerMensaje.Click += BntVerMensaje_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(70, 74);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(158, 23);
            txtMensaje.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 400);
            Controls.Add(txtMensaje);
            Controls.Add(BntVerMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BntVerMensaje;
        private TextBox txtMensaje;
    }
}
