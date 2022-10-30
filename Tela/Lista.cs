using Programa1.Aritimetica;
using Programa1.Arquivos;
using Programa1.Dados;
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
        public const int CADASTRAR_CLIENTES = 4;
        public const int SAIR = 5;

        public static void Menu()
        {
        
            while (true)
            {
                string mensagem = "****Olá, Bem vindo ao meu primeiro programa em C#!!!***" +
                    "\n\n" +
                    "\n**** Digite uma das opções a baixo: ****" +
                    "\n* 1 - Ler todos os arquivos;       *" +
                    "\n* 2 - Calcular Tabuada;            *" +
                    "\n* 3 - Calcular Media entre Notas;  *" +
                    "\n* 4 - Cadastrar clientes;          *" +
                    "\n* 5 - para encerrar o programa;    *";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIR)
                {
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Encerrando...");
                    Console.WriteLine("====================================================");
                    break;
                }
                else if (valor == LEITOR)
                {
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Lendo arquivos... ");
                    Console.WriteLine("====================================================\n");
                    LerArquivo.Arquivos(1);

                }
                else if (valor == MULTIPLICADOR)
                {
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Digite o valor da Tabuada que deseja até x20:");
                    int numeroDivisor = int.Parse(Console.ReadLine());
                    CriarTabuada.Tabuada(numeroDivisor);
                    Console.WriteLine("====================================================\n");
                }
                else if (valor == MEDIADOR)
                {

                    Console.WriteLine("====================================================");
                    CalculoMedia.MediaNotas();
                    Console.WriteLine("====================================================\n");
                }
                 else if(valor == CADASTRAR_CLIENTES)
                {
                   
                    Clientes.cadastrar();
                       
                }
                else
                {

                    Console.WriteLine("====================================================\n" + " Opção invalidada!!" + "\n====================================================\n" + "\n presione Enter para voltar ao menu:");
                }

                Console.ReadLine();
            }
        }
    }
}
