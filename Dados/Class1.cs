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

       /// <summary>
       /// Constructor com varios parametos
       /// </summary>
       /// <param name="nome"> insira o nome do Objeto</param>
       /// <param name="telefone"> insira o telefone do Objeto</param>
       /// <param name="cpf"> insira o cpf do Objeto</param>
        public Cliente (string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }


        /// <summary>
        /// Construtor da classe com parametro diferente
        /// </summary>
        /// <param name="telefone">Para preencher o telefone do Objeto</param>
        public Cliente( int telefone)
        {
            this.Telefone = telefone.ToString();
        }

       
        /// <summary>
        /// Construtor sem parametros
        /// </summary>
        public Cliente() { }
        

        public void Gravar()
        {
            var clientes = Cliente.ListaDeClientes();
            clientes.Add(this);

            if (File.Exists(PastaBaseDeDados()))
            {
               StreamWriter r = new StreamWriter(PastaBaseDeDados());
               string Conteudo = "nome;telefone;cpf;";
                r.WriteLine(Conteudo);
                foreach (Cliente a in clientes)
                {
                    var linha = a.Nome + "; " + a.Telefone + "; " + a.CPF + ";";
                    r.WriteLine(linha);
                }
                r.Close();
                 
            }



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
                        var cliente = new Cliente {

                            Nome = ClienteArquivo[0],
                            Telefone = ClienteArquivo[1],
                            CPF = ClienteArquivo[2],
                                                 
                        };
                        

                        Clientes.Add(cliente);
                    }
                }
            } return Clientes;
        }        
    }
}
