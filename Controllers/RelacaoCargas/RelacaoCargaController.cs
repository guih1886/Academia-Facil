using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models.Tipos;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.RelacaoCarga;

public class RelacaoCargaController : Controller
{
    private IRelacaoCargasRepository _relacaoCargasRepository;

    public RelacaoCargaController(IRelacaoCargasRepository relacaoCargasRepository)
    {
        _relacaoCargasRepository = relacaoCargasRepository;
    }

    public IActionResult Index()
    {
        List<RelacaoCargas>? lista = _relacaoCargasRepository.GetRelacaoCargas();
        return View(lista);
    }

    public IActionResult Cadastrar()
    {
        return View();
    }

    public IActionResult Editar()
    {
        return View();
    }

    public IActionResult Deletar(int id)
    {
        RelacaoCargas? relacao = _relacaoCargasRepository.FindById(id);
        if (relacao == null) return NotFound("Relação de carga não encontrado.");
        if (_relacaoCargasRepository.DeleteRelacaoCarga(relacao))
        {
            return RedirectToAction("Index");
        }
        else
        {
            return ValidationProblem("Erro ao excluir a relação de carga.");
        }
    }

    [HttpPost]
    public IActionResult CadastrarRelacaoCarga(RelacaoCargas rel)
    {
        if (ModelState.IsValid)
        {
            _relacaoCargasRepository.CreateRelacaoCargas(rel);
            return RedirectToAction("Index");
        }
        else
        {
            return View("Cadastrar", rel);
        }
    }
}
