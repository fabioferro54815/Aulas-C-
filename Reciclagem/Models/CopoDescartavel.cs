using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CopoDescartavel : Lixo , IPlastico 
    {
        public bool AlocarLixo(){
            System.Console.WriteLine("O {0} deve ser jogado no lixo vermelho!",this.GetType().Name);
            return true;
        }
    }
}