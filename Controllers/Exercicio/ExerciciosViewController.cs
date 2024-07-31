using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.Exercicios;

public class ExerciciosViewController : Controller
{
    private IEquipamentoRepository _equipamentoRepository;
    private ITipoExercicioRepository _tipoExercicioRepository;
    private IExercicioRepository _exercicioRepository;

    public ExerciciosViewController(IEquipamentoRepository equipamentoRepository, ITipoExercicioRepository tipoExercicioRepository, IExercicioRepository exercicioRepository)
    {
        _equipamentoRepository = equipamentoRepository;
        _tipoExercicioRepository = tipoExercicioRepository;
        _exercicioRepository = exercicioRepository;
    }

    public IActionResult Index()
    {
        List<Exercicio> lista = new List<Exercicio>();
        return View(lista);
    }

    public IActionResult Cadastrar()
    {
        PreencheViewBag();
        return View();
    }

    [HttpPost]
    public IActionResult CadastrarExercicio(Exercicio exercicio)
    {
        if (ModelState.IsValid)
        {
            _exercicioRepository.CadastrarExercicio(exercicio);
            return RedirectToAction("Index");
        }
        else
        {
            PreencheViewBag();
            return View("Cadastrar", exercicio);
        }

    }

    private dynamic PreencheViewBag()
    {
        ViewBag.TiposExercicios = _tipoExercicioRepository.ListaTiposExercicio().Where(te => te.Ativo == true).ToList();
        ViewBag.Equipamentos = _equipamentoRepository.GetEquipamentos().Where(equip => equip.Ativo == true).ToList();
        return ViewBag;
    }
}