using System;
using VendasConsoleAula.DAL;
using VendasConsoleAula.Models;

namespace VendasConsoleAula.Views
{
    class ListarVendedors
    {
        public static void Renderizar()
        {
            Console.WriteLine(" ---- LISTAR VENDEDORES ---- \n");
            foreach (Vendedor vendedorCadastrado in VendedorDAO.Listar())
            {
                Console.WriteLine(vendedorCadastrado);
            }
        }
    }
}