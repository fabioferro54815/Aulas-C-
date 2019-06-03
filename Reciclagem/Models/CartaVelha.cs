using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CartaVelha : IPapel
    {
        public bool AlocarLixo()
        {
            System.Console.WriteLine("Carta Velha foi jogada");
            return true;
        }
    }
}