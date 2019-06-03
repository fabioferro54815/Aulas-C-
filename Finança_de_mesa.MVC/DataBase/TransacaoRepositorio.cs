using System;
using System.Collections.Generic;
using System.IO;
using Finança_de_mesa.MVC.Models;

namespace Finança_de_mesa.MVC.DataBase
{
    public class TransacaoRepositorio
    {
        public TransacaoViewModel Inserir(TransacaoViewModel transacao){
            int contador = 0;

            List<TransacaoViewModel> listaDeTransacoes = Listar();
            if(listaDeTransacoes != null){
                contador = listaDeTransacoes.Count;
            }
            transacao.Id = contador + 1;
            transacao.DataDaTransacao = DateTime.Now;

            StreamWriter sw = new StreamWriter("CSV's/transacoes.csv", true);
            sw.WriteLine($"{transacao.Id};{transacao.TipoDaTransacao};{transacao.Descricao};{transacao.Valor};{transacao.IdUsuario};{transacao.DataDaTransacao};");
            sw.Close();

            return transacao;

        }
        public static List<TransacaoViewModel> Listar(){
            
            List<TransacaoViewModel> listaDeTransacoes = new List<TransacaoViewModel>();
            TransacaoViewModel transacaoViewModel;
            if(!File.Exists("CSV's/transacoes.csv")){
                return null;
            }

            string[] transacoes = File.ReadAllLines("CSV's/transacoes.csv");

            foreach (var item in transacoes)
            {
                if(item != null){
                    string[] dadosDeCadaTransacao = item.Split(";");
                    transacaoViewModel = new TransacaoViewModel();
                    transacaoViewModel.Id = int.Parse(dadosDeCadaTransacao[0]);
                    transacaoViewModel.TipoDaTransacao = dadosDeCadaTransacao[1];
                    transacaoViewModel.Descricao = dadosDeCadaTransacao[2];
                    transacaoViewModel.Valor = float.Parse(dadosDeCadaTransacao[3]);
                    transacaoViewModel.IdUsuario = int.Parse(dadosDeCadaTransacao[4]);
                    transacaoViewModel.DataDaTransacao = DateTime.Parse(dadosDeCadaTransacao[5]);
                    listaDeTransacoes.Add(transacaoViewModel);

                }
            }
            return listaDeTransacoes;
        }
    }
}