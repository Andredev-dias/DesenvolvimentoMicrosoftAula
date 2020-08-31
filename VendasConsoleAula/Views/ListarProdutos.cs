using System;
using VendasConsoleAula.DAL;
using VendasConsoleAula.Models;

namespace VendasConsoleAula.Views
{
    class ListarProdutos
    {
        public static void Renderizar()
        {
            Console.WriteLine(" ---- LISTAR PRODUTOS ---- \n");
            foreach (Produto produtoCadastrado in ProdutoDAO.Listar())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}