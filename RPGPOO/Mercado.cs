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
using RPGPOO.Classes.Mobs;
using RPGPOO.Classes.RPG;
using RPGPOO.Classes;
using RPGPOO.Classes.Herois;

namespace RPGPOO
{
    public partial class Mercado : Form
    {
        Heroi protagonista;
        public Mercado(Heroi protagonista)
        {
            InitializeComponent();
            this.protagonista = protagonista;
            lblMoedas.Text = ("Moedas: " + protagonista.mochila.Dinheiro.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (protagonista.mochila.Dinheiro >= 20)
            {
                MessageBox.Show("Poção de HP comprada!");
                protagonista.mochila.potionshp += 1;
                protagonista.mochila.Dinheiro -= 20;
                lblMoedas.Text = ("Moedas: " + protagonista.mochila.Dinheiro.ToString());
            }
            else
            {
                MessageBox.Show("Você não tem dinheiro suficiente! Retorne depois de derrotar alguns monstros");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (protagonista.mochila.Dinheiro >= 20)
            {
                MessageBox.Show("Poção de MP comprada!");
                protagonista.mochila.potionsmp += 1;
                protagonista.mochila.Dinheiro -= 20;
                lblMoedas.Text = ("Moedas: " + protagonista.mochila.Dinheiro.ToString());
            }
            else
            {
                MessageBox.Show("Você não tem dinheiro suficiente! Retorne depois de derrotar alguns monstros");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (protagonista.mochila.Dinheiro >= 50)
            {
                MessageBox.Show("Arma melhorada!");
                protagonista.mochila.arma += 1;
                protagonista.mochila.Dinheiro -= 50;
                protagonista.buffarma();
                lblMoedas.Text = ("Moedas: " + protagonista.mochila.Dinheiro.ToString());
            }
            else
            {
                MessageBox.Show("Você não tem dinheiro suficiente! Retorne depois de derrotar alguns monstros");
            }
        }

        private void lblMoedas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cidade cidade = new Cidade(protagonista);
            cidade.Show();
            this.Hide();
        }
    }
}
