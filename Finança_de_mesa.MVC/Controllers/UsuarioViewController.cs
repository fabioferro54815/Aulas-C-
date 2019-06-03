using System;
using System.Collections.Generic;
using Finança_de_mesa.MVC.DataBase;
using Finança_de_mesa.MVC.Models;
using Finança_de_mesa.MVC.Utils;
using Spire.Doc;
using Spire.Doc.Documents;

namespace Finança_de_mesa.MVC.Controllers
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha, data;
            DateTime dataDeNascimento;

            do
            {
                System.Console.WriteLine("Digite o Nome do Usuário: ");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome))
                {
                    System.Console.WriteLine("Nome Inválido!");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Digite o E-mail do Usuário: ");
                email = Console.ReadLine();
                if(!ValidacaoUtil.ValidarEmail(email))
                {
                   System.Console.WriteLine("E-mail inválido!");
                   System.Console.WriteLine("O e-mail deve conter @ e ."); 
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                System.Console.WriteLine("Digite a Senha do Usuário: ");
                senha = Console.ReadLine();
                System.Console.WriteLine("Digite a senha novamente: ");
                confirmaSenha = Console.ReadLine();
                if(!ValidacaoUtil.ValidarSenha(senha , confirmaSenha))
                {
                    System.Console.WriteLine("As senhas não são iguais!");
                }
            } while (!ValidacaoUtil.ValidarSenha(senha, confirmaSenha));

            int i = 0;
            do
            {
                if (i > 0)
                {
                    System.Console.WriteLine("Digite uma data válida");
                }
                System.Console.WriteLine("Digite a data de nascimento do usuário: (DD/MM)");
                data = Console.ReadLine();
                i++;
                
            } while (!DateTime.TryParse(data, out dataDeNascimento));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.DataDeNascimento = dataDeNascimento;

            usuarioRepositorio.Inserir(usuarioViewModel);

            System.Console.WriteLine("Cadastro Realizado com sucesso!");

        }

        public static void ListarUsuario()
        {
            List<UsuarioViewModel> listaDeUsuarios = UsuarioRepositorio.Listar();
            foreach (var item in listaDeUsuarios)
            {
                System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} - Data de Criação: {item.DataDeNascimento}");
            }
        }

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;
            do
            {
                System.Console.WriteLine("Insira o email:");
                email = Console.ReadLine();
                if(!ValidacaoUtil.ValidarEmail(email)){
                    System.Console.WriteLine("Email inváido");
                }
            }while (!ValidacaoUtil.ValidarEmail(email));

            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email,senha);

            if(usuarioRecuperado != null){
                return usuarioRecuperado;
            }else{
                System.Console.WriteLine("e-mail ou senha incorretos");
                return null;
            }
        } 
            public static void UsersWord(){
                Document doc = new Document();
                List<UsuarioViewModel> listaDeUsuarios = UsuarioRepositorio.Listar();

                //adicionando sessão
                Section titulo = doc.AddSection();

                //adicionando paragrafo
                Paragraph Para = titulo.AddParagraph();
                Para.AppendText ($"");

                Para.Text = "Listagem dos usuarios:";

                foreach (var item in listaDeUsuarios)
                {
                    Para.AppendText($"\n--------------------------------------------");
                    Para.AppendText($"\nId: {item.Id}");
                    Para.AppendText($"\nNome: {item.Nome}");
                    Para.AppendText($"\nEmail: {item.Email}");
                    Para.AppendText($"\nData de nascimento: {item.DataDeNascimento}");
                    Para.AppendText($"\n--------------------------------------------");
                }

                //salvando word
                doc.SaveToFile("Listagem_dos_usuarios.docx", FileFormat.Docx);
            }

            public static void UsersTrans(UsuarioViewModel usuario){
            float credito = 0, debito = 0, saldoTotal = 0;

            List<TransacaoViewModel> listaDeTransacoes = TransacaoRepositorio.Listar();
                

                if(listaDeTransacoes != null){
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
                    
                    Document doc = new Document ();
                    Section section = doc.AddSection ();
                    Paragraph Para = section.AddParagraph ();
                    Paragraph Titulo = section.AddParagraph ();

                    Titulo.Text = $"LISTAGEM DAS TRANSAÇÕES DO USUÁRIO: {usuario.Nome}\n\n\n";
                    Titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    Para.AppendText ($"\nUsuário: {usuario.Id}                                                        ");
                    Para.AppendText ($"\nNome do Usuário:   {usuario.Nome}");
                    Para.AppendText ($"\nE-mail do Usuário:  {usuario.Email}");
                    Para.AppendText ($"\nData de Nascimento do Usuário:   {usuario.DataDeNascimento}\n");
                    Para.AppendText ($"\nTRANSAÇÕES:\n\n");
                    foreach (var item in listaDeTransacoes) {
                    if (item != null) {
                    if (item.IdUsuario.Equals (usuario.Id)) {
                        Para.AppendText ($"---------------------------------------------------------------------------------------------------------------------------\n");
                        Para.AppendText ($"Id do Usuário:                                                       {item.IdUsuario}\n");
                        Para.AppendText ($"Tipo:                                                                  {item.TipoDaTransacao}\n");
                        Para.AppendText ($"Descrição:                                                          {item.Descricao}\n");
                        Para.AppendText ($"Valor:                                                                 R$ {item.Valor}\n");
                        Para.AppendText ($"Data da Transação:                                            {item.DataDaTransacao}\n");
                        Para.AppendText ($"---------------------------------------------------------------------------------------------------------------------------\n\n");
                    }
                }
            }

            Para.AppendText ($"Saldo Disponível:     R${saldoTotal}\n");
            Para.AppendText ($"---------------------------------------------------------------------------------------------------------------------------\n\n");
            doc.SaveToFile ($"RelatórioDasTransaçõesDoUsuário{usuario.Nome}.docx", FileFormat.Docx);
            
            }else{
                System.Console.WriteLine("Não há nehuma transação registrada!");
            }    
        }
    }
}