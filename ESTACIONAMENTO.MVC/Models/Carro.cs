namespace ESTACIONAMENTO.MVC.Models
{
    public class Carro
    {
        public string NomeDono {get;set;}
        public string Placa {get;set;}

        public Carro (string nomeDono, string placa){
            this.NomeDono = nomeDono;
            this.Placa = placa;
        }
        public Carro(){
            
        }

    }
}