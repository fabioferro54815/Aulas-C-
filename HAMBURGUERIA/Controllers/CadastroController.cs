using System;
using Hamburgueria.Repositories;
using HAMBURGUERIA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HAMBURGUERIA.Controllers
{
    public class CadastroController : Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";

            return View();
        }

        public IActionResult Cadastrar (IFormCollection form)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereço"];
            cliente.Telefone = form["telefone"];
            cliente.Senha = form["senha"];
            cliente.Email = form["email"];
            cliente.DataDeNascimento = DateTime.Parse(form["data-nascimento"]);

            clienteRepositorio.Inserir(cliente);
            ViewData["Action"] = "Cadastro";

            return View("Sucesso");
        }
    }
}