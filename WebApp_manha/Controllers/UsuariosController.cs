using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebApp_manha.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
   
        public IActionResult Cadastro()
        {
           return View();
        }
    }
}
