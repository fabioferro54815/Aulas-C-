using System;

namespace HAMBURGUERIA.Models
{
    public class Cliente
    {
        public ulong Id {get;set;} 

        public string Nome {get;set;}
        public string Senha {get;set;}

        public string Endereco {get;set;}

        public string Telefone {get;set;}

        public string Email {get;set;}

        public DateTime DataDeNascimento {get;set;}

    }
}