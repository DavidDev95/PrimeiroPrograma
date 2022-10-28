using Programa1.Aritimetica;
using Programa1.Arquivos;
using Programa1.Dados;
using Programa1.Tela;
using System.Linq.Expressions;
using System.Xml;

internal class Program
{
   
    public static void Main(string[] args)
    {
        //Lista.Menu();


       var clientes = Cliente.ListaDeClientes();

        var cliente = new Cliente();
        
        cliente.Nome = "Aline";
        cliente.Telefone = "11977324422";
        cliente.CPF = "34522399090";
        //cliente.Gravar();

        foreach (Cliente a in clientes)
        {
            Console.WriteLine(a.Nome);
            Console.WriteLine(a.Telefone);
            Console.WriteLine(a.CPF);
        }

        Console.ReadLine();
        

        //var cliente2 = new Cliente();
        /*
        cliente2.Nome = "Aline";
        cliente2.Telefone = "119332234452";
        cliente2.CPF = "44378920934";
        cliente2.Gravar(); */



    }

}       
