using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Programa1.Arquivos
{
    internal class LerArquivo
    {
        private static string Pasta()
        {
            return ConfigurationManager.AppSettings["diretorio"];
        }
        public static void Arquivos(int NumeroDeArquivo)
        {
            string diretorio = Pasta() + "arq" + NumeroDeArquivo + ".txt";
            if (File.Exists(diretorio))
            {
                using (StreamReader arquivo = File.OpenText(diretorio))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);

                    }
                }

                Console.WriteLine("====================================================");
                Console.WriteLine("Arquivo"+NumeroDeArquivo+" lido com sucesso!!!");
                Console.WriteLine("====================================================\n");
                Console.WriteLine("Pressione enter para voltar ao menu!");
            }
            string diretorio2 = Pasta() + "arq"+ NumeroDeArquivo + ".txt";
            if (File.Exists(diretorio2))
            {
                Arquivos(NumeroDeArquivo + 1);
                             
            }

        }

    }
}
