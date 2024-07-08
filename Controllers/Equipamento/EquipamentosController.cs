using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.Equipamentos;

public class EquipamentosController : Controller
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
