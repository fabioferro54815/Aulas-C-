using System.Collections.Generic;
using System.IO;
using HAMBURGUERIA.Models;

namespace HAMBURGUERIA.Repositorio
{
    public class HamburguerRepositorio
    {
        private const string PATH = "DataBase/Hamburguer.csv";

        private List<Hamburguer> Hamburgueres = new List<Hamburguer>();

        public List<Hamburguer> Listar(){
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores= item.Split(";");
                Hamburguer hamburguer = new Hamburguer();
                hamburguer.Nome = valores[1];
                hamburguer.Preco = double.Parse(valores[2]);

                this.Hamburgueres.Add(hamburguer);
            }
            return this.Hamburgueres;
        }
        public double ObterPrecoDe(string nomeHamburguer){
            var lista = Listar();
            var preco = 0.0;

            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeHamburguer))
                {
                    preco = item.Preco;
                }
            }
            return preco;
        }
    }
}