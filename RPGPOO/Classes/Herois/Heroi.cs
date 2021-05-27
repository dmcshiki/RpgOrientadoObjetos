using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGPOO.Classes.RPG;
using RPGPOO.Classes.Mobs;
using RPGPOO.Classes.Herois;

namespace RPGPOO.Classes.Herois
{
    public class Heroi
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Level { get; set; }
        public Status status { get; set; }
        public string classe { get; set; }
        public Mochila mochila { get; set; }
        public bool vivo()
        {
            if (this.status.Vida > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Defesa()
        {
            if (vivo() == true)
            {
                Random random = new Random();
                float sorte = random.Next(0, this.status.Sorte);
                return (int)((this.status.Defesa + this.status.Agilidade) * (1 + (sorte / 100)));
            }
            else
            {
                return 0;
            }
        }
        public void Ataque(Monster monstro)
        {
            if (vivo() == true)
            {
                Random random = new Random();
                float sorte = random.Next(0, this.status.Sorte);
                int ataque = (int)((this.status.Forca + this.status.Agilidade) * (1 + (sorte / 100)));
                monstro.RecebeAtaque(ataque);
            }
            else
            {
                return;
            }
        }
        public virtual void AtaqueEspecial(Monster monstro)
        {
            return;
        }
        public virtual void buffarma()
        {
            return;
        }
        public void usapotionhp()
        {
            if (vivo() == true)
            {
                if(this.mochila.potionshp > 0) { 
                    this.status.Vida += 50;
                    this.mochila.potionshp -= 1;
                }
            }
            else
            {
                return;
            }
        }
        public void usapotionmp()
        {
            if (vivo() == true)
            {
                if (this.mochila.potionsmp > 0)
                {
                    this.status.Vida += 50;
                    this.mochila.potionsmp -= 1;
                }
            }
            else
            {
                return;
            }
        }
        public virtual void Curar()
        {
            return;
        }
            public void RecebeAtaque(int Dano)
        {
            if (vivo() == true)
            {
                Dano = this.Defesa() - Dano;
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
