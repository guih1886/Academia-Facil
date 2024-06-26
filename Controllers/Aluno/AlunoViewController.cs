using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.Aluno
{
    public class AlunoViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}