using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{

    
    public partial class FrmStartGame : Form
    {
        public FrmStartGame()
        {
            InitializeComponent();
        }

        clsMathGame mathGame = new clsMathGame();
        private void Cb_Diffculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            mathGame.Difficulty=(clsMathGame.enDifficulty)Cb_Diffculty.SelectedIndex;
        }

        private void Cb_Operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            mathGame.Operation=(clsMathGame.enOperation)Cb_Operation.SelectedIndex;
        }

        private void Rd_5_CheckedChanged(object sender, EventArgs e)
        {
            mathGame.NumberofQuetions = 5;
        }

        private void Rd_10_CheckedChanged(object sender, EventArgs e)
        {
            mathGame.NumberofQuetions = 10;
        }

        private void Rd_15_CheckedChanged(object sender, EventArgs e)
        {
            mathGame.NumberofQuetions = 15;
        }

        private void Rd_20_CheckedChanged(object sender, EventArgs e)
        {
            mathGame.NumberofQuetions = 20;
        }

        private void Rd_Yes_CheckedChanged(object sender, EventArgs e)
        {
            mathGame.Timer = true;
        }

        private bool IsChecked()
        {
            if (Cb_Diffculty.SelectedItem != null && Cb_Operation.SelectedItem != null)
            { 
                if(Rd_10.Checked||Rd_5.Checked||Rd_15.Checked||Rd_20.Checked) 
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        private void Btn_StartGame_Click(object sender, EventArgs e)
        {
            if (IsChecked()) 
            { 
                
                FrmMathGame frm= new FrmMathGame(mathGame);
                
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lack of Information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
    }
}
