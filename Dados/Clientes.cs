using Programa1.Tela;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1.Dados
{
    internal class Clientes
    {
        public static void cadastrar()
        {


            Console.WriteLine("*************Cadastrar clientes****************");

            while (true){
                
                string mensagem = "==============================================\n" +  
                                  "   Digite uma opção" +
                                  "\n\n"+
                                  "\n     0 - Para sair do cadastro de clientes;"+
                                  "\n     1 - Cadastrar cliente"+
                                  "\n     2 - Listar clientes cadastrados \n" +
                                  "==============================================\n";
                Console.WriteLine(mensagem);


                var valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Saindo do cadastro de clientes!");
                    Console.WriteLine("Pressione Enter para voltar ao menu!");
                    Console.WriteLine("====================================================");
                    break;
                }
                else if(valor == 1)
                {
                    var cliente = new Cliente();
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Digite o nome do cliente: ");
                    Console.WriteLine("====================================================");
                    cliente.Nome = Console.ReadLine();
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Digite o telefone do cliente: ");
                    Console.WriteLine("====================================================");
                    cliente.Telefone = Console.ReadLine();
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Digite o CPF do cliente: ");
                    Console.WriteLine("====================================================");
                    cliente.CPF = Console.ReadLine();
                    cliente.Gravar();
                }
                else if (valor==2)
                {
                    var clientes = Cliente.ListaDeClientes();
                    foreach (Cliente a in clientes)
                    {
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Nome:     "+a.Nome);
                        Console.WriteLine("Telefone: "+a.Telefone);
                        Console.WriteLine("CPF:      "+a.CPF);
                        Console.WriteLine("====================================================");
                    }
                }
                else
                {
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Opção Invalida, pressione enter para voltar ao menu!");
                    Console.WriteLine("====================================================");
                }
            }
                      
        }

    }
}
