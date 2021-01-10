using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MVC_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            
            string pasta = PATH.Split('/')[0];

            // Verificamos se a pasta nao existe e  criamos nesta condicao
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Verificamos se o arquivo Produto.csv existe, caso nao vamos cria-lo

            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public List<Produto> Ler()
        {
            
            List<Produto> produtos = new List<Produto>();

            //Pegar as informacoes do csv
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                // Separar atributos pelo ;
                string[] atributos = item.Split(";");

                // Criamos um produto vazio para poder colocar na lista de produtos
                Produto prod = new Produto();

                prod.Codigo  = int.Parse( atributos[0] );
                prod.Nome    = atributos[1];
                prod.Preco   = float.Parse( atributos[2] );

                produtos.Add(prod);
            }

            return produtos;
        }
        public void Inserir(Produto p)
        {
            // Preparamos um array de String para metodo AppendAllLines
            string[] linhas = { PrepararLinhasCSV(p) };

            //Inserimos o arraY de linhas no arquivo CSV
            File.AppendAllLines(PATH, linhas);
        }
        public string PrepararLinhasCSV(Produto prod)
        {
            // Preparamos a linja para o formato do CSV
            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }

        
        
        
        
    }
}