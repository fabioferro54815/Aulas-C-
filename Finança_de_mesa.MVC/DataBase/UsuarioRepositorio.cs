using System;
using System.Collections.Generic;
using System.IO;
using Finança_de_mesa.MVC.Models;

namespace Finança_de_mesa.MVC.DataBase
{
    public class UsuarioRepositorio
    {
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            int contador = 0;

            List<UsuarioViewModel> listaDeUsuarios = Listar();
            if(listaDeUsuarios != null){
                contador = listaDeUsuarios.Count;
            }
            usuario.Id = contador + 1;

            StreamWriter sw = new StreamWriter("CSV's/usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataDeNascimento};");
            sw.Close();

            return usuario;

        }

        public static List<UsuarioViewModel> Listar(){
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuarioViewModel;
                if(!File.Exists("CSV's/usuarios.csv")){
                    return null;
                }
                string[] usuarios = File.ReadAllLines("CSV's/usuarios.csv");

                foreach (var item in usuarios)
                {
                    if(item != null){
                        string[] dadosDeCadaUsuario = item.Split(";");
                        usuarioViewModel = new UsuarioViewModel();
                        usuarioViewModel.Id = int.Parse(dadosDeCadaUsuario[0]);
                        usuarioViewModel.Nome = dadosDeCadaUsuario[1];
                        usuarioViewModel.Email = dadosDeCadaUsuario[2];
                        usuarioViewModel.Senha = dadosDeCadaUsuario[3];
                        usuarioViewModel.DataDeNascimento = DateTime.Parse(dadosDeCadaUsuario[4]);
                        listaDeUsuarios.Add(usuarioViewModel);
                    }
                }
                return listaDeUsuarios;
        }

        public UsuarioViewModel BuscarUsuario(string email, string senha)
        {
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            
            foreach (var item in listaDeUsuarios)
            {
                if(item.Email.Equals(email) && item.Senha.Equals(senha)){
                    return item;
                }
            }
            return null;
        }
            
    }
}