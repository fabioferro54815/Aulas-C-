using System.Collections.Generic;
using CorrecaoWeb.Models;

namespace CorrecaoWeb.ViewModel
{
    public class HomeViewModel
    {
        public List<MarcaModel> Marcas {get;set;}
        public List<ModeloModel> Modelos {get;set;}
    }
}