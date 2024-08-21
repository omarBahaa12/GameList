using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class clsMathGame
    {
        public enum enDifficulty { Easy, Medium, Hard, VeryHard }
        public enum enOperation { Add, Minus, Multy, Divide, All }
       
        private Random rnd=new Random();
        public enOperation Operation { set; get; }

        public enDifficulty Difficulty { set; get; }

        public byte NumberofQuetions {  set; get; }
        
        public bool Timer { set; get; }

        private short Number1 { set; get; }

        private short Number2 { set; get; }

        public short Result { set; get; }

        public short CorrectAnswer { set; get; }

        public short WrongAnswer { set; get; }

        public string GetSign()
        {
            switch (Operation)
            {
                case enOperation.Add: return "+";
                case enOperation.Minus: return "-";
                case enOperation.Multy: return "*";
                case enOperation.Divide: return "/";
                
                default: return "+";
            }
        }

        private void RandomNumbers()
        {
            switch (Difficulty) 
            {
                case enDifficulty.Easy:
                    Number1=(short)rnd.Next(1,10);
                    Number2=(short)rnd.Next(1,10);
                    break;
                    
                case enDifficulty.Medium:
                    Number1 = (short)rnd.Next(8, 22);
                    Number2 = (short)rnd.Next(8, 22);
                    break;
                    
                case enDifficulty.Hard:
                    Number1 = (short)rnd.Next(20, 80);
                    Number2 = (short)rnd.Next(20, 80);
                    break;
                    
                case enDifficulty.VeryHard:
                    Number1 = (short)rnd.Next(10, 100);
                    Number2=(short)rnd.Next(10,100);
                    break;  
                    
                default: return;
            }

        }

        private void GetResult() 
        {
            if (Operation == enOperation.Add)
                Result = (short)(Number1 + Number2);
            else if(Operation==enOperation.Minus)
                Result= (short)(Number1 - Number2);
            else if (Operation==enOperation.Multy)
                Result = (short)(Number1 * Number2);
            else if ( Operation==enOperation.Divide)
                Result=(short)(Number1 / Number2);


        }

        public string GetCalcution()
        {
            if( Operation == enOperation.All)
            {
                RandomNumbers();
                Operation = (enOperation)rnd.Next(0,3);
                GetResult();
                string str=Convert.ToString(Number1)+GetSign()+ Convert.ToString(Number2);
                Operation = enOperation.All;
                return str;
            }
            RandomNumbers();
            GetResult();
            return Convert.ToString(Number1) + GetSign() + Convert.ToString(Number2);


        }


    }
}
