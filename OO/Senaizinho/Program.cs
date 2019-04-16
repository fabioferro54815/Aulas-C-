using System;

namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {

            bool repetir = true;
            Aluno[] alunos = new Aluno[4];
            Sala[] salas = new Sala[4];
            int alunosCadastrados = 0;
            int salaCadastradas = 0;

            while(repetir){

                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine("==========================");
                System.Console.WriteLine("||                      ||");
                System.Console.WriteLine("||      SENAIZINHO      ||");
                System.Console.WriteLine("||                      ||");
                System.Console.WriteLine("==========================");
                Console.ResetColor();

                System.Console.WriteLine("==========================");
                System.Console.WriteLine("||                      ||");
                System.Console.WriteLine("||         MENU         ||");
                System.Console.WriteLine("||                      ||");
                System.Console.WriteLine("|| 1 - Cadastrar Aluno  ||");
                System.Console.WriteLine("|| 2 - Cadastrar Sala   ||");
                System.Console.WriteLine("|| 3 - Alocar Aluno     ||");
                System.Console.WriteLine("|| 4 - Remover Aluno    ||");
                System.Console.WriteLine("|| 5 - Verificar Salas  ||");
                System.Console.WriteLine("|| 6 - Verificar Alunos ||");
                System.Console.WriteLine("|| 0 - Sair             ||");
                System.Console.WriteLine("||                      ||");
                System.Console.WriteLine("==========================");

                int resposta = int.Parse(Console.ReadLine());

                    switch(resposta){
                        case 1:

                            Aluno aluno = new Aluno();

                            System.Console.WriteLine("Digite o Nome do aluno: ");
                            aluno.nome = Console.ReadLine().ToLower();
                            System.Console.WriteLine("Digite a data de nascimento: (dd/mm/aaaa)");
                            aluno.dataNascimento = DateTime.Parse(Console.ReadLine());
                            System.Console.WriteLine("Digite o nome do Curso: ");
                            aluno.curso = Console.ReadLine().ToLower();
                            System.Console.WriteLine("Digite o número da sala: ");
                            aluno.numeroSala = int.Parse(Console.ReadLine());

                            alunos[alunosCadastrados] = aluno;

                            alunosCadastrados++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Cadastro do aluno Realizado com sucesso!");
                            Console.ResetColor();
                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                        break;

                        case 2:

                            Sala sala = new Sala();

                            System.Console.WriteLine("Digite o Número da sala: ");
                            sala.numeroSala = int.Parse(Console.ReadLine());

                            System.Console.WriteLine("Digite a capacidade total da sala : ");
                            sala.capacidadeTotal = int.Parse(Console.ReadLine());

                            sala.capacidadeAtual = sala.capacidadeTotal;

                            sala.alunos = new string[sala.capacidadeTotal];

                            salas[salaCadastradas] = sala;

                            salaCadastradas++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Cadastro da sala Realizado com sucesso!");
                            Console.ResetColor();
                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();

                        break;

                        case 3:
                            
                        break;

                        case 4:

                        break;
                        
                        case 5:  
                            foreach (var s in salas)
                            {
                                if(s != null){
                                System.Console.WriteLine("-----------------------------------------");
                                System.Console.WriteLine($"Número da sala: {s.numeroSala}");
                                System.Console.WriteLine($"Vaga disponiveis: {s.capacidadeAtual}");
                                System.Console.WriteLine("-----------------------------------------");
                                }
                            }
                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                        break;

                        case 6:
                            foreach (var a in alunos)
                            {
                                if(a != null){
                                System.Console.WriteLine("-----------------------------------------");
                                System.Console.WriteLine($"Nome do aluno: {a.nome}");
                                System.Console.WriteLine($"Curso: {a.curso}");
                                System.Console.WriteLine("-----------------------------------------");
                                }
                            }
                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                        break;

                        case 0:
                            System.Console.WriteLine("Encerrando...");
                            repetir = false;
                        break;

                        default:
                            System.Console.WriteLine("Resposta Ínvalida");
                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                        break;

                    }
            }
        }
    }
}
