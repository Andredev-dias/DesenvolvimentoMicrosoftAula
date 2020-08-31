using System;
using VendasConsoleAula.DAL;
using VendasConsoleAula.Models;

namespace VendasConsoleAula.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine(" ---- LISTAR CLIENTES ---- \n");
            foreach (Cliente clienteCadastrado in ClienteDAO.Listar())
            {
                Console.WriteLine(clienteCadastrado);
            }
        }
    }
}