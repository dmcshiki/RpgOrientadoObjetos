
namespace RPGPOO
{
    partial class telaBatalha
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
            this.imgProtagonista = new System.Windows.Forms.PictureBox();
            this.imgVilao = new System.Windows.Forms.PictureBox();
            this.HPMonster = new System.Windows.Forms.ProgressBar();
            this.HPHeroi = new System.Windows.Forms.ProgressBar();
            this.lblVidaMonstro = new System.Windows.Forms.Label();
            this.lblVidaHeroi = new System.Windows.Forms.Label();
            this.btnEspecial = new System.Windows.Forms.Button();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.btnCura = new System.Windows.Forms.Button();
            this.lblNomeMonstro = new System.Windows.Forms.Label();
            this.lblNomeHeroi = new System.Windows.Forms.Label();
            this.MPHeroi = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.imgProtagonista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVilao)).BeginInit();
            this.SuspendLayout();
            // 
            // imgProtagonista
            // 
            this.imgProtagonista.BackColor = System.Drawing.Color.Transparent;
            this.imgProtagonista.BackgroundImage = global::RPGPOO.Properties.Resources.guereiro;
            this.imgProtagonista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgProtagonista.Location = new System.Drawing.Point(656, 111);
            this.imgProtagonista.Name = "imgProtagonista";
            this.imgProtagonista.Size = new System.Drawing.Size(271, 257);
            this.imgProtagonista.TabIndex = 0;
            this.imgProtagonista.TabStop = false;
            this.imgProtagonista.Click += new System.EventHandler(this.imgProtagonista_Click);
            // 
            // imgVilao
            // 
            this.imgVilao.BackColor = System.Drawing.Color.Transparent;
            this.imgVilao.BackgroundImage = global::RPGPOO.Properties.Resources.goblin;
            this.imgVilao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVilao.Location = new System.Drawing.Point(21, 74);
            this.imgVilao.Name = "imgVilao";
            this.imgVilao.Size = new System.Drawing.Size(271, 257);
            this.imgVilao.TabIndex = 1;
            this.imgVilao.TabStop = false;
            this.imgVilao.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HPMonster
            // 
            this.HPMonster.ForeColor = System.Drawing.Color.Red;
            this.HPMonster.Location = new System.Drawing.Point(21, 41);
            this.HPMonster.Maximum = 25000;
            this.HPMonster.Name = "HPMonster";
            this.HPMonster.Size = new System.Drawing.Size(271, 27);
            this.HPMonster.TabIndex = 2;
            // 
            // HPHeroi
            // 
            this.HPHeroi.ForeColor = System.Drawing.Color.Red;
            this.HPHeroi.Location = new System.Drawing.Point(656, 41);
            this.HPHeroi.Maximum = 25000;
            this.HPHeroi.Name = "HPHeroi";
            this.HPHeroi.Size = new System.Drawing.Size(271, 27);
            this.HPHeroi.TabIndex = 3;
            this.HPHeroi.Click += new System.EventHandler(this.HPHeroi_Click);
            // 
            // lblVidaMonstro
            // 
            this.lblVidaMonstro.AutoSize = true;
            this.lblVidaMonstro.BackColor = System.Drawing.Color.Transparent;
            this.lblVidaMonstro.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaMonstro.ForeColor = System.Drawing.Color.Crimson;
            this.lblVidaMonstro.Location = new System.Drawing.Point(214, 19);
            this.lblVidaMonstro.Name = "lblVidaMonstro";
            this.lblVidaMonstro.Size = new System.Drawing.Size(43, 19);
            this.lblVidaMonstro.TabIndex = 4;
            this.lblVidaMonstro.Text = "Vida";
            // 
            // lblVidaHeroi
            // 
            this.lblVidaHeroi.AutoSize = true;
            this.lblVidaHeroi.BackColor = System.Drawing.Color.Transparent;
            this.lblVidaHeroi.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaHeroi.ForeColor = System.Drawing.Color.Crimson;
            this.lblVidaHeroi.Location = new System.Drawing.Point(860, 19);
            this.lblVidaHeroi.Name = "lblVidaHeroi";
            this.lblVidaHeroi.Size = new System.Drawing.Size(43, 19);
            this.lblVidaHeroi.TabIndex = 5;
            this.lblVidaHeroi.Text = "Vida";
            this.lblVidaHeroi.Click += new System.EventHandler(this.lblVidaHeroi_Click);
            // 
            // btnEspecial
            // 
            this.btnEspecial.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecial.Location = new System.Drawing.Point(820, 374);
            this.btnEspecial.Name = "btnEspecial";
            this.btnEspecial.Size = new System.Drawing.Size(120, 68);
            this.btnEspecial.TabIndex = 6;
            this.btnEspecial.Text = "Poder Especial";
            this.btnEspecial.UseVisualStyleBackColor = true;
            this.btnEspecial.Click += new System.EventHandler(this.btnEspecial_Click);
            // 
            // btnAtaque
            // 
            this.btnAtaque.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque.Location = new System.Drawing.Point(656, 374);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(132, 68);
            this.btnAtaque.TabIndex = 7;
            this.btnAtaque.Text = "Atacar";
            this.btnAtaque.UseVisualStyleBackColor = true;
            this.btnAtaque.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCura
            // 
            this.btnCura.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCura.Location = new System.Drawing.Point(737, 459);
            this.btnCura.Name = "btnCura";
            this.btnCura.Size = new System.Drawing.Size(120, 60);
            this.btnCura.TabIndex = 8;
            this.btnCura.Text = "Curar";
            this.btnCura.UseVisualStyleBackColor = true;
            this.btnCura.Click += new System.EventHandler(this.btnCura_Click);
            // 
            // lblNomeMonstro
            // 
            this.lblNomeMonstro.AutoSize = true;
            this.lblNomeMonstro.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeMonstro.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMonstro.ForeColor = System.Drawing.Color.Lime;
            this.lblNomeMonstro.Location = new System.Drawing.Point(17, 15);
            this.lblNomeMonstro.Name = "lblNomeMonstro";
            this.lblNomeMonstro.Size = new System.Drawing.Size(68, 23);
            this.lblNomeMonstro.TabIndex = 9;
            this.lblNomeMonstro.Text = "Goblin";
            // 
            // lblNomeHeroi
            // 
            this.lblNomeHeroi.AutoSize = true;
            this.lblNomeHeroi.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeHeroi.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeHeroi.ForeColor = System.Drawing.Color.Lime;
            this.lblNomeHeroi.Location = new System.Drawing.Point(652, 15);
            this.lblNomeHeroi.Name = "lblNomeHeroi";
            this.lblNomeHeroi.Size = new System.Drawing.Size(104, 23);
            this.lblNomeHeroi.TabIndex = 10;
            this.lblNomeHeroi.Text = "nomeHeroi";
            this.lblNomeHeroi.Click += new System.EventHandler(this.label2_Click);
            // 
            // MPHeroi
            // 
            this.MPHeroi.ForeColor = System.Drawing.Color.Red;
            this.MPHeroi.Location = new System.Drawing.Point(656, 78);
            this.MPHeroi.Maximum = 25000;
            this.MPHeroi.Name = "MPHeroi";
            this.MPHeroi.Size = new System.Drawing.Size(271, 27);
            this.MPHeroi.TabIndex = 12;
            this.MPHeroi.Click += new System.EventHandler(this.MPHeroi_Click);
            // 
            // telaBatalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPGPOO.Properties.Resources.rpgfundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 534);
            this.Controls.Add(this.MPHeroi);
            this.Controls.Add(this.lblNomeHeroi);
            this.Controls.Add(this.lblNomeMonstro);
            this.Controls.Add(this.btnCura);
            this.Controls.Add(this.btnAtaque);
            this.Controls.Add(this.btnEspecial);
            this.Controls.Add(this.lblVidaHeroi);
            this.Controls.Add(this.lblVidaMonstro);
            this.Controls.Add(this.HPHeroi);
            this.Controls.Add(this.HPMonster);
            this.Controls.Add(this.imgVilao);
            this.Controls.Add(this.imgProtagonista);
            this.Name = "telaBatalha";
            this.Text = "telaBatalha";
            ((System.ComponentModel.ISupportInitialize)(this.imgProtagonista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVilao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgProtagonista;
        private System.Windows.Forms.PictureBox imgVilao;
        private System.Windows.Forms.ProgressBar HPMonster;
        private System.Windows.Forms.ProgressBar HPHeroi;
        private System.Windows.Forms.Label lblVidaMonstro;
        private System.Windows.Forms.Label lblVidaHeroi;
        private System.Windows.Forms.Button btnEspecial;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.Button btnCura;
        private System.Windows.Forms.Label lblNomeMonstro;
        private System.Windows.Forms.Label lblNomeHeroi;
        private System.Windows.Forms.ProgressBar MPHeroi;
    }
}