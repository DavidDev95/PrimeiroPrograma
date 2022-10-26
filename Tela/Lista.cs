using Programa1.Aritimetica;
using Programa1.Arquivos;
using Programa1.Tela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Programa1.Tela
{
    

    internal class Lista
    {
        public const int LEITOR = 1;
        public const int MULTIPLICADOR = 2;
        public const int MEDIADOR = 3;
        public const int SAIR = 4;
        public static void Menu()
        {
        
            while (true)
            {
                string mensagem = "****Olá, Bem vindo ao meu primeiro programa em C#!!!***" +
                    "\n\n" +
                    "\n**** Digite uma das opções a baixo: ****" +
                    "\n* 1 - Ler arquivos;                *" +
                    "\n* 2 - Calcular Tabuada;            *" +
                    "\n* 3 - Calcular Media entre Notas;  *" +
                    "\n* 4 - para encerrar o programa;    *";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIR)
                {
                    break;
                }
                else if (valor == LEITOR)
                {

                    LerArquivo.Arquivos(1);

                }
                else if (valor == MULTIPLICADOR)
                {
                    Console.WriteLine("==============================");
                    Console.WriteLine("Digite o valor da Tabuada que deseja:");
                    int numeroDivisor = int.Parse(Console.ReadLine());
                    CriarTabuada.Tabuada(numeroDivisor);
                    Console.WriteLine("==============================");
                }
                else if (valor == MEDIADOR)
                {

                    Console.WriteLine("==============================");
                    CalculoMedia.MediaNotas();
                    Console.WriteLine("==============================");
                }
                else
                {
                    Console.WriteLine(" Opção invalidada!!" + "\n presione Enter para voltar ao menu:");
                }

                Console.ReadLine();
            }
        }
    }
}
