using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class LataCoca :Lixo , IMetal
    {
        public bool AlocarLixo(){
            
            System.Console.WriteLine("O {0} deve ser jogado no lixo amarelo!",this.GetType().Name);
            return true;
        }
    }
}