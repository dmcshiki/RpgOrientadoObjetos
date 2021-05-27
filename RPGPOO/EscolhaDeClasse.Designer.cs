
namespace RPGPOO
{
    partial class EscolhaDeClasse
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuerreiro = new System.Windows.Forms.Button();
            this.BtnArqueiro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMago = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuerreiro
            // 
            this.btnGuerreiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuerreiro.BackgroundImage = global::RPGPOO.Properties.Resources.guereiro;
            this.btnGuerreiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuerreiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuerreiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuerreiro.Location = new System.Drawing.Point(172, 131);
            this.btnGuerreiro.Name = "btnGuerreiro";
            this.btnGuerreiro.Size = new System.Drawing.Size(150, 162);
            this.btnGuerreiro.TabIndex = 5;
            this.btnGuerreiro.UseVisualStyleBackColor = false;
            this.btnGuerreiro.Click += new System.EventHandler(this.btnGuerreiro_Click);
            // 
            // BtnArqueiro
            // 
            this.BtnArqueiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnArqueiro.BackgroundImage = global::RPGPOO.Properties.Resources.arqueiro;
            this.BtnArqueiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnArqueiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArqueiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArqueiro.Location = new System.Drawing.Point(328, 131);
            this.BtnArqueiro.Name = "BtnArqueiro";
            this.BtnArqueiro.Size = new System.Drawing.Size(150, 162);
            this.BtnArqueiro.TabIndex = 7;
            this.BtnArqueiro.UseVisualStyleBackColor = false;
            this.BtnArqueiro.Click += new System.EventHandler(this.BtnArqueiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(214, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha sua Classe";
            // 
            // btnMago
            // 
            this.btnMago.BackColor = System.Drawing.Color.BlueViolet;
            this.btnMago.BackgroundImage = global::RPGPOO.Properties.Resources.mago;
            this.btnMago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMago.Location = new System.Drawing.Point(484, 131);
            this.btnMago.Name = "btnMago";
            this.btnMago.Size = new System.Drawing.Size(150, 162);
            this.btnMago.TabIndex = 9;
            this.btnMago.UseVisualStyleBackColor = false;
            this.btnMago.Click += new System.EventHandler(this.btnMago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(365, -104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Escolha sua Classe";
            // 
            // EscolhaDeClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGPOO.Properties.Resources.rpgfundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnArqueiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuerreiro);
            this.Name = "EscolhaDeClasse";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuerreiro;
        private System.Windows.Forms.Button BtnArqueiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMago;
        private System.Windows.Forms.Label label2;
    }
}

