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
        var cliente2 = new Cliente();

        cliente.Nome = "Ana";
        cliente.Telefone = "N/A";
        cliente.CPF = "22132144520";
        cliente.Gravar();
        /*
        cliente2.Nome = "Aline";
        cliente2.Telefone = "119332234452";
        cliente2.CPF = "44378920934";
        cliente2.Gravar(); */



    }
   
 }       
