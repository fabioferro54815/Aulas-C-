using System;

namespace Senai.Tsushi.MVC.ViewModel
{
    public class UsuarioViewModel : BaseViewModel     // <=== Vai receber dados da classe "BaseViewModel"//
    {
        public string Email {get;set;}
        public string Senha {get;set;}
    }
}