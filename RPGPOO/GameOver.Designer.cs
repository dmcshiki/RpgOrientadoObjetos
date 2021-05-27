
namespace RPGPOO
{
    partial class GameOver
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
            this.lblAcabou = new System.Windows.Forms.Label();
            this.fimDeJogo = new System.Windows.Forms.Button();
            this.Morto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Morto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAcabou
            // 
            this.lblAcabou.AutoSize = true;
            this.lblAcabou.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcabou.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAcabou.Location = new System.Drawing.Point(175, 9);
            this.lblAcabou.Name = "lblAcabou";
            this.lblAcabou.Size = new System.Drawing.Size(537, 46);
            this.lblAcabou.TabIndex = 0;
            this.lblAcabou.Text = "Que pena!\r\nParece que o nosso grande Herói não está mais entre nós =(\r\n";
            // 
            // fimDeJogo
            // 
            this.fimDeJogo.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fimDeJogo.Location = new System.Drawing.Point(333, 93);
            this.fimDeJogo.Name = "fimDeJogo";
            this.fimDeJogo.Size = new System.Drawing.Size(182, 100);
            this.fimDeJogo.TabIndex = 1;
            this.fimDeJogo.Text = "Game Over";
            this.fimDeJogo.UseVisualStyleBackColor = true;
            this.fimDeJogo.Click += new System.EventHandler(this.fimDeJogo_Click);
            // 
            // Morto
            // 
            this.Morto.BackColor = System.Drawing.Color.Transparent;
            this.Morto.BackgroundImage = global::RPGPOO.Properties.Resources.morto;
            this.Morto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Morto.Location = new System.Drawing.Point(179, 204);
            this.Morto.Name = "Morto";
            this.Morto.Size = new System.Drawing.Size(482, 307);
            this.Morto.TabIndex = 2;
            this.Morto.TabStop = false;
            this.Morto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(866, 523);
            this.Controls.Add(this.Morto);
            this.Controls.Add(this.fimDeJogo);
            this.Controls.Add(this.lblAcabou);
            this.DoubleBuffered = true;
            this.Name = "GameOver";
            this.Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)(this.Morto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcabou;
        private System.Windows.Forms.Button fimDeJogo;
        private System.Windows.Forms.PictureBox Morto;
    }
}