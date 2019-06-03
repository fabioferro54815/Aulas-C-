using System;
using Senaizinho.enums;

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
            int limiteAlunos = 1;

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
                            if(limiteAlunos != alunosCadastrados){

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

                                MostrarMensagem($"Cadastro do {aluno.GetType().Name} com sucesso", TipoMensagemEnum.SUCESSO);

                            }else{
                                MostrarMensagem($"\nLimite de {aluno.GetType().Name} atingido", TipoMensagemEnum.ERRO);
                            }
                            
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

                            if(ValidarAlocarOuRemover(alunosCadastrados, salaCadastradas)) {
                                continue;
                            }

                            System.Console.WriteLine("Digite o nome do aluno: ");
                            string nomeAluno = Console.ReadLine();
                            Aluno alunoRecuperado = null;
                            foreach (var item in alunos)
                            {
                                if(item != null && nomeAluno.Equals(item.nome)){
                                   alunoRecuperado = item;
                                   break;
                                }
                            }

                            if (alunoRecuperado == null){

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Aluno {nomeAluno} não encontrado!");
                            Console.ResetColor();

                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }

                        System.Console.WriteLine("Digite o número da sala: ");
                        int numeroSala = int.Parse(Console.ReadLine());

                        Sala salaRecuperada = null;
                        foreach (var item in salas)
                        {
                            if(item != null && numeroSala.Equals(item.numeroSala)){
                                salaRecuperada = item;
                                break;
                            }
                        }

                        if (salaRecuperada == null){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Sala {numeroSala} não encontrada!");
                            Console.ResetColor();

                            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }

                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine(salaRecuperada.Alocar(alunoRecuperado.nome));
                        Console.ResetColor();

                        System.Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();

                        break;

                        case 4:
                            if (alunosCadastrados == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ("Nenhum aluno cadastrado!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        } else if (salaCadastradas == 0) { 
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ("Nenhuma sala cadastrada!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoRemover = Console.ReadLine ();

                        Aluno alunoRemover = null;

                        foreach (Aluno item in alunos) {
                            if (item != null && nomeAlunoRemover.Equals (item.nome)) {
                                alunoRemover = item;
                                break;
                            }
                        }

                        if (alunoRemover == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Aluno {nomeAlunoRemover} não encontrado!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSalaRemover = int.Parse (Console.ReadLine ());

                        // Busca pela Sala correta
                        Sala salaRemover = null;
                        foreach (Sala item in salas) {
                            if (item != null && numeroSalaRemover.Equals (item.numeroSala)) {
                                salaRemover = item;
                                break;
                            }
                        }

                        if (salaRemover == null) {
                            MostrarMensagem($"Sala {numeroSalaRemover} não encontrada!", TipoMensagemEnum.ALERTA);
                            continue;

                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine (salaRemover.Desalocar (alunoRemover.nome));
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();
                        break;
                        
                        case 5:  
                            foreach (var s in salas)
                            {
                                if(s != null){
                                System.Console.WriteLine("-----------------------------------------");
                                System.Console.WriteLine($"Número da sala: {s.numeroSala}");
                                System.Console.WriteLine($"Vaga disponiveis: {s.capacidadeAtual}");
                                System.Console.WriteLine($"Alunos: {s.ExibirAlunos()}");
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
                            MostrarMensagem("Valor ínvalido", TipoMensagemEnum.ERRO);
                        break;

                    }
            }
        }
        static void MostrarMensagem(string mensagem, TipoMensagemEnum tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case TipoMensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }
            System.Console.WriteLine(mensagem);
            Console.ResetColor();

            System.Console.WriteLine("\nAperte ENTER para voltar ao menu principal: ");
            Console.ReadLine();
        }
    
        static bool ValidarAlocarOuRemover(int alunosCadastrados, int salaCadastradas)
        {
            if(alunosCadastrados == 0){
                MostrarMensagem("Não há alunos cadastrados!", TipoMensagemEnum.ALERTA);
                return false;
            }
            if(salaCadastradas == 0){
                MostrarMensagem("Não há salas cadastrados!", TipoMensagemEnum.ALERTA);               
            }
            return true;
        }

        static void ProcurarAlunoPorNome(Aluno[] alunos, string nome) {
            foreach (Aluno item in alunos) {
                if (item != null && nome.Equals (item.nome)) {
                return item;
            }
                return null;
    }
}
