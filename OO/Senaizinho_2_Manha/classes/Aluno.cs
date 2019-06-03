using System;
namespace Senaizinho_2_Manha
{
    public class Aluno
    {
        public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Curso {get; set;}
        public int NumeroSala {get; set;}
        
        /* Construtor padrão */
        //public Aluno(){}

        /* Exemplo de construtor com restrição (parâmetro) */ 
        public Aluno(string nome) {
            this.Nome = nome;
        }
        
        /* Exemplo de construtor alternativo */ 
        // public Aluno(string nome, DateTime dataNascimento) {

        // }

        public void ExibirMenuCurso() {
            System.Console.WriteLine ("===================================");
            System.Console.WriteLine ("||      Escolha o curso:         ||");
            System.Console.WriteLine ("||  1 - DEV                      ||");
            System.Console.WriteLine ("||  2 - REDES                    ||");
            System.Console.WriteLine ("===================================");
            int escolherCurso = int.Parse(Console.ReadLine());
            
            switch(escolherCurso){
                case 1:
                    Curso = "DEV";
                    break;

                case 2:
                    Curso = "REDES";
                    break;

                default:
                    System.Console.WriteLine("Valor ínvalido");
                    break;
            }
        }
    }
}