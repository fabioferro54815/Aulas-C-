using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class FitaAdesiva : Lixo , INaoReciclavel
    {
        public bool AlocarLixo(){
            
            System.Console.WriteLine("O {0} deve ser jogado no lixo cinza!",this.GetType().Name);
            return true;
        }
    }
}