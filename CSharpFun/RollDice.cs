using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    public class RollDice
    {
        //Generate a number between 1-6 random number
        public int Roll()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }

        public int GetTotal()
        {
            int roll1 = Roll();
            int roll2 = Roll();
            return roll1 + roll2;
        }
   
    }
}
