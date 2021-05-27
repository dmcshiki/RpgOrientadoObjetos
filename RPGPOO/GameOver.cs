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
namespace RPGPOO
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            tocarMusica();
        }
        public void tocarMusica()
        {
            SoundPlayer splayer = new SoundPlayer(@"..\..\Imagens\gameoversong.wav");
            splayer.Play();
        }
        private void fimDeJogo_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
