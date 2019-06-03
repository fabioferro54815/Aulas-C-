using System;

namespace Finança_de_mesa.MVC.Models
{
    public class UsuarioViewModel : BaseViewModel
    {        
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataDeNascimento {get;set;}
    }
}