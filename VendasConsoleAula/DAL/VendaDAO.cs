using System.Collections.Generic;
using VendasConsoleAula.Models;

namespace VendasConsoleAula.DAL
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>();
        public static void Cadastrar(Venda venda) => vendas.Add(venda);
        public static List<Venda> Listar() => vendas;
    }
}