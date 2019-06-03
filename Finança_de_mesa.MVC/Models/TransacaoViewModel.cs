using System;

namespace Finança_de_mesa.MVC.Models
{
    public class TransacaoViewModel : BaseViewModel
    {
        public string TipoDaTransacao {get;set;}
        public string Descricao{get;set;}
        public DateTime DataDaTransacao{get;set;}
        public float Valor{get;set;}
        public int IdUsuario {get;set;}
        public float Saldo {get;set;}
    }
}