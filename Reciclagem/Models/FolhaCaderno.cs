using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class FolhaCaderno : Lixo , IPapel
    {
        public bool AlocarLixo(){
            
            System.Console.WriteLine("O {0} deve ser jogado no lixo azul!",this.GetType().Name);
            return true;
        }

        public void EscreverMateriaDaEscola() {

        }
    }
}