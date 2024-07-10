using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models;
using AcademiaFacil.Models.Tipos;
using AcademiaFacil.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.Equipamentos;

public class EquipamentosController : Controller
{
    private IEquipamentoRepository _equipamentoRepository;
    private IRelacaoCargasRepository _relacaoCargasRepository;

    public EquipamentosController(IEquipamentoRepository equipamentoRepository, IRelacaoCargasRepository relacaoCargasRepository)
    {
        _equipamentoRepository = equipamentoRepository;
        _relacaoCargasRepository = relacaoCargasRepository;
    }

    public IActionResult Index()
    {
        List<Equipamento> equipamentos = _equipamentoRepository.GetEquipamentos();
        return View(equipamentos);
    }

    public IActionResult Cadastro()
    {
        List<RelacaoCargas>? listaRelacaoCargas = _relacaoCargasRepository.GetRelacaoCargas();
        EquipamentoViewModel equipamentoViewModel = new EquipamentoViewModel(new Equipamento(), listaRelacaoCargas);
        return View(equipamentoViewModel);
    }

    public IActionResult Editar(int id)
    {
        Equipamento? equipamento = _equipamentoRepository.FindById(id);
        if (equipamento == null) return NotFound("Equipamento não encontrado.");
        return View(equipamento);
    }

    public IActionResult Deletar(int id)
    {
        Equipamento? equipamento = _equipamentoRepository.FindById(id);
        if (equipamento == null) return NotFound("Equipamento não encontrado.");
        if (_equipamentoRepository.DeleteEquipamento(equipamento))
        {
            return RedirectToAction("Index");
        }
        else
        {
            return ValidationProblem("Erro ao excluir o equipamento.");
        }
    }

    public IActionResult EditarEquipamento(int id, Equipamento equipamento)
    {
        if (ModelState.IsValid)
        {
            _equipamentoRepository.UpdateEquipamento(id, equipamento);
            return RedirectToAction("Index");
        }
        else
        {
            return View("Editar", equipamento);
        }
    }

    [HttpPost]
    public IActionResult CadastrarEquipamento(Equipamento equipamento)
    {
        _equipamentoRepository.CreateEquipamento(equipamento);
        return RedirectToAction("Index");
    }

}
