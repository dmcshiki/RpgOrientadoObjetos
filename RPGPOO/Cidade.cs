using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGPOO.Classes.Herois;
using RPGPOO.Classes.Mobs;
using RPGPOO.Classes.RPG;
using RPGPOO.Classes;
using System.Media;

namespace RPGPOO
{
    public partial class Cidade : Form
    {

        public Heroi protagonista;
        public Monster vilao;
        public Cidade(Heroi protagonista)
        {
            InitializeComponent();
            this.protagonista = protagonista;
            atualizavalores();
            Random random = new Random();
            monstroaleatorio = random.Next(1, 4);
             if(protagonista.classe == "Arqueiro") {
                imgHeroi.BackgroundImage = new Bitmap(@"..\..\Imagens\arqueiro.png");
                imgHeroi.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if(protagonista.classe == "Mago")
            {
                imgHeroi.BackgroundImage = new Bitmap(@"..\..\Imagens\mago.png");
                imgHeroi.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            //tocarMusica();
        }

        public void atualizavalores()
        {
            lstAtributos.Items.Clear();
            lstAtributos.Items.Add("Nome: " + protagonista.Nome);
            lstAtributos.Items.Add("Classe: " + protagonista.classe);
            lstAtributos.Items.Add("Level: " + protagonista.Level);
            lstAtributos.Items.Add("Vida: " + protagonista.status.Vida);
            lstAtributos.Items.Add("Mana: " + protagonista.status.Mana);
            lstAtributos.Items.Add("Agilidade: " + protagonista.status.Agilidade);
            lstAtributos.Items.Add("Defesa: " + protagonista.status.Defesa);
            lstAtributos.Items.Add("Sorte: " + protagonista.status.Sorte);
            lstAtributos.Items.Add("Forca: " + protagonista.status.Forca);
            lstAtributos.Items.Add("Dinheiro: " + protagonista.mochila.Dinheiro);
            lstAtributos.Items.Add("Poções de HP: " + protagonista.mochila.potionshp);
            lstAtributos.Items.Add("Poções de MP: " + protagonista.mochila.potionsmp);
        }
        public void tocarMusica()
        {
            SoundPlayer splayer = new SoundPlayer(@"..\..\Imagens\cidadesong.wav");
            splayer.Play();
        }
        public static int monstroaleatorio;
        private void button1_Click(object sender, EventArgs e)
        {
            if (monstroaleatorio == 1)
            {
                vilao = new Goblin((1 * protagonista.Level),
                    (10 * protagonista.Level), 
                    (10 * protagonista.Level), 
                    (15 * protagonista.Level), 
                    (15 * protagonista.Level), 
                    (100 * protagonista.Level), 
                    (10 * protagonista.Level));
                    
            }
            else if(monstroaleatorio == 2){
                vilao = new Zumbi((1 * protagonista.Level),
                    (20 * protagonista.Level),
                    (20 * protagonista.Level),
                    (15 * protagonista.Level),
                    (10 * protagonista.Level),
                    (150 * protagonista.Level),
                    (15 * protagonista.Level));
            }
            else if(monstroaleatorio == 3) {
                vilao = new Dragao((1 * protagonista.Level),
                    (30 * protagonista.Level),
                    (30 * protagonista.Level),
                    (20 * protagonista.Level),
                    (25 * protagonista.Level),
                    (200 * protagonista.Level),
                    (20 * protagonista.Level));
            }
            telaBatalha batalha = new telaBatalha(protagonista, vilao);
            batalha.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mercado mercado = new Mercado(protagonista);
            mercado.Show();
            this.Hide();
        }

        private void lstAtributos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHPPotion_Click(object sender, EventArgs e)
        {
            if (protagonista.mochila.potionshp > 0)
            {
                protagonista.usapotionhp();
                atualizavalores();
            }
            else
            {
                MessageBox.Show("^Você não tem poções!");
            }
        }

        private void btnMPPot_Click(object sender, EventArgs e)
        {
            if (protagonista.mochila.potionsmp > 0)
            {
                protagonista.usapotionmp();
                atualizavalores();
            }
            else
            {
                MessageBox.Show("Você não tem poções!");
            }
        }

        private void imgHeroi_Click(object sender, EventArgs e)
        {

        }
    }
}
