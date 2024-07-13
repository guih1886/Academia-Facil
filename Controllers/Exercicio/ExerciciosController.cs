using AcademiaFacil.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.Exercicios;

public class ExerciciosController : Controller
{
    public IActionResult Index()
    {
        List<Exercicio> lista = new List<Exercicio>();
        return View(lista);
    }

    public IActionResult Cadastrar()
    {
        return View();
    }
}
