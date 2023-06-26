using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace date
{
    internal class Number
    {
        public Number() { }
        public int Num1 { 
            get; set;   
        }
        public int Num2
        {
            get; set;
        }
        public int Num3 {
            get; set;    
        }
        public void Input()
        {
            Console.Write("Input the 1st number :");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            Num3 = Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {

            if (Num1 > Num2)
            {
                if (Num1 > Num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (Num2 > Num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }
    }
}
