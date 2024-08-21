using System;
using System.Windows.Forms;
using X_O_Game;
using MathGame;
namespace GameList
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private Form frm = new FrmX_O_Game();
        private Form frm2=new FrmStonePapperScissors();
        private Form frm3 = new FrmStartGame();
        private void xOGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frm.Show();
        }

        private void Lb_XO_Click(object sender, EventArgs e)
        {
            
            frm.Show();
        }

        private void stonePapperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm2.Show();
        }

        private void Lb_StonePapperScissors_Click(object sender, EventArgs e)
        {
            
            frm2.Show();
        }

        private void mathGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3.Show();
        }

        private void Lb_MathGame_Click(object sender, EventArgs e)
        {
            frm3.Show();
        }
    }
}
