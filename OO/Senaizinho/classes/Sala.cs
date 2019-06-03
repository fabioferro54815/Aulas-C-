using System;
namespace Senaizinho
{
    public class Sala
    {
        public int numeroSala;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;

        public string Alocar(string nomeAluno){
            capacidadeAtual--;
            if(capacidadeAtual >= 0){
            alunos[capacidadeAtual] += nomeAluno;
            return $"Aluno {nomeAluno} alocado com sucesso!";
            }else{
            capacidadeAtual = 0;
            return $"Capacidade da sala {numeroSala} excedida";
            }
       }
        public string ExibirAlunos(){
            string nomeAlunos ="";
            foreach (var item in alunos)
            {
                if(item != null){
                    nomeAlunos += item + " ";
                }   
            }
            return nomeAlunos;
        }
        public string Desalocar(string nomeAluno){
           for(int i = 0; i < alunos.Length; i++){
            if(alunos[i] != null && nomeAluno.Equals (alunos[i])){
                alunos[i] = "";
                capacidadeAtual++;
                return $"{nomeAluno} Removido com sucesso";
            }
           }
           return $"{nomeAluno} não encontrado!";
        }
    }
}