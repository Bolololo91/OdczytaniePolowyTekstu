using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Połowa_tekstu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst");
            string tekst = Console.ReadLine();
            char[] karol = tekst.ToArray();
            string newKarol = "";
            for (int i = 0; i <= tekst.Length-1; i++)
            {
                if (i>(tekst.Length-1)/2)
                {
                    newKarol += karol[i];

                }
            }Console.Write(newKarol);
            Console.ReadKey();
        }
    }
}
