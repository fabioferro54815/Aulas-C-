namespace WEBMVC.Models
{
    public class Musica
    {
        public string Titulo{get;set;}
        public string Estilo{get;set;}
        public string Compositor{get;set;}

        public Musica()
        {

        }

        public Musica(string titulo, string estilo, string compositor)
        {
            this.Titulo = titulo;
            this.Estilo = estilo;
            this.Compositor = compositor;
        }
    }
}