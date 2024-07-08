using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.AlunoView;

public class AlunoViewController : Controller
{
    private IAlunoRepository _alunoRepository;

    public AlunoViewController(IAlunoRepository alunoRepository)
    {
        _alunoRepository = alunoRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Listagem()
    {
        List<Aluno> lista = _alunoRepository.GetAlunos();
        return View(lista);
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    public IActionResult Deletar(int id)
    {
        _alunoRepository.DeleteAlunoById(id);
        return RedirectToAction("Listagem");
    }

    public IActionResult Editar(int id)
    {
        Aluno? aluno = _alunoRepository.GetAlunoById(id);
        return View(aluno);
    }

    public IActionResult AtualizarAluno(Aluno aluno)
    {
        _alunoRepository.UpdateAluno(aluno);
        return RedirectToAction("Listagem");
    }

    [HttpPost]
    public IActionResult Cadastrar(Aluno aluno)
    {
        _alunoRepository.CreateAluno(aluno);
        return RedirectToAction("Listagem");
    }
}