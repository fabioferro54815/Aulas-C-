using System.Collections.Generic;
using HAMBURGUERIA.Models;

namespace HAMBURGUERIA.ViewModels
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}

        public List<Shake> Shakes {get;set;}
    }
}