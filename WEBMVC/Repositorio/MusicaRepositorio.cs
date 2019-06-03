using System.Collections.Generic;
using WEBMVC.Models;

namespace WEBMVC.Repositorio
{
    public class MusicaRepositorio
    {
        public static List<Musica> musicas = new List<Musica>(){
            new Musica("No Cume", "Brega", "Falcão"),
            new Musica("Juntos e Shallow Now","Meme","Paula Fernandes e Luan Santana"),
            new Musica("Baba Baby","???","Kelly Key"),
            new Musica("Me Libera","Forró","Banda Djavú")
        };
    }
}