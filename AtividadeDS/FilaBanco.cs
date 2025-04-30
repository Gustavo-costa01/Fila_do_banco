using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDS
{
    class Fila
    {
        private string[] fila = new string[10];
        private int count = 0;

        public void CadastrarCliente(string nome)
        {
            if (count < fila.Length)
            {
                fila[count++] = nome;
                Console.WriteLine("Cliente {0} cadastrado com sucesso.", nome);
            }
            else
            {
                Console.WriteLine("Capacidade maxima atigida, não é possível cadastrar mais clientes.");
            }
        }

        public void ListarFila()
        {
            if (count == 0)
            {
                Console.WriteLine("Nenhum cliente na fila.");
            }
            else
            {
                Console.WriteLine("Clientes na fila:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{i + 1}. {fila[i]}");
                }
            }
        }

        public void IncluirClientePrioritario(string nome)
        {
            if (count < fila.Length)
            {
                for (int i = count; i > 0; i--)
                {
                    fila[i] = fila[i - 1];
                }
                fila[0] = nome;
                count++;
                Console.WriteLine("Cliente prioritário {0} adicionado á fila.", nome);
            }
            else
            {
                Console.WriteLine("Fila cheia .");
            }
        }

        public void AtenderCliente()
        {
            if (count == 0)
            {
                Console.WriteLine("Nenhum cliente na fila .");
            }
            else
            {
                Console.WriteLine("Cliente {0} atendido.", fila[0]);
                for (int i = 1; i < count; i++)
                {
                    fila[i - 1] = fila[i];
                }
                fila[--count] = null; 
            }
        }
    }
}
