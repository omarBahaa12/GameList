using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class FrmMathGame : Form
    {
        
        clsMathGame mathGame=new clsMathGame();

        private short _Counter;
        public FrmMathGame(clsMathGame clsMath )
        {
            InitializeComponent();
            mathGame = clsMath;
            StartQuiz();
            if(mathGame.Timer)
            {
                timer1.Enabled = true;
                Lb_Timer.Visible = true;
            }
        }


        public enum enRdAnswer { Rd1=1,Rd2 ,Rd3};

        private enRdAnswer answer;

        private Random random = new Random();
        private void EualizerRdButton()
        {
           
            answer = (enRdAnswer)random.Next(1,4);
            switch(answer) 
            {
                case enRdAnswer.Rd1:
                    Rd_Answer1.Text = Convert.ToString( mathGame.Result);
                    Rd_Answer2.Text = Convert.ToString( mathGame.Result+random.Next(1,20));
                    Rd_Answer3.Text = Convert.ToString(mathGame.Result + random.Next(3, 15));
                    break;
                case enRdAnswer.Rd2:
                    Rd_Answer2.Text = Convert.ToString(mathGame.Result);
                    Rd_Answer1.Text = Convert.ToString(mathGame.Result + random.Next(1, 20));
                    Rd_Answer3.Text = Convert.ToString(mathGame.Result + random.Next(3, 15));
                    break;
                case enRdAnswer.Rd3:
                    Rd_Answer3.Text = Convert.ToString(mathGame.Result);
                    Rd_Answer2.Text = Convert.ToString(mathGame.Result + random.Next(1, 20));
                    Rd_Answer1.Text = Convert.ToString(mathGame.Result + random.Next(3, 15));
                    break;
                default : break;
            }
        }

        private void StartQuiz()
        {
            Lb_Calculation.Text=mathGame.GetCalcution();
            EualizerRdButton();
        }

        private void CheckingFromCorrectAnswer()
        {
            if (Rd_Answer1.Checked)
            {
                if (Rd_Answer1.Text == Convert.ToString(mathGame.Result))
                {
                    mathGame.CorrectAnswer++;
                    Lb_NumCorrectAnswer.Text =Convert.ToString(mathGame.CorrectAnswer);
                    Rd_Answer1.Checked = false;
                    return;
                }
            }
            else if (Rd_Answer2.Checked)
            {
                if (Rd_Answer2.Text == Convert.ToString(mathGame.Result))
                {
                    mathGame.CorrectAnswer++;
                    Lb_NumCorrectAnswer.Text = Convert.ToString(mathGame.CorrectAnswer);
                    Rd_Answer2.Checked = false;
                    return;
                }
            }
            else if (Rd_Answer3.Checked)
            {
                if (Rd_Answer3.Text == Convert.ToString(mathGame.Result))
                {
                    mathGame.CorrectAnswer++;
                    Lb_NumCorrectAnswer.Text = Convert.ToString(mathGame.CorrectAnswer);
                    Rd_Answer3.Checked = false;
                    return;
                }
            }
            mathGame.WrongAnswer++;
            Lb_NumWrongAnswer.Text = Convert.ToString(mathGame.WrongAnswer);
        }

        private bool IsFinished()
        {
            if (mathGame.NumberofQuetions != mathGame.CorrectAnswer + mathGame.WrongAnswer)
                return true;
            return false;
        }

        private void Successed_Failed()
        {
            
            if (mathGame.CorrectAnswer > mathGame.NumberofQuetions/2)
            {
                MessageBox.Show("You Successed ", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = false;
            }
            else
            {
                MessageBox.Show(" You Failed ", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = false;
            }
            
        }

        private void Btn_CheckAnswer_Click(object sender, EventArgs e)
        {
            if(IsFinished())
            {
                CheckingFromCorrectAnswer();
                StartQuiz();
                return;
            }
            Successed_Failed();

        }


        private void TimerAndDifficulty()
        {
            switch (mathGame.Difficulty)
            {
                case clsMathGame.enDifficulty.Easy:
                    if (_Counter != mathGame.NumberofQuetions * 10)
                    {
                        _Counter++;
                        TimeSpan time = new TimeSpan(0, 0, 0, _Counter);
                        Lb_Timer.Text = time.ToString();
                    }
                    else
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Time is Finished ", "Finished ");
                        Btn_CheckAnswer.Enabled = false;
                        Successed_Failed();
                        
                    }
                    break;
                case clsMathGame.enDifficulty.Medium:
                    if (_Counter != mathGame.NumberofQuetions * 7)
                    {
                        _Counter++;
                        TimeSpan time = new TimeSpan(0, 0, 0, _Counter);
                        Lb_Timer.Text = time.ToString();

                    }
                    else
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Time is Finished ", "Finished ");
                        Btn_CheckAnswer.Enabled = false;
                        Successed_Failed();
                    }
                    break;
                case clsMathGame.enDifficulty.Hard:
                    if (_Counter != mathGame.NumberofQuetions * 5)
                    {
                        _Counter++;
                        TimeSpan time = new TimeSpan(0, 0, 0, _Counter);
                        Lb_Timer.Text = time.ToString();

                    }
                    else
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Time is Finished ", "Finished ");
                        Btn_CheckAnswer.Enabled = false;
                        Successed_Failed();
                    }
                    break;
                case clsMathGame.enDifficulty.VeryHard:
                    if (_Counter != mathGame.NumberofQuetions * 3)
                    {
                        _Counter++;
                        TimeSpan time = new TimeSpan(0, 0, 0, _Counter);
                        Lb_Timer.Text = time.ToString();
                    }
                    else
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Time is Finished ", "Finished ");
                        Btn_CheckAnswer.Enabled = false;
                        Successed_Failed();
                    }
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerAndDifficulty();
        }

    }
}
