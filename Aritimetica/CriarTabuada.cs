using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1.Aritimetica
{
    internal class CriarTabuada
    {
        public static void Tabuada(int Divisor)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine(" Tabuada do " + Divisor);
            for (int i = 1; i <= 20; i++)
                Console.WriteLine(Divisor + " X " + i + " = " + (Divisor * i));
            Console.WriteLine("====================================================\n");
            Console.WriteLine("Pressione Enter para voltar ao menu!!!");
        }
    }
}
