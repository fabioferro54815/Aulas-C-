using System;
using System.Collections.Generic;
using System.IO;
using ESTACIONAMENTO.MVC.Models;

namespace ESTACIONAMENTO.MVC.Repositorio
{
    public class CadastroRepositorio
    {
        public Cadastro Cadastrar(Cadastro cadastro){
            if (File.Exists("Cadastro.csv")){

            cadastro.Id = File.ReadAllLines("DataBase/Cadastro.csv").Length +1;
            }else{
                cadastro.Id = 1;
            }

            StreamWriter sw = new StreamWriter("DataBase/Cadastro.csv", true);
            sw.WriteLine($"{cadastro.Id};{cadastro.Carro.NomeDono};{cadastro.Carro.Placa};{cadastro.Marca.Nome};{cadastro.Modelo.Nome};{cadastro.DataEntrada}");        
            sw.Close();
            return cadastro;
        }
        public List<Cadastro> listaCadastros(){
            List<Cadastro> listaDeCadastros = new List<Cadastro>();
            
            string[] linhas = File.ReadAllLines("DataBase/Cadastro.csv");
            Cadastro cadastro;
            Carro carro;
            Marca marca;
            Modelo modelo;
            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] linha = item.Split(";");
                cadastro = new Cadastro(
                    id: int.Parse(linha[0]),
                    dataEntrada: DateTime.Parse(linha[5])
                );

                carro = new Carro(
                    nomeDono: linha[1],
                    placa: linha[2]
                );

                marca = new Marca(
                    nome: linha[3]
                );

                modelo = new Modelo(
                    nome: linha[4]
                );

                cadastro.Carro = carro;

                cadastro.Marca = marca;
                
                cadastro.Modelo = modelo;

                listaDeCadastros.Add(cadastro);
            }
            return listaDeCadastros;
        }

        public Cadastro BuscarPorData(DateTime dataEntrada){

            string[] linhas = File.ReadAllLines("DataBase/Cadastro.csv");
        
            
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                if (dataEntrada.ToString().Equals(linha[5]))
                {
                    Cadastro cadastro = new Cadastro(
                        id: int.Parse(linha[0]),
                        dataEntrada: DateTime.Parse(linha[5])
                    );

                    Carro carro = new Carro(
                    nomeDono: linha[1],
                    placa: linha[2]
                    );
                    Marca marca = new Marca(
                    nome: linha[3]
                    );

                    Modelo modelo = new Modelo(
                        nome: linha[4]
                    );

                    cadastro.Carro = carro;
                    
                    cadastro.Marca = marca;

                    cadastro.Modelo = modelo;

                    return cadastro;
                }
            }
            return null;        
        }
    }
}