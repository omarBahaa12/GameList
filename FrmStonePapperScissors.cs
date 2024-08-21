using GameList.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameList
{
    public partial class FrmStonePapperScissors : Form
    {
        enum EnStonePapperScissors :byte
        { 
            Stone=1,Papper=2,Scissors=3
        }
        struct StPlayer
        {
            public EnStonePapperScissors Player;
            public byte Wins;

        }

        struct StComputer
        {
            public EnStonePapperScissors Computer;
            
            public byte Wins;
        }

        struct StRounds
        {
            public StComputer Computer;
            public StPlayer Player;
            public byte NumberRounds;
            public byte Draw;
            public string Winner;
        }

        StRounds Rounds;
        public FrmStonePapperScissors()
        {
            InitializeComponent();
        }

        private void Btn_StartGame_Click(object sender, EventArgs e)
        {
            Pn_Choice.Enabled = true;
            Pn_NumberRounds.Enabled = true;
           
        }

        private void Computer_Choice()
        {
            Random random = new Random();
            Rounds.Computer.Computer = (EnStonePapperScissors)random.Next(1, 3);
        }

        private void Round_Winner()
        {
            switch(Rounds.Player.Player)
            {
                case EnStonePapperScissors.Stone:
                    if (Rounds.Computer.Computer == EnStonePapperScissors.Scissors)
                    {
                        Lb_NumPlayerWins.Text = (++Rounds.Player.Wins).ToString();
                        MessageBox.Show("Winner Round \n Player", "Round "+(Rounds.NumberRounds-Rounds.NumberRounds+1).ToString());
                    }
                    else if (Rounds.Computer.Computer == EnStonePapperScissors.Papper)
                    {
                        Lb_NumComputerWins.Text = (++Rounds.Computer.Wins).ToString();
                        MessageBox.Show("Winner Round \n Computer", "Round "+ (Rounds.NumberRounds - Rounds.NumberRounds + 1).ToString());
                    }
                    else
                    {
                        Lb_NumDraw.Text = (++Rounds.Draw).ToString();
                        MessageBox.Show("Draw", "Opps " + (Rounds.NumberRounds - Rounds.NumberRounds + 1).ToString());
                    }

                    break;
                case EnStonePapperScissors.Papper:
                    if (Rounds.Computer.Computer == EnStonePapperScissors.Stone)
                    {
                        Lb_NumPlayerWins.Text = (++Rounds.Player.Wins).ToString();
                        MessageBox.Show("Winner Round \n Player", "Round " + (Rounds.NumberRounds - Rounds.NumberRounds + 1).ToString());
                    }
                    else if (Rounds.Computer.Computer == EnStonePapperScissors.Scissors)
                    {
                        Lb_NumComputerWins.Text = (++Rounds.Computer.Wins).ToString();
                        MessageBox.Show("Winner Round \n Computer", "Round " + (    Rounds.NumberRounds - Rounds.NumberRounds + 1).ToString());
                    }
                    else
                    {
                        Lb_NumDraw.Text = (++Rounds.Draw).ToString();
                        MessageBox.Show("Draw", "Opps" + (Rounds.NumberRounds - Rounds.NumberRounds + 1).ToString());
                    }
                    break;
                case EnStonePapperScissors.Scissors:
                    if (Rounds.Computer.Computer == EnStonePapperScissors.Papper)
                    {
                        Lb_NumPlayerWins.Text = (++Rounds.Player.Wins).ToString();
                        MessageBox.Show("Winner Round \n Player", "Round " + (Rounds.NumberRounds - Rounds.NumberRounds + 1).ToString());
                    }
                    else if (Rounds.Computer.Computer == EnStonePapperScissors.Stone)
                    {
                        Lb_NumComputerWins.Text = (++Rounds.Computer.Wins).ToString();
                        MessageBox.Show("Winner Round \n Computer", "Round " + (Rounds.NumberRounds - Rounds.NumberRounds + 1).ToString());
                    }
                    else
                    {
                        Lb_NumDraw.Text = (++Rounds.Draw).ToString();
                        MessageBox.Show("Draw", "opps" + (Rounds.NumberRounds - Rounds.NumberRounds + 1).ToString());
                    }
                    break;
                default:
                    break;

            }
        }

        private void Change_Picture()
        {
            
            switch (Rounds.Computer.Computer) 
            {

                case EnStonePapperScissors.Stone:
                    Pb_ComputerChoice.Image = Resources.Stone;
                    break;
                case EnStonePapperScissors.Papper:
                    Pb_ComputerChoice.Image = Resources.Papper;
                    break;
                case EnStonePapperScissors.Scissors:
                    Pb_ComputerChoice.Image = Resources.Scissors;
                    break;
                default:
                    break;
            }
        }

        private void Game_Over()
        {
            MessageBox.Show("Game Over", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Rounds.Player.Wins > Rounds.Computer.Wins)
            {
                MessageBox.Show("Player Winner......", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lb_Player.BackColor = Color.Green;
                Lb_NumPlayerWins.BackColor = Color.Green;
            }
            else if (Rounds.Player.Wins < Rounds.Computer.Wins)
            {
                MessageBox.Show("Computer Winner.........", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lb_Computer.BackColor = Color.Green;
                Lb_NumComputerWins.BackColor = Color.Green;
            }
        }

        private void Btn_Round_Click(object sender, EventArgs e)
        {
               
            if (Rounds.NumberRounds == 0)
            {
                MessageBox.Show("Please,Enter Rounds:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Rounds.Player.Player == 0)
            {
                MessageBox.Show("Please,Enter Player Choice:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Pn_NumberRounds.Enabled = false;
            Computer_Choice();
                
            Change_Picture();
            Round_Winner();
            Rounds.NumberRounds--;
            Pb_PlayerChoice.Image = Resources.question_mark_96;
            Pb_ComputerChoice.Image = Resources.question_mark_96;
            if( Rounds.NumberRounds == 0 )
                Game_Over();
           
        }

        private void Rd_OneRound_CheckedChanged(object sender, EventArgs e)
        {
            Rounds.NumberRounds = Convert.ToByte(Rd_OneRound.Tag.ToString());

        }

        private void Rd_3Round_CheckedChanged(object sender, EventArgs e)
        {
            Rounds.NumberRounds=Convert.ToByte(Rd_3Round.Tag.ToString());
        }

        private void Rd_5Rounds_CheckedChanged(object sender, EventArgs e)
        {
            Rounds.NumberRounds=Convert.ToByte(Rd_5Rounds.Tag.ToString());
        }

        private void Rd_10Rounds_CheckedChanged(object sender, EventArgs e)
        {
            Rounds.NumberRounds=Convert.ToByte(Rd_10Rounds.Tag.ToString());
        }

        private void Pb_Stone_Click(object sender, EventArgs e)
        {
            Rd_Stone.Checked=true;
            Rounds.Player.Player=(EnStonePapperScissors)Convert.ToByte(Pb_Stone.Tag.ToString());
            Pb_PlayerChoice.Image = Resources.Stone;
        }

        private void Pb_Papper_Click(object sender, EventArgs e)
        {
            Rd_Papper.Checked=true;
            Rounds.Player.Player = (EnStonePapperScissors)Convert.ToByte(Pb_Papper.Tag.ToString());
            Pb_PlayerChoice.Image = Resources.Papper;
        }

        private void Pb_Scissors_Click(object sender, EventArgs e)
        {
            Rd_Scissors.Checked = true;
            Rounds.Player.Player = (EnStonePapperScissors)Convert.ToByte(Pb_Scissors.Tag.ToString());
            Pb_PlayerChoice.Image = Resources.Scissors;
        }

        private void Rd_Stone_CheckedChanged(object sender, EventArgs e)
        {
            Rounds.Player.Player = (EnStonePapperScissors)Convert.ToByte(Pb_Stone.Tag.ToString());
            Pb_PlayerChoice.Image = Resources.Stone;
        }

        private void Rd_Papper_CheckedChanged(object sender, EventArgs e)
        {
            Rounds.Player.Player = (EnStonePapperScissors)Convert.ToByte(Pb_Papper.Tag.ToString());
            Pb_PlayerChoice.Image = Resources.Papper;
        }

        private void Rd_Scissors_CheckedChanged(object sender, EventArgs e)
        {
            Rounds.Player.Player = (EnStonePapperScissors)Convert.ToByte(Pb_Scissors.Tag.ToString());
            Pb_PlayerChoice.Image = Resources.Scissors;
        }


    }
}
