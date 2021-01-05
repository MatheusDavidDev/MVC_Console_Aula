using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel1 = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            List<Produto> lista = produtoModel1.Ler();
            produtoView.MostrarNoConsole(lista);
        }

        public void Buscar(string termo)
        {
            List<Produto> lista = produtoModel1.Ler().FindAll(x => x.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista); 
        }
        
    }
}