using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class MacaPodre : Lixo , IOrganico
    {
        public bool AlocarLixo(){
            
            System.Console.WriteLine("A {0} deve ser jogado no lixo preto!",this.GetType().Name);
            return true;
        }
    }
}