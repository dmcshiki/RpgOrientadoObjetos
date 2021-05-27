
namespace RPGPOO
{
    partial class Mercado
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnArma = new System.Windows.Forms.Button();
            this.btnMPPotion = new System.Windows.Forms.Button();
            this.btnHPPotion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMoedas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BackgroundImage = global::RPGPOO.Properties.Resources.mercado;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(433, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo Ao Mercado da Cidade!\r\nGostaria de comprar uma arma nova ou poções?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(7, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 408);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnArma
            // 
            this.btnArma.BackColor = System.Drawing.Color.DimGray;
            this.btnArma.BackgroundImage = global::RPGPOO.Properties.Resources.espada;
            this.btnArma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArma.Location = new System.Drawing.Point(12, 316);
            this.btnArma.Name = "btnArma";
            this.btnArma.Size = new System.Drawing.Size(114, 119);
            this.btnArma.TabIndex = 4;
            this.btnArma.UseVisualStyleBackColor = false;
            this.btnArma.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMPPotion
            // 
            this.btnMPPotion.BackColor = System.Drawing.Color.DimGray;
            this.btnMPPotion.BackgroundImage = global::RPGPOO.Properties.Resources.mppotion;
            this.btnMPPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMPPotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMPPotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPPotion.Location = new System.Drawing.Point(12, 182);
            this.btnMPPotion.Name = "btnMPPotion";
            this.btnMPPotion.Size = new System.Drawing.Size(114, 119);
            this.btnMPPotion.TabIndex = 5;
            this.btnMPPotion.UseVisualStyleBackColor = false;
            this.btnMPPotion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHPPotion
            // 
            this.btnHPPotion.BackColor = System.Drawing.Color.DimGray;
            this.btnHPPotion.BackgroundImage = global::RPGPOO.Properties.Resources.hppotion;
            this.btnHPPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHPPotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHPPotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHPPotion.Location = new System.Drawing.Point(12, 57);
            this.btnHPPotion.Name = "btnHPPotion";
            this.btnHPPotion.Size = new System.Drawing.Size(114, 119);
            this.btnHPPotion.TabIndex = 6;
            this.btnHPPotion.UseVisualStyleBackColor = false;
            this.btnHPPotion.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Poção de HP: 20 Moedas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arma Nova: 50 Moedas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Poção de MP:15 Moedas";
            // 
            // lblMoedas
            // 
            this.lblMoedas.AutoSize = true;
            this.lblMoedas.BackColor = System.Drawing.Color.Transparent;
            this.lblMoedas.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoedas.ForeColor = System.Drawing.Color.Yellow;
            this.lblMoedas.Location = new System.Drawing.Point(7, 9);
            this.lblMoedas.Name = "lblMoedas";
            this.lblMoedas.Size = new System.Drawing.Size(109, 28);
            this.lblMoedas.TabIndex = 10;
            this.lblMoedas.Text = "Moedas: ";
            this.lblMoedas.Click += new System.EventHandler(this.lblMoedas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(587, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 83);
            this.button1.TabIndex = 11;
            this.button1.Text = ">>>>> Retornar à cidade";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Mercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGPOO.Properties.Resources.mercadofundo_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMoedas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHPPotion);
            this.Controls.Add(this.btnMPPotion);
            this.Controls.Add(this.btnArma);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Mercado";
            this.Text = "Mercado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnArma;
        private System.Windows.Forms.Button btnMPPotion;
        private System.Windows.Forms.Button btnHPPotion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMoedas;
        private System.Windows.Forms.Button button1;
    }
}