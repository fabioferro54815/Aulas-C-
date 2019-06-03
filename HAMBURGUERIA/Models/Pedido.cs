using System;

namespace HAMBURGUERIA.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}

        public double PrecoTotal {get;set;}

        public Cliente Cliente {get;set;}

        public Hamburguer Hamburguer {get;set;}

        public Shake Shake {get;set;}

        public DateTime DataPedido {get;set;}
    }
}