using System.Collections.Generic;
using System.IO;
using CorrecaoWeb.Models;

namespace CorrecaoWeb.Repositorio
{
    public class ModeloRepositorio
    {
          private string PATH = "DataBase/Modelo.csv";

        public List<ModeloModel> listaDeModelos = new List<ModeloModel>();

        public List<ModeloModel> Listar(){
            
            string[] modelos = File.ReadAllLines(PATH);

            foreach (var item in modelos)
            {
                if(item != null){

                    string[] dados = item.Split(";");
                    var modelo = new ModeloModel();
                    modelo.Id = int.Parse(dados[0]);
                    modelo.Nome = dados [1];

                    listaDeModelos.Add(modelo);
                }
            }
            
            return listaDeModelos;
        }
    }
}