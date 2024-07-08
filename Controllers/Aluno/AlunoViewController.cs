using AcademiaFacil.Data.DTO;
using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models.Entidades;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.AlunoView;

public class AlunoViewController : Controller
{
    private IAlunoRepository _alunoRepository;
    private IMapper _mapper;

    public AlunoViewController(IAlunoRepository alunoRepository, IMapper mapper)
    {
        _alunoRepository = alunoRepository;
        _mapper = mapper;
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

    public IActionResult AtualizarAluno(int id, UpdateAlunoDto updateAlunoDto)
    {
        if (ModelState.IsValid)
        {
            _alunoRepository.UpdateAluno(id, updateAlunoDto);
            return RedirectToAction("Listagem");
        }
        else
        {
            Aluno? aluno = _alunoRepository.GetAlunoById(id);
            return View("Editar", aluno);
        }
    }

    [HttpPost]
    public IActionResult Cadastrar(Aluno aluno)
    {
        if (ModelState.IsValid)
        {
            _alunoRepository.CreateAluno(aluno);
            return RedirectToAction("Listagem");
        }
        else
        {
            return View("Cadastro", aluno);
        }
    }
}