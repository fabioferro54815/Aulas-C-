using Microsoft.AspNetCore.Mvc;
using WEBMVC.Models;
using WEBMVC.Repositorio;

namespace WEBMVC.Controllers
{
    public class MusicaController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string nome)
        {

            ViewData["Mensagem"] = "Olá " + nome + " estas são suas músicas";
            var musica =MusicaRepositorio.musicas[0];
            
            return View(MusicaRepositorio.musicas);
        }
    }
}