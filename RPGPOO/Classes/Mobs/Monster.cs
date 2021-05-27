using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGPOO.Classes.RPG;
using RPGPOO.Classes.Herois;

namespace RPGPOO.Classes.Mobs
{
    public class Monster
    {
        public int Level { get; set; }
        public Status status { get; set; }
        public string tipo { get; set; }

        public bool vivo()
        {
           if(this.status.Vida > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public int Defesa()
        {
            if(vivo() == true) { 
            Random random = new Random();
            float sorte = random.Next(0, this.status.Sorte);
            return (int)((this.status.Defesa + this.status.Agilidade) * (1 + (sorte / 100)));
            }
            else
            {
                return 0;
            }
        }
        public void Ataque(Heroi heroi)
        {
            if(vivo() == true) { 
            Random random = new Random();
            float sorte = random.Next(0, this.status.Sorte);
            int ataque = (int)((this.status.Forca + this.status.Agilidade) * (1 + (sorte / 100)));
            heroi.RecebeAtaque(ataque);
            } else
            {
                return;
            }
        }
        public void RecebeAtaque(int Dano)
        {
            if (vivo() == true)
            {
                Dano = Dano - this.Defesa();
                if (Dano > 0)
                {
                    this.status.Vida -= Dano;
                    return;
                }
            }
            else
            {
                return;
            }
        }

    }
}
