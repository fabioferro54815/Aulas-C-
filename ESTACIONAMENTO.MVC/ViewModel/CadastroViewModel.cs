using System.Collections.Generic;
using ESTACIONAMENTO.MVC.Models;

namespace ESTACIONAMENTO.MVC.ViewModel
{
    public class CadastroViewModel
    {
        public List<Marca> Marcas {get;set;}
        public List<Modelo> Modelos {get;set;}
    }
}