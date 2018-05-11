namespace ExemploWFA
{
    partial class Exemplo04
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
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbGostaDeJogo = new System.Windows.Forms.GroupBox();
            this.gbNomeDoJogo = new System.Windows.Forms.GroupBox();
            this.gbGostaDeJogo.SuspendLayout();
            this.gbNomeDoJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(0, 22);
            this.rbSim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(52, 20);
            this.rbSim.TabIndex = 0;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Checked = true;
            this.rbNao.Location = new System.Drawing.Point(0, 64);
            this.rbNao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(55, 20);
            this.rbNao.TabIndex = 1;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 22);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(112, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Path of Exile";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 73);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(207, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Pro Evolution Soccer 2018";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gosta de Jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Jogo";
            // 
            // gbGostaDeJogo
            // 
            this.gbGostaDeJogo.Controls.Add(this.rbSim);
            this.gbGostaDeJogo.Controls.Add(this.rbNao);
            this.gbGostaDeJogo.Location = new System.Drawing.Point(58, 58);
            this.gbGostaDeJogo.Name = "gbGostaDeJogo";
            this.gbGostaDeJogo.Size = new System.Drawing.Size(200, 100);
            this.gbGostaDeJogo.TabIndex = 6;
            this.gbGostaDeJogo.TabStop = false;
            // 
            // gbNomeDoJogo
            // 
            this.gbNomeDoJogo.Controls.Add(this.radioButton4);
            this.gbNomeDoJogo.Controls.Add(this.radioButton3);
            this.gbNomeDoJogo.Location = new System.Drawing.Point(277, 58);
            this.gbNomeDoJogo.Name = "gbNomeDoJogo";
            this.gbNomeDoJogo.Size = new System.Drawing.Size(224, 100);
            this.gbNomeDoJogo.TabIndex = 7;
            this.gbNomeDoJogo.TabStop = false;
            // 
            // Exemplo04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1308, 798);
            this.Controls.Add(this.gbNomeDoJogo);
            this.Controls.Add(this.gbGostaDeJogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Exemplo04";
            this.Text = "Exemplo04";
            this.gbGostaDeJogo.ResumeLayout(false);
            this.gbGostaDeJogo.PerformLayout();
            this.gbNomeDoJogo.ResumeLayout(false);
            this.gbNomeDoJogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbGostaDeJogo;
        private System.Windows.Forms.GroupBox gbNomeDoJogo;
    }
}