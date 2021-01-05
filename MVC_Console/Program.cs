using System;
using MVC_Console.Controllers;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Buscar("200,56");
        }
    }
}
