using System.Collections.Generic;
using System.IO;
using ESTACIONAMENTO.MVC.Models;

namespace ESTACIONAMENTO.MVC.Repositorio
{
    public class MarcaRepositorio
    {
        private const string PATH = "DataBase/Marca.csv";

        private List<Marca> Marcas = new List<Marca>();

        public List<Marca> Listar(){
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores= item.Split(";");
                Marca Marca = new Marca();
                Marca.Nome = valores[0];

                this.Marcas.Add(Marca);
            }
            return this.Marcas;
        }
    }
}