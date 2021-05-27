using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGPOO.Classes.RPG;
using RPGPOO.Classes.Mobs;

namespace RPGPOO.Classes.Herois
{
    class Arqueiro : Heroi
    {
        public Arqueiro(string Nome, int Idade, int Level, int Forca, int Defesa, int Agilidade, int Sorte, int Vida, int Mana)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Level = Level;
            this.status = new Status(Forca, Defesa, Agilidade, Sorte, Vida, Mana);
            this.classe = "Arqueiro";
            this.mochila = new Mochila(0, 0, 0, 0);
        }

        public override void AtaqueEspecial(Monster monstro)
        {
            if (vivo() == true)
            {
                Random random = new Random();
                float sorte = random.Next(0, this.status.Sorte);
                int ataque = (int)((this.status.Forca + (this.status.Agilidade+5)) * (1 + (sorte / 100)));
                this.status.Mana -= 25;
                monstro.RecebeAtaque(ataque);
            }
            else
            {
                return;
            }
        }
        public override void buffarma()
        {
            this.status.Forca += (this.mochila.arma * 3);
            this.status.Agilidade += (this.mochila.arma * 5);
        }
    }
}
