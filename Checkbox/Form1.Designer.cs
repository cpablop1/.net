namespace Checkbox
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
            chPolimorfismo = new CheckBox();
            chAtributos = new CheckBox();
            chBucles = new CheckBox();
            chClases = new CheckBox();
            chHerencia = new CheckBox();
            btnComprobar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 33);
            label1.Name = "label1";
            label1.Size = new Size(367, 17);
            label1.TabIndex = 0;
            label1.Text = "¿Cuál de los siguientes términos son paradigmas de POO?";
            // 
            // chPolimorfismo
            // 
            chPolimorfismo.AutoSize = true;
            chPolimorfismo.Location = new Point(120, 102);
            chPolimorfismo.Name = "chPolimorfismo";
            chPolimorfismo.Size = new Size(98, 19);
            chPolimorfismo.TabIndex = 1;
            chPolimorfismo.Text = "Polimorfismo";
            chPolimorfismo.UseVisualStyleBackColor = true;
            // 
            // chAtributos
            // 
            chAtributos.AutoSize = true;
            chAtributos.Location = new Point(120, 265);
            chAtributos.Name = "chAtributos";
            chAtributos.Size = new Size(75, 19);
            chAtributos.TabIndex = 2;
            chAtributos.Text = "Atributos";
            chAtributos.UseVisualStyleBackColor = true;
            // 
            // chBucles
            // 
            chBucles.AutoSize = true;
            chBucles.Location = new Point(120, 225);
            chBucles.Name = "chBucles";
            chBucles.Size = new Size(60, 19);
            chBucles.TabIndex = 3;
            chBucles.Text = "Bucles";
            chBucles.UseVisualStyleBackColor = true;
            // 
            // chClases
            // 
            chClases.AutoSize = true;
            chClases.Location = new Point(120, 189);
            chClases.Name = "chClases";
            chClases.Size = new Size(59, 19);
            chClases.TabIndex = 4;
            chClases.Text = "Clases";
            chClases.UseVisualStyleBackColor = true;
            // 
            // chHerencia
            // 
            chHerencia.AutoSize = true;
            chHerencia.Location = new Point(120, 148);
            chHerencia.Name = "chHerencia";
            chHerencia.Size = new Size(73, 19);
            chHerencia.TabIndex = 5;
            chHerencia.Text = "Herencia";
            chHerencia.UseVisualStyleBackColor = true;
            // 
            // btnComprobar
            // 
            btnComprobar.Location = new Point(143, 343);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(157, 23);
            btnComprobar.TabIndex = 6;
            btnComprobar.Text = "Comprobar respuestas";
            btnComprobar.UseVisualStyleBackColor = true;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(btnComprobar);
            Controls.Add(chHerencia);
            Controls.Add(chClases);
            Controls.Add(chBucles);
            Controls.Add(chAtributos);
            Controls.Add(chPolimorfismo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chPolimorfismo;
        private CheckBox chAtributos;
        private CheckBox chBucles;
        private CheckBox chClases;
        private CheckBox chHerencia;
        private Button btnComprobar;
    }
}
