namespace Senaizinho
{
    public class Sala
    {
        public int numeroSala;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;

        public void Alocar(int valor){
           capacidadeTotal -= valor;
       }
    }
}