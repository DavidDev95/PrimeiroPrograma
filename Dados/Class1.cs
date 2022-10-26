using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1.Dados
{
    public class Cliente
    {
        public string Nome;
        public string Telefone;
        public string CPF;

        public void Gravar()
        {

        }
        private static string PastaBaseDeDados()
        {
            return ConfigurationManager.AppSettings["Base_de_Cliente"];

        }

        public static List<Cliente> ListaDeClientes()
        {

            var Clientes = new List<Cliente>();
            if (File.Exists(PastaBaseDeDados()))
            {
                using (StreamReader arquivo = File.OpenText(PastaBaseDeDados()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var ClienteArquivo = linha.Split(";");
                        var cliente = new Cliente();
                        cliente.Nome = ClienteArquivo[0];
                        cliente.Telefone = ClienteArquivo[1];
                        cliente.CPF = ClienteArquivo[2];

                        Clientes.Add(cliente);
                    }
                }
            } return Clientes;
        }        
    }
}
