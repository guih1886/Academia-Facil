using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models.Tipos;
using AcademiaFacil.Models.View;
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

    public IActionResult Editar(int id)
    {
        RelacaoCargas? relacao = _relacaoCargasRepository.FindById(id);
        return View(relacao);
    }

    public IActionResult EditarRelacaoCarga(int id, RelacaoCargas rel)
    {
        if (ModelState.IsValid)
        {
            _relacaoCargasRepository.UpdateRelacaoCarga(id, rel);
            return RedirectToAction("Index");
        }
        else
        {
            return View("Editar", rel);
        }

    }

    public IActionResult Deletar(int id)
    {
        RelacaoCargas? relacao = _relacaoCargasRepository.FindById(id);
        if (relacao == null) return NotFound("Relação de carga não encontrado.");
        try
        {
            _relacaoCargasRepository.DeleteRelacaoCarga(relacao);
            return RedirectToAction("Index");
        }
        catch (Exception)
        {
            ErrorModel errorModel = new ErrorModel("400", "Não é possível excluir a relação de carga, ao menos um equipamento está a utilizando. Exclua o(s) equipamento(s) antes.", "https://thumbs.dreamstime.com/b/error-rubber-stamp-word-error-inside-illustration-109026446.jpg");
            return View("Error", errorModel);
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
