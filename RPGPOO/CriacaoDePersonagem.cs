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
    public partial class CriacaoDePersonagem : Form
    {
        public CriacaoDePersonagem(string classe)
        {
            InitializeComponent();
            tocarMusica();
            this.classe = classe;
        }
        public void tocarMusica()
        {
            SoundPlayer splayer = new SoundPlayer(@"..\..\Imagens\criacaopersonagem.wav");
            splayer.Play();
        }
        public string nome = "Heroi";
        public int idade = 20;
        public int forca = 5;
        public int defesa = 5;
        public int agilidade = 5;
        public int sorte = 5;
        public int vida = 5;
        public int mana = 5;
        public int pontos = 5;
        public int level = 1;
        public Heroi protagonista;
        public string classe { get; set; }
        public void CriaChar()
        {
            if(classe == "Guerreiro")
            {
               protagonista = new Guerreiro(nome, idade, level, (forca + 15), (defesa + 10), agilidade, sorte, (vida + 180), (mana + 100));
            }
            else if(classe == "Arqueiro"){
                 protagonista = new Arqueiro(nome, idade, level, forca, defesa, (agilidade + 15), (sorte + 10), (vida + 200), mana);
            }
            else if(classe == "Mago"){
               protagonista = new Mago(nome, idade, level, (forca + 15), (defesa + 10), agilidade, sorte, (vida + 180), (mana + 100));
            }



        }
        private void CriacaoDePersonagem_Load(object sender, EventArgs e)
        {

        }

        private void txtForca_TextChanged(object sender, EventArgs e)
        {
            if (txtForca.Text == "")
            {
                forca = 0;
            }
            else { 
            forca = int.Parse(txtForca.Text);
            lblPontos.Text = ("Quantidade de pontos restantes: " + (300 - (mana + vida + sorte + agilidade + defesa + forca)));
            }
        }


        private void txtDefesa_TextChanged(object sender, EventArgs e)
        {
            if (txtDefesa.Text == "")
            {
                defesa = 0;
            }
            else { 
            defesa = int.Parse(txtDefesa.Text);
            lblPontos.Text = ("Quantidade de pontos restantes: " + (300 - (mana + vida + sorte + agilidade + defesa + forca)));
            }
        }

        private void txtAgilidade_TextChanged(object sender, EventArgs e)
        {
            if (txtAgilidade.Text == "")
            {
                agilidade = 0;
            } else { 
            agilidade = int.Parse(txtAgilidade.Text);
            lblPontos.Text = ("Quantidade de pontos restantes: " + (300 - (mana + vida + sorte + agilidade + defesa + forca)));
            }
        }
        private void txtSorte_TextChanged(object sender, EventArgs e)
        {
            if (txtSorte.Text == "")
            {
                sorte = 0;
            } else { 
            sorte = int.Parse(txtSorte.Text);
            lblPontos.Text = ("Quantidade de pontos restantes: " + (300 - (mana + vida + sorte + agilidade + defesa + forca)));

            }
        }

        private void txtVida_TextChanged(object sender, EventArgs e)
        {
            if (txtVida.Text == "")
            {
                vida = 0;
            } else { 
            vida = int.Parse(txtVida.Text);
            lblPontos.Text = ("Quantidade de pontos restantes: " + (300 - (mana + vida + sorte + agilidade + defesa + forca)));

            }
        }

        private void txtMana_TextChanged(object sender, EventArgs e)
        {
            if (txtForca.Text == "")
            {
                mana = 0;
            } else { 
            mana = int.Parse(txtMana.Text);
            lblPontos.Text = ("Quantidade de pontos restantes: " + (300 - (mana + vida + sorte + agilidade + defesa + forca)));
            }
        }

        private void btnCriarPersonagem_Click(object sender, EventArgs e)
        {
            pontos = (mana + vida + sorte + agilidade + defesa + forca);
            if(nome == "" || idade == 0 || vida == 0 || mana == 0 || sorte == 0 || agilidade == 0 || defesa == 0 || forca == 0)
            {
                MessageBox.Show("Não é permitido criar personagens com atributo zerado!", "Atributo Zerado!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (pontos == 300)
            {
                    CriaChar();  
                Cidade cidade = new Cidade(protagonista);
                cidade.Show();
                this.Hide();
            }
            else if(pontos < 300)
            {
                MessageBox.Show("Ainda restam pontos para distribuir!", "Atributos insuficientes!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(pontos > 300)
            {
                MessageBox.Show("Pontos insuficientes! Você distribuiu mais pontos do que tinha", "Pontos insuficientes!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtForca_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDefesa_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAgilidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSorte_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtVida_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                nome = "";
            }
            else
            {
                nome = txtNome.Text;
            }
 
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (txtIdade.Text == "")
            {
                idade = 0;
            }
            else
            {
                idade = int.Parse(txtIdade.Text);
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
