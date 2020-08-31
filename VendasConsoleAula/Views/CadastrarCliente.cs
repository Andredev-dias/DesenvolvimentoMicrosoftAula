using System;
using VendasConsoleAula.DAL;
using VendasConsoleAula.Models;
using VendasConsoleAula.Utils;

namespace VendasConsoleAula.Views
{
    class CadastrarCliente
    {
        public static void Renderizar()
        {
            Cliente c = new Cliente();
            Console.WriteLine(" ---- CADASTRAR CLIENTE ---- \n");
            Console.WriteLine("Digite o nome do cliente:");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do cliente:");
            c.Cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(c.Cpf))
            {
                if (ClienteDAO.Cadastrar(c))
                {
                    Console.WriteLine("Cliente cadastrado com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("Esse cliente já existe!!!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!!!");
            }
        }
    }
}