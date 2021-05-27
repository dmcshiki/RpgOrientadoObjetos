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
using System.Media;
namespace RPGPOO
{
    public partial class EscolhaDeClasse : Form
    {

        public EscolhaDeClasse()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuerreiro_Click(object sender, EventArgs e)
        {
            CriacaoDePersonagem criacaoDePersonagem = new CriacaoDePersonagem("Guerreiro");
            criacaoDePersonagem.Show();
            this.Hide();
        }

        private void BtnArqueiro_Click(object sender, EventArgs e)
        {

            CriacaoDePersonagem criacaoDePersonagem = new CriacaoDePersonagem("Arqueiro");
            criacaoDePersonagem.Show();
            this.Hide();
        }

        private void btnMago_Click(object sender, EventArgs e)
        {
            CriacaoDePersonagem criacaoDePersonagem = new CriacaoDePersonagem("Mago");
            criacaoDePersonagem.Show();
            this.Hide();
        }
    }
}
