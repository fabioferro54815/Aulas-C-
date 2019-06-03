using System;

namespace ESTACIONAMENTO.MVC.Models
{
    public class Cadastro
    {
        public int Id {get;set;}
        public Carro Carro {get;set;}
        public Marca Marca {get;set;}
        public Modelo Modelo {get;set;}
        public DateTime DataEntrada {get;set;}

        public Cadastro (int id , DateTime dataEntrada) {
            this.Id = id;
            this.DataEntrada = dataEntrada;
        }
        public Cadastro () {
         
        }
        


    }
}