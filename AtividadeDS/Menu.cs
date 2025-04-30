using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDS
{
    class Menu
    {
        private Fila fila = new Fila();

        public void ExibirMenu()
        {
            string opcao;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar fila de clientes");
                Console.WriteLine("3 - Incluir cliente prioritário");
                Console.WriteLine("4 - Atender cliente");
                Console.WriteLine("q - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    
                        Console.Write("Digite o nome do cliente: ");
                        string nome = Console.ReadLine();
                        fila.CadastrarCliente(nome);
                        break;
                    case "2":
                        fila.ListarFila();
                        break;
                    case "3":
                        Console.Write("Digite o nome do cliente prioritário: ");
                        string prioritario = Console.ReadLine();
                        fila.IncluirClientePrioritario(prioritario);
                        break;
                    case "4":
                        fila.AtenderCliente();
                        break;
                    case "q":
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            } while (opcao != "q");
        }
    }
}
