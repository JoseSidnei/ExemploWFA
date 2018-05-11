namespace ExemploWFA
{
    partial class Exemplo05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbComprou = new System.Windows.Forms.CheckBox();
            this.cbLeu = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbComprou
            // 
            this.cbComprou.AutoSize = true;
            this.cbComprou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComprou.Location = new System.Drawing.Point(38, 79);
            this.cbComprou.Name = "cbComprou";
            this.cbComprou.Size = new System.Drawing.Size(237, 24);
            this.cbComprou.TabIndex = 0;
            this.cbComprou.Text = "Você comprou o WinRar ?";
            this.cbComprou.UseVisualStyleBackColor = true;
            // 
            // cbLeu
            // 
            this.cbLeu.AutoSize = true;
            this.cbLeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLeu.Location = new System.Drawing.Point(38, 49);
            this.cbLeu.Name = "cbLeu";
            this.cbLeu.Size = new System.Drawing.Size(240, 24);
            this.cbLeu.TabIndex = 1;
            this.cbLeu.Text = "Comnfirmar que leu tudo ?";
            this.cbLeu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exemplo05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbLeu);
            this.Controls.Add(this.cbComprou);
            this.Name = "Exemplo05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Exemplo05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbComprou;
        private System.Windows.Forms.CheckBox cbLeu;
        private System.Windows.Forms.Button button1;
    }
}