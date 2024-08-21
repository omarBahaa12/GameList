using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using X_O_Game.Properties;

namespace X_O_Game
{
    public partial class FrmX_O_Game : Form
    {
        byte Num = 0;
        public FrmX_O_Game()
        {
            InitializeComponent();
            
        }

        private void FrmX_O_Game_Paint(object sender, PaintEventArgs e)
        {
            Color White=Color.FromArgb(255,255,255,255);
            Pen pen = new Pen(White);
            pen.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 550, 400, 550, 100);
            e.Graphics.DrawLine(pen, 400, 400, 400, 100);
            e.Graphics.DrawLine(pen, 680, 300, 280, 300);
            e.Graphics.DrawLine(pen, 680, 200, 280, 200);
        }

        private void Btn_Restart_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox1.Tag = "Question";
            pictureBox2.Tag = "Question";
            pictureBox3.Tag = "Question";
            pictureBox4.Tag = "Question";
            pictureBox5.Tag = "Question";
            pictureBox6.Tag = "Question";
            pictureBox7.Tag = "Question";
            pictureBox8.Tag = "Question";
            pictureBox9.Tag = "Question";
            pictureBox1.Image = Resources.question_mark_96;
            pictureBox2.Image = Resources.question_mark_96;
            pictureBox3.Image = Resources.question_mark_96;
            pictureBox3.Image= Resources.question_mark_96;
            pictureBox4.Image = Resources.question_mark_96;
            pictureBox5.Image = Resources.question_mark_96;
            pictureBox6.Image = Resources.question_mark_96;
            pictureBox7.Image = Resources.question_mark_96;
            pictureBox8.Image = Resources.question_mark_96;
            pictureBox9.Image = Resources.question_mark_96;
            pictureBox1.BackColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BackColor = Color.Black;
            pictureBox8.BackColor = Color.Black;
            pictureBox9.BackColor = Color.Black;
            Num = 0;
            Lab_PlayerTurn.Text = "Player1";
            Lab_Win.Text = "In Progress";

        }

        private void Change_Photo(object sender)
        {
            if(Lab_PlayerTurn.Text== "Player1")
            {
                ((PictureBox)sender).Image = Resources.X;
                ((PictureBox)sender).Tag = "Player1";
                Lab_PlayerTurn.Text = "Player2";

            }
            else if (Lab_PlayerTurn.Text == "Player2")
            {
                ((PictureBox)sender).Image = Resources.O;
                ((PictureBox)sender).Tag = "Player2";
                Lab_PlayerTurn.Text = "Player1";
            }

        }

        private void Game_Over()
        {
            MessageBox.Show("GAME OVER", "OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
        }

        private void Color_Change(object sender1,object sender2,object sender3)
        {
            ((PictureBox)sender1).BackColor = Color.Green;
            ((PictureBox)sender2).BackColor = Color.Green;
            ((PictureBox)sender3).BackColor = Color.Green;
        }
        private void Check_Pic1()
        {
            if (pictureBox1.Tag == pictureBox2.Tag && pictureBox1.Tag == pictureBox3.Tag)
            {
                Lab_Win.Text = pictureBox1.Tag.ToString();
                Color_Change(pictureBox1, pictureBox2,pictureBox3);
                Game_Over();
            }
            else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox1.Tag == pictureBox7.Tag)
            {
                Lab_Win.Text = pictureBox1.Tag.ToString();
                Color_Change(pictureBox1,pictureBox4,pictureBox7);
                Game_Over();
            }
            else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox1.Tag == pictureBox9.Tag)
            {
                Lab_Win.Text = pictureBox1.Tag.ToString();
                Color_Change(pictureBox1 , pictureBox5,pictureBox9);
                Game_Over();
            }
        }

        private void Check_Pic2()
        {
            if (pictureBox2.Tag == pictureBox5.Tag && pictureBox2.Tag == pictureBox8.Tag)
            {
                Lab_Win.Text = pictureBox2.Tag.ToString();
                Color_Change(pictureBox2 , pictureBox5,pictureBox8);
                Game_Over();

            }
            else if (pictureBox2.Tag == pictureBox1.Tag && pictureBox2.Tag == pictureBox3.Tag)
            {
                Lab_Win.Text = pictureBox2.Tag.ToString();
                Color_Change(pictureBox2 , pictureBox1,pictureBox3);
                Game_Over();
            }

        }

        private void Check_Pic3()
        {
            if (pictureBox3.Tag == pictureBox6.Tag && pictureBox3.Tag == pictureBox9.Tag)
            {
                Lab_Win.Text = pictureBox3.Tag.ToString();
                Color_Change(pictureBox3, pictureBox6,pictureBox9);
                Game_Over();
            }
            else if (pictureBox3.Tag == pictureBox1.Tag && pictureBox3.Tag == pictureBox2.Tag)
            {
                Lab_Win.Text = pictureBox3.Tag.ToString();
                Color_Change(pictureBox3 , pictureBox1,pictureBox2);
                Game_Over();
            }
            else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox3.Tag == pictureBox7.Tag)
            {
                Lab_Win.Text = pictureBox3.Tag.ToString();
                Color_Change(pictureBox3,pictureBox7,pictureBox5);
                Game_Over();
            }

        }

        private void Check_Pic4() 
        {
            if (pictureBox4.Tag == pictureBox5.Tag && pictureBox4.Tag == pictureBox6.Tag)
            {
                Lab_Win.Text = pictureBox4.Tag.ToString();
                Color_Change(pictureBox4, pictureBox5,pictureBox6);
                Game_Over();
            }
            else if (pictureBox4.Tag == pictureBox1.Tag && pictureBox4.Tag == pictureBox7.Tag)
            {
                Lab_Win.Text = pictureBox4.Tag.ToString();
                Color_Change(pictureBox4 , pictureBox1,pictureBox7);
                Game_Over();
            }

        }

        private void Check_Pic5() 
        {
            if (pictureBox5.Tag == pictureBox2.Tag && pictureBox5.Tag == pictureBox8.Tag)
            {
                Lab_Win.Text = pictureBox5.Tag.ToString();
                Color_Change(pictureBox2, pictureBox5, pictureBox8);
                Game_Over();
            }
            else if (pictureBox5.Tag == pictureBox4.Tag && pictureBox5.Tag == pictureBox6.Tag)
            {
                Lab_Win.Text = pictureBox5.Tag.ToString();
                Color_Change(pictureBox4, pictureBox5, pictureBox6);
                Game_Over();
            }
            else if (pictureBox5.Tag == pictureBox3.Tag && pictureBox5.Tag == pictureBox7.Tag)
            {
                Lab_Win.Text = pictureBox5.Tag.ToString();
                Color_Change(pictureBox3, pictureBox5, pictureBox7);
                Game_Over();
            }
            else if (pictureBox5.Tag == pictureBox1.Tag && pictureBox5.Tag == pictureBox9.Tag)
            {
                Lab_Win.Text = pictureBox5.Tag.ToString();
                Color_Change(pictureBox1, pictureBox5, pictureBox9);
                Game_Over();
            }
        }

        private void Check_Pic6() 
        {
            if (pictureBox6.Tag == pictureBox3.Tag && pictureBox6.Tag == pictureBox9.Tag)
            {
                Lab_Win.Text = pictureBox6.Tag.ToString();
                Color_Change(pictureBox6,pictureBox3, pictureBox9);
                Game_Over();
            }
            else if (pictureBox6.Tag == pictureBox4.Tag && pictureBox6.Tag == pictureBox5.Tag)
            {
                Lab_Win.Text = pictureBox5.Tag.ToString();
                Color_Change(pictureBox6 ,pictureBox4, pictureBox5);
                Game_Over();
            }
        }

        private void Check_Pic7()
        {
            if (pictureBox7.Tag == pictureBox8.Tag && pictureBox7.Tag == pictureBox9.Tag)
            {
                Lab_Win.Text = pictureBox7.Tag.ToString();
                Color_Change (pictureBox7,pictureBox8, pictureBox9);
                Game_Over();
            }
            else if (pictureBox7.Tag == pictureBox1.Tag && pictureBox7.Tag == pictureBox4.Tag)
            {
                Lab_Win.Text = pictureBox7.Tag.ToString();
                Color_Change(pictureBox7,pictureBox1 , pictureBox4);
            }
            else if (pictureBox5.Tag == pictureBox3.Tag && pictureBox5.Tag == pictureBox7.Tag)
            {
                Lab_Win.Text = pictureBox5.Tag.ToString();
                Color_Change(pictureBox3, pictureBox5, pictureBox7);
                Game_Over();
            }
        }

        private void Check_Pic8() 
        {
            if (pictureBox8.Tag == pictureBox7.Tag && pictureBox8.Tag == pictureBox9.Tag)
            {
                Lab_Win.Text = pictureBox8.Tag.ToString();
                Color_Change(pictureBox8 ,pictureBox9, pictureBox7);
                Game_Over();
            }
            else if (pictureBox8.Tag == pictureBox5.Tag && pictureBox2.Tag == pictureBox8.Tag)
            {
                Lab_Win.Text = pictureBox8.Tag.ToString();
                Color_Change(pictureBox8,pictureBox5 , pictureBox2);
                Game_Over();
            }

        }

        private void Check_Pic9() 
        {
            if (pictureBox9.Tag == pictureBox7.Tag && pictureBox8.Tag == pictureBox9.Tag)
            {
                Lab_Win.Text = pictureBox9.Tag.ToString();
                Color_Change(pictureBox8,pictureBox9, pictureBox7);
                Game_Over();
            }
            else if (pictureBox9.Tag == pictureBox6.Tag && pictureBox3.Tag == pictureBox9.Tag)
            {
                Lab_Win.Text = pictureBox9.Tag.ToString();
                Color_Change(pictureBox6, pictureBox9, pictureBox3);
            }
            else if (pictureBox9.Tag == pictureBox5.Tag && pictureBox1.Tag == pictureBox9.Tag)
            {
                Lab_Win.Text = pictureBox9.Tag.ToString();
                Color_Change (pictureBox5, pictureBox9, pictureBox1);
                Game_Over();
            }

        }

        private void Plus_Num()
        {
            Num++;
            if(Num == 9) 
            {
                MessageBox.Show("GameOver","Draw",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lab_Win.Text = "Draw";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Tag.ToString()=="Question")
            { 
                Change_Photo(pictureBox1);
                Check_Pic1();
                Plus_Num();
            }
            else
                MessageBox.Show("Wrong Chioce","Warring",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag.ToString() == "Question")
            {
                Change_Photo(pictureBox4);
                Check_Pic4 ();
                Plus_Num ();
            }
            else
                MessageBox.Show("Wrong Chioce", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Tag.ToString() == "Question")
            {
                Change_Photo(pictureBox7);
                Check_Pic7 ();
                Plus_Num ();
            }
            else
                MessageBox.Show("Wrong Chioce", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Tag.ToString() == "Question")
            {
                Change_Photo(pictureBox2);
                Check_Pic2 ();
                Plus_Num();
            }
            else
                MessageBox.Show("Wrong Chioce", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Tag.ToString() == "Question")
            {
                Change_Photo(pictureBox6);
                Check_Pic6 ();
                Plus_Num();
            }
            else
                MessageBox.Show("Wrong Chioce", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Tag.ToString() == "Question")
            {
                Change_Photo(pictureBox8);
                Check_Pic8();
                Plus_Num ();
            }
            else
                MessageBox.Show("Wrong Chioce", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Tag.ToString() == "Question")
            {
                Change_Photo(pictureBox3);
                Check_Pic3 ();
                Plus_Num();
            }
            else
                MessageBox.Show("Wrong Chioce", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Tag.ToString() == "Question")
            {
                Change_Photo(pictureBox5);
                Check_Pic5 ();
                Plus_Num();
            }
            else
                MessageBox.Show("Wrong Chioce", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Tag.ToString() == "Question")
            {
                Change_Photo(pictureBox9);
                Check_Pic9 ();
                Plus_Num();
            }
            else
                MessageBox.Show("Wrong Chioce", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
