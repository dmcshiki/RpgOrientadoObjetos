using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO.Classes.Herois
{
    public class Mochila
    {
        public int Dinheiro { get; set; }
        public int potionshp { get; set; }
        public int potionsmp { get; set; }
        public int arma { get; set; }

      public Mochila(int Dinheiro, int potionshp, int potionsmp, int arma)
        {
            this.Dinheiro = Dinheiro;
            this.potionshp = potionshp;
            this.potionsmp = potionsmp;
            this.arma = arma;
        }
    }
}
