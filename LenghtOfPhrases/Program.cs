using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenghtOfPhrases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Sake = new string[5] {"Екатерина", "Виктория", "Виктор", "Андрей", "Аня"};
            Console.WriteLine(Name(Sake));
            Console.ReadKey();
        }
        public static int Name(string[] number)
        {
            int n = 0;
            for(int i = 0; i < number.Length; i++)
            {
                if (number[i].Length >= 5)
                {
                    n++;
                }
            }
            return n;
        }
    }
}
