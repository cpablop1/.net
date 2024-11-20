namespace OrderArray
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
            btnOrdenar = new Button();
            liTable1 = new ListBox();
            label1 = new Label();
            liTable2 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(292, 32);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 0;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // liTable1
            // 
            liTable1.FormattingEnabled = true;
            liTable1.ItemHeight = 15;
            liTable1.Location = new Point(57, 112);
            liTable1.Name = "liTable1";
            liTable1.Size = new Size(166, 304);
            liTable1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 94);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Array desordenada";
            // 
            // liTable2
            // 
            liTable2.FormattingEnabled = true;
            liTable2.ItemHeight = 15;
            liTable2.Location = new Point(402, 113);
            liTable2.Name = "liTable2";
            liTable2.Size = new Size(181, 304);
            liTable2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 94);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Array ordenada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(liTable2);
            Controls.Add(label1);
            Controls.Add(liTable1);
            Controls.Add(btnOrdenar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrdenar;
        private ListBox liTable1;
        private Label label1;
        private ListBox liTable2;
        private Label label2;
    }
}
