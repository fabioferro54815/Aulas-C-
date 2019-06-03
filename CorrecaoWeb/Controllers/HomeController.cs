using CorrecaoWeb.Repositorio;
using CorrecaoWeb.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorrecaoWeb.Controllers
{
    public class HomeController : Controller
    {
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();


        [HttpGet]
        public IActionResult Index() {
        
            HomeViewModel homeViewModel = new HomeViewModel();

            homeViewModel.Marcas = marcaRepositorio.Listar();
            homeViewModel.Modelos = modeloRepositorio.Listar();

            // ViewData["marcas"] = listaDeMarcas

            return View(homeViewModel);
        }
        [HttpPost]

        public IActionResult RegistarEntrada (IFormCollection form){
            
            return View();
        }
    }
}