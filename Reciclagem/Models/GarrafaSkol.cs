using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaSkol : Lixo , IVidro
    {
        public bool AlocarLixo(){
            
            System.Console.WriteLine("O {0} deve ser jogado no lixo verde!",this.GetType().Name);
            return true;
        }
    }
}