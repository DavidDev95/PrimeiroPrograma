using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1.Aritimetica
{
    internal class CalculoMedia
    {

     public static void MediaNotas()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(" Digite  o nome do Aluno: ");
            Console.WriteLine("==============================");
            string NomeAluno = Console.ReadLine();
            int QtdNotas = 4;
            Console.WriteLine("==============================");
            Console.WriteLine("Digite as " + QtdNotas + " do aluno: " + NomeAluno);
            Console.WriteLine("==============================");
            List<int> notas = new List<int>();
            int Total = 0;
            for (int i = 1; i <= QtdNotas; i++)
            {
                Console.WriteLine("Digite a nota" + i + ": ");
                int Valores = int.Parse(Console.ReadLine());
                Total += Valores;
                notas.Add(Valores);
            }
            foreach (int nota in notas)
            {
                Console.WriteLine("==============================");
                Console.WriteLine(" As notas do " + NomeAluno + " são: " + nota + "\n");

            }
            Console.WriteLine("==============================");
            int Media = Total / QtdNotas;
            Console.Write("A media do Aluno " + NomeAluno + " é: " + Media);
            Console.WriteLine("==============================");

        }
    }
    
}