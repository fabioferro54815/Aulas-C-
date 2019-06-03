using System;

namespace DesafioPizzaria
{
    public class Produto
    {
        static Produto[] arrayDeProduto = new Produto[1000];
        static int contador = 0;
        int Id {get; set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public double Preço {get; set;}
        public string Categoria {get; set;}
        public DateTime DataCriacao {get; set;}

        public static void Cadastrar() {
            string nome;
            string descrição;
            double preço;
            string categoria;

            System.Console.WriteLine("Digite o nome do produto: ");
            nome = Console.ReadLine();

            System.Console.WriteLine("Digite a descrição do produto: ");
            descrição = Console.ReadLine();

            System.Console.WriteLine("Digite o preço do produto: ");
            preço = double.Parse(Console.ReadLine());

            do{
                System.Console.WriteLine("Digite a categoria do produto");
                System.Console.WriteLine("Escolha entre (Pizza ou Bebida): ");
                categoria = Console.ReadLine().ToLower();
                if(categoria.Equals("pizza") || categoria.Equals("bebida")){
                    break;
                }if(!categoria.Contains("pizza") || !categoria.Contains("bebida")){
                    System.Console.WriteLine("Categoria ínvalida");
                }
            }while(!categoria.Contains("pizza") || !categoria.Contains("bebida"));

            arrayDeProduto[contador] = new Produto();
            arrayDeProduto[contador].Id = contador +1;
            arrayDeProduto[contador].Nome = nome;
            arrayDeProduto[contador].Descricao = descrição;
            arrayDeProduto[contador].Preço = preço;
            arrayDeProduto[contador].Categoria = categoria;
            arrayDeProduto[contador].DataCriacao = DateTime.Now;
            contador++;

        }
        public static void listarProduto() {
            foreach (var item in arrayDeProduto)
            {
                if(item == null){
                    break;
                }
                System.Console.WriteLine($"ID: {item.Id}");
                System.Console.WriteLine($"Nome: {item.Nome}");
                System.Console.WriteLine($"Preço: {item.Preço}");
            }
        }
        public static void BuscarId() {
            int id;

            System.Console.WriteLine("Digite o ID do produto: ");
            id = int.Parse(Console.ReadLine());
            foreach (var item in arrayDeProduto)
            {
                if(item != null){
                    if(id.Equals(item.Id)){
                        System.Console.WriteLine($"ID: {item.Id}");
                        System.Console.WriteLine($"Nome: {item.Nome}");
                        System.Console.WriteLine($"Descrição: {item.Descricao}");
                        System.Console.WriteLine($"Categoria: {item.Categoria}");
                        System.Console.WriteLine($"Preço: {item.Preço}");
                        System.Console.WriteLine($"Data: {item.DataCriacao}");
                    }else{
                        System.Console.WriteLine("Produto não cadastrado!");
                        break;
                    }
                }
            }
        }
    }
}