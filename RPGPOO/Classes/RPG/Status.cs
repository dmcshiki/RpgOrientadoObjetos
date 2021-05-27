using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO.Classes.RPG
{
    public class Status
    {
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Agilidade { get; set; }
        public int Sorte { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }

        public Status(int Forca, int Defesa, int Agilidade, int Sorte, int Vida, int Mana)
        {
            this.Forca = Forca;
            this.Defesa = Defesa;
            this.Agilidade = Agilidade;
            this.Sorte = Sorte;
            this.Vida = Vida;
            this.Mana = Mana;
        }

    }
}
