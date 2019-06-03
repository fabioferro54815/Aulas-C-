using System;
using ESTACIONAMENTO.MVC.Models;
using ESTACIONAMENTO.MVC.Repositorio;
using ESTACIONAMENTO.MVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ESTACIONAMENTO.MVC.Controllers
{
    public class CadastroController : Controller 
    {
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            var marcas = marcaRepositorio.Listar();
            var modelos = modeloRepositorio.Listar();

            CadastroViewModel cadastro = new CadastroViewModel();
            cadastro.Marcas = marcas;
            cadastro.Modelos = modelos;
            return View(cadastro);
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form){
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["placa"]);
            System.Console.WriteLine(form["marca"]);
            System.Console.WriteLine(form["modelo"]);

            Cadastro cadastro = new Cadastro();

            Carro carro = new Carro();
            carro.NomeDono = form["nome"];
            carro.Placa = form["placa"];

            cadastro.Carro = carro;
            
            Marca marca = new Marca(){
                Nome = form["marca"]
            };

            cadastro.Marca = marca;

            Modelo modelo = new Modelo(){
                Nome = form["modelo"]
            };

            cadastro.Modelo = modelo;

            cadastro.DataEntrada = DateTime.Now;

                ViewData["Controller"] ="Cadastro";

                cadastroRepositorio.Cadastrar(cadastro);

            return RedirectToAction("Listar", "Cadastro");
        }

        [HttpGet]
        public IActionResult Listar(){
            CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();
            ViewData["Cadastro"] = cadastroRepositorio.listaCadastros();

            return View();
        
        }

        public BuscarData (IFormCollection form){
            string data;
            CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();
            Cadastro cadastro = new Cadastro();

            System.Console.WriteLine(form["dataentrada"]);

            cadastro.DataEntrada = DateTime.Parse(data);
            data = form["dataentrada"];
            

            if(form["dataentrada"].Equals(cadastro.DataEntrada)){
                cadastroRepositorio.BuscarPorData(data);
            }
        }
    }
}