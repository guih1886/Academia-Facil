using AcademiaFacil.Data.Enums.Aluno;
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

    [HttpPost]
    public IActionResult Cadastrar(Aluno aluno)
    {
        _alunoRepository.CadastrarAluno(aluno);
        return RedirectToAction("Listagem");
    }
}