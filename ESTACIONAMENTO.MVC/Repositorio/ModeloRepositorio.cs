using System.Collections.Generic;
using System.IO;
using ESTACIONAMENTO.MVC.Models;

namespace ESTACIONAMENTO.MVC.Repositorio
{
    public class ModeloRepositorio
    {
        private const string PATH = "DataBase/Modelo.csv";

        private List<Modelo> Modelos = new List<Modelo>();

        public List<Modelo> Listar(){
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores= item.Split(";");
                Modelo modelo = new Modelo();
                modelo.Nome = valores[0];

                this.Modelos.Add(modelo);
            }
            return this.Modelos;
        }
    }
}