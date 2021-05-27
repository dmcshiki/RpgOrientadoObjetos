using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGPOO.Classes.RPG;

namespace RPGPOO.Classes.Mobs
{
    class Dragao : Monster
    {
        public Dragao(int Level, int Forca, int Defesa, int Agilidade, int Sorte, int Vida, int Mana)
        {
            this.Level = Level;
            this.status = new Status(Forca, Defesa, Agilidade, Sorte, Vida, Mana);
            this.tipo = "Dragao";
        }
    }
}
