using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite um número inteiro:");
            a = int.Parse(Console.ReadLine());
            if (a%2 == 0)
            {
                Console.WriteLine("O nùmero digitado é par.");
            }
            else
            {
                Console.WriteLine("O número digitado é ímpar.");
            }  
                Console.ReadKey();
        }
    }
}
