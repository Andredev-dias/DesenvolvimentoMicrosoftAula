using System;

namespace VendasConsoleAula
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c = new Cliente();
            //Lista de clientes
            do
            {
                Console.Clear();
                Console.WriteLine(" ---- APLICAÇÃO DE VENDAS ---- \n");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:

                        Console.WriteLine(" ---- CADASTRAR CLIENTE ---- \n");

                        Console.WriteLine("Digite o nome do cliente:");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente:");
                        c.Cpf = Console.ReadLine();

                        //Mensagem de sucesso
                        Console.WriteLine($"Nome: {c.Nome}\ne CPF: {c.Cpf}");
                        break;
                    case 2:
                        Console.WriteLine("LISTAR CLIENTES \n");
                        //Laço de repetição para mostrar todos os clientes
                        break;
                    case 0:
                        Console.WriteLine("SAINDO... \n");
                        break;
                    default:
                        Console.WriteLine("***********opção invãlida*********** \n");
                        break;
                }
                Console.WriteLine("\nPresiione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}