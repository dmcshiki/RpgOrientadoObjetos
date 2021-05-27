using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using RPGPOO.Classes.Herois;
using RPGPOO.Classes.Mobs;
using RPGPOO.Classes.RPG;

namespace RPGPOO
{
    public partial class telaBatalha : Form
    {
        public Heroi protagonista { get; set; }
        public Monster vilao { get; set; }
        public telaBatalha(Heroi protagonista, Monster vilao)
        {
            InitializeComponent();
            this.protagonista = protagonista;
            this.vilao = vilao;
            if (protagonista.classe == "Arqueiro")
            {
                imgProtagonista.BackgroundImage = new Bitmap(@"..\..\Imagens\arqueiro.png");
                imgProtagonista.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (protagonista.classe == "Mago")
            {
                imgProtagonista.BackgroundImage = new Bitmap(@"..\..\Imagens\mago.png");
                imgProtagonista.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (Cidade.monstroaleatorio == 2)
            {
                imgVilao.BackgroundImage = new Bitmap(@"..\..\Imagens\zumbi.png");
                imgVilao.SizeMode = PictureBoxSizeMode.StretchImage;
                lblNomeMonstro.Text = "Zumbi";
            }
            else if (Cidade.monstroaleatorio == 3)
            {
                lblNomeMonstro.Text = "Dragão";
                imgVilao.BackgroundImage = new Bitmap(@"..\..\Imagens\dragao.png");
                imgVilao.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if(protagonista.classe != "Mago")
            {
                btnCura.Visible = false;
            }
            HPHeroi.Maximum = protagonista.status.Vida;
            HPHeroi.Value = protagonista.status.Vida;
            MPHeroi.Maximum = protagonista.status.Mana;
            MPHeroi.Value = protagonista.status.Mana;
            HPMonster.Maximum = vilao.status.Vida;
            HPMonster.Value = vilao.status.Vida;
            lblNomeHeroi.Text = protagonista.Nome;
            lblVidaHeroi.Text = protagonista.status.Vida.ToString();
            lblVidaMonstro.Text = vilao.status.Vida.ToString();
            tocarMusica();
        }
        public void tocarMusica()
        {
            SoundPlayer splayer = new SoundPlayer(@"..\..\Imagens\batalhasong.wav");
            splayer.Play();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void HPHeroi_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void turno()
        {
            vilao.Ataque(protagonista);
            lblVidaMonstro.Text = vilao.status.Vida.ToString();
            lblVidaHeroi.Text = protagonista.status.Vida.ToString();
            if (protagonista.status.Mana > 0)
            {
                MPHeroi.Value = protagonista.status.Mana;
            }
            if (protagonista.status.Vida > 0)
            {
                if(HPHeroi.Value > HPHeroi.Maximum) { 
                    HPHeroi.Maximum = protagonista.status.Vida;
                    HPHeroi.Value = protagonista.status.Vida;
                }
                HPHeroi.Value = protagonista.status.Vida;
            }
            else if (protagonista.status.Vida <= 0)
            {
                MessageBox.Show("Você Morreu!");
                GameOver gameover = new GameOver();
                gameover.Show();
                this.Hide();
            }
            if (vilao.status.Vida > 0)
            {
                HPMonster.Value = vilao.status.Vida;
            }
            else if (vilao.status.Vida <= 0)
            {
                MessageBox.Show("Você ganhou a batalha!");
                if(vilao.tipo == "Goblin") { 
                    MessageBox.Show("Você ganhou "+ 25 + " moedas de ouro" );
                    protagonista.mochila.Dinheiro += 25;
                }
                if (vilao.tipo == "Zumbi")
                {
                    MessageBox.Show("Você ganhou " + 35 + " moedas de ouro");
                    protagonista.mochila.Dinheiro += 35;
                }
                if (vilao.tipo == "Dragao")
                {
                    MessageBox.Show("Você ganhou " + 50 + " moedas de ouro");
                    protagonista.mochila.Dinheiro += 55;
                }
                Cidade cidade = new Cidade(protagonista);
                cidade.Show();
                this.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            protagonista.Ataque(vilao);
            turno();
        }
        private void btnEspecial_Click(object sender, EventArgs e)
        {
            if(protagonista.status.Mana >= 25) { 
                protagonista.AtaqueEspecial(vilao);
                turno();
            }
            else
            {
                MessageBox.Show("Você não tem mana suficiente!");
            }

        }

        private void MPHeroi_Click(object sender, EventArgs e)
        {

        }

        private void lblVidaHeroi_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCura_Click(object sender, EventArgs e)
        {
            if(protagonista.status.Mana >= 25) { 
            protagonista.Curar();
            turno();
            }
            else
            {
                MessageBox.Show("Você não tem mana suficiente!");
            }
        }

        private void imgProtagonista_Click(object sender, EventArgs e)
        {

        }
    }
}
