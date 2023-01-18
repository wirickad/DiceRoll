using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    public class PrintStuff
    {

        private string language = "";
        //Constructor
        public PrintStuff(string temp)
        {
            language = temp;

        }
        public void PrintName(string name)
        {
            if (language == "EN")
            {
                Console.WriteLine("Hello, " + name);
            }

            if (language == "PT")
            {
                Console.WriteLine("Oi, " + name);
            }
            
            Console.Read();
        }
    }
}
