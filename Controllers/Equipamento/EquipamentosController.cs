using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.Equipamentos;

public class EquipamentosController : Controller
{
    private IEquipamentoRepository _equipamentoRepository;

    public EquipamentosController(IEquipamentoRepository equipamentoRepository)
    {
        _equipamentoRepository = equipamentoRepository;
    }

    public IActionResult Index()
    {
        List<Equipamento> equipamentos = _equipamentoRepository.GetEquipamentos();
        return View(equipamentos);
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    public IActionResult Editar()
    {
        return View();
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

    [HttpPost]
    public IActionResult CadastrarEquipamento(Equipamento equipamento)
    {
        _equipamentoRepository.CreateEquipamento(equipamento);
        return RedirectToAction("Index");
    }

}
