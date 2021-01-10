using System;
using MVC_Console.Controllers;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos nosso Controller
            ProdutoController produtoController = new ProdutoController();


            produtoController.Cadastrar();
            produtoController.MostrarProdutos();
        }
    }
}
