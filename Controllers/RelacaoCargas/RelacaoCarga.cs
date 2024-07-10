using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.RelacaoCarga;

public class RelacaoCarga : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Cadastrar()
    {
        return View();
    }
}
