
namespace RPGPOO
{
    partial class Cidade
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
            this.imgHeroi = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lstAtributos = new System.Windows.Forms.ListBox();
            this.btnHPPotion = new System.Windows.Forms.Button();
            this.btnMPPot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeroi)).BeginInit();
            this.SuspendLayout();
            // 
            // imgHeroi
            // 
            this.imgHeroi.BackColor = System.Drawing.Color.Transparent;
            this.imgHeroi.BackgroundImage = global::RPGPOO.Properties.Resources.guereiro;
            this.imgHeroi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHeroi.Location = new System.Drawing.Point(385, 250);
            this.imgHeroi.Name = "imgHeroi";
            this.imgHeroi.Size = new System.Drawing.Size(186, 188);
            this.imgHeroi.TabIndex = 1;
            this.imgHeroi.TabStop = false;
            this.imgHeroi.Click += new System.EventHandler(this.imgHeroi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(180, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enfrentar Monstro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(12, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 83);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ir para o mercado";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Bauhaus 93", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(4, 20);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(157, 43);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "CIDADE";
            // 
            // lstAtributos
            // 
            this.lstAtributos.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAtributos.FormattingEnabled = true;
            this.lstAtributos.ItemHeight = 23;
            this.lstAtributos.Location = new System.Drawing.Point(587, 2);
            this.lstAtributos.Name = "lstAtributos";
            this.lstAtributos.Size = new System.Drawing.Size(211, 418);
            this.lstAtributos.TabIndex = 5;
            this.lstAtributos.SelectedIndexChanged += new System.EventHandler(this.lstAtributos_SelectedIndexChanged);
            // 
            // btnHPPotion
            // 
            this.btnHPPotion.BackColor = System.Drawing.Color.DimGray;
            this.btnHPPotion.BackgroundImage = global::RPGPOO.Properties.Resources.hppotion;
            this.btnHPPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHPPotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHPPotion.ForeColor = System.Drawing.Color.Black;
            this.btnHPPotion.Location = new System.Drawing.Point(12, 268);
            this.btnHPPotion.Name = "btnHPPotion";
            this.btnHPPotion.Size = new System.Drawing.Size(88, 72);
            this.btnHPPotion.TabIndex = 6;
            this.btnHPPotion.UseVisualStyleBackColor = false;
            this.btnHPPotion.Click += new System.EventHandler(this.btnHPPotion_Click);
            // 
            // btnMPPot
            // 
            this.btnMPPot.BackColor = System.Drawing.Color.DimGray;
            this.btnMPPot.BackgroundImage = global::RPGPOO.Properties.Resources.mppotion;
            this.btnMPPot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMPPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPPot.ForeColor = System.Drawing.Color.Black;
            this.btnMPPot.Location = new System.Drawing.Point(121, 268);
            this.btnMPPot.Name = "btnMPPot";
            this.btnMPPot.Size = new System.Drawing.Size(88, 72);
            this.btnMPPot.TabIndex = 7;
            this.btnMPPot.UseVisualStyleBackColor = false;
            this.btnMPPot.Click += new System.EventHandler(this.btnMPPot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usar Poção: ";
            // 
            // Cidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGPOO.Properties.Resources.cidadefundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMPPot);
            this.Controls.Add(this.btnHPPotion);
            this.Controls.Add(this.lstAtributos);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgHeroi);
            this.Name = "Cidade";
            this.Text = "Cidade";
            ((System.ComponentModel.ISupportInitialize)(this.imgHeroi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgHeroi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ListBox lstAtributos;
        private System.Windows.Forms.Button btnHPPotion;
        private System.Windows.Forms.Button btnMPPot;
        private System.Windows.Forms.Label label1;
    }
}