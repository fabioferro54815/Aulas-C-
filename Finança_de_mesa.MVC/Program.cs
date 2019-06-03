using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Reflection.Metadata;
using Finança_de_mesa.MVC.Controllers;
using Finança_de_mesa.MVC.DataBase;
using Finança_de_mesa.MVC.Models;
using Finança_de_mesa.MVC.Utils;
using static System.Collections.Specialized.BitVector32;

namespace Finança_de_mesa.MVC
{    
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            bool deslogar = false;
            do
            {
                MenuUtil.MenuDeslogado();
                int codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        UsuarioViewController.CadastrarUsuario();
                    break;

                    case 2:
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                        if(usuarioRecuperado != null){
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkRed;  
                        System.Console.WriteLine($"   Seja bem-vindo(a) {usuarioRecuperado.Nome}   ");
                        Console.ResetColor ();
                        System.Console.WriteLine(" ");
                        do
                        {
                        MenuUtil.MenuLogado();
                        int caodigo = int.Parse(Console.ReadLine());

                        switch (caodigo)
                        {
                           case 1:
                                TransacaoViewController.RealizarTransacao(usuarioRecuperado);
                           break;

                           case 2:
                                TransacaoViewController.ListarTransacao(usuarioRecuperado);
                           break;

                           case 3:
                                TransacaoViewController.ListarExtrato(usuarioRecuperado);
                           break;

                           case 4:
                                UsuarioViewController.UsersWord();
                                System.Console.WriteLine("Exportado com sucesso!");
                           break;

                           case 5:
                                UsuarioViewController.UsersTrans(usuarioRecuperado);
                                System.Console.WriteLine("Exportado com sucesso!");
                           break;

                           case 6:
                                Zip();
                                System.Console.WriteLine("Arquivos Zipados com sucesso!");
                           break;

                           case 7:
                                deslogar = true;
                           break;

                           case 0:
                                deslogar = true;
                                sair = true;
                           break; 
                            
                        }
                            
                        } while (!deslogar);

                        }

                    break;

                    case 3:
                        UsuarioViewController.ListarUsuario();
                    break;

                    case 0:
                        sair = true;
                    break;
                    default:
                        System.Console.WriteLine("Valor Inválido! Tente Novamente");
                    break;
                }
            } while (!sair);
        }
        static void Zip()
    {
        string startPath = @".\CSV's";
        string zipPath = @".\zipado.zip";
        
        ZipFile.CreateFromDirectory(startPath, zipPath);
    }
    }
}