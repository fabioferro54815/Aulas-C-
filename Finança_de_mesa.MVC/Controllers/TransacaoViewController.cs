using System;
using System.Collections.Generic;
using Finança_de_mesa.MVC.DataBase;
using Finança_de_mesa.MVC.Models;

namespace Finança_de_mesa.MVC.Controllers
{
    public class TransacaoViewController
    {
        static TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio();

        public static void RealizarTransacao(UsuarioViewModel usuario){
            string tipoDaTransacao = "", descricao;
            float valor;

            int codigo;
            bool escolha= false;
            do
            {
                System.Console.WriteLine("Escolha o tipo de transação: ");
                System.Console.WriteLine("      1 - Credito            ");
                System.Console.WriteLine("      2 - Debito             ");
                codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        tipoDaTransacao = "Credito";
                        escolha = true;
                    break;

                    case 2:
                        tipoDaTransacao = "Debito";
                        escolha = true;
                    break;

                    default:
                        System.Console.WriteLine("Valor Inválido!");
                        escolha = false;
                    break;
                }

            } while (!escolha);

            System.Console.WriteLine("Descreva a transação: ");
            descricao = Console.ReadLine();

        
            System.Console.WriteLine("Digite o valor da transação: ");
            valor = float.Parse(Console.ReadLine());
                
            TransacaoViewModel transacaoViewModel = new TransacaoViewModel();
            transacaoViewModel.TipoDaTransacao = tipoDaTransacao;
            transacaoViewModel.Descricao = descricao;
            transacaoViewModel.Valor = valor;
            transacaoViewModel.IdUsuario = usuario.Id;

            transacaoRepositorio.Inserir(transacaoViewModel);
        }

        public static void ListarTransacao(UsuarioViewModel usuario)
        {

            List<TransacaoViewModel> listaDeTransacoes = TransacaoRepositorio.Listar();

                foreach (var item in listaDeTransacoes)
                {
                    if(item.IdUsuario.Equals(usuario.Id)){
                        
                        if(item != null){
                            System.Console.WriteLine($"Id: {item.Id} \nTipo Da Transação: {item.TipoDaTransacao} \nDescrição: {item.Descricao} \nValor: {item.Valor} \nId do Usuário: {item.IdUsuario} \nData da transação: {item.DataDaTransacao}");
                        
                        }else{
                            System.Console.WriteLine("Nenhuma transação no sistema!");
                    }
                }
            }
        }

        public static void ListarExtrato(UsuarioViewModel usuario)
        {
            float credito = 0, debito = 0, saldoTotal = 0;

            List<TransacaoViewModel> listaDeTransacoes = TransacaoRepositorio.Listar();

                foreach (var item in listaDeTransacoes)
                {
                    if(item.IdUsuario.Equals(usuario.Id)){
                        
                        if(item != null){
                            if(item.TipoDaTransacao.Equals("Credito")){
                                credito = item.Valor + credito;

                            }if(item.TipoDaTransacao.Equals("Debito")){
                                debito = item.Valor + debito;
                            }
                            saldoTotal = credito - debito;
                        }
                    }
                }
                            System.Console.WriteLine($"Saldo Total: {saldoTotal}");
            }
        }
    }
