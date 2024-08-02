using AcademiaFacil.Configuration;
using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AcademiaFacil.Controllers.Exercicios;

public class ExerciciosViewController : Controller
{
    private IEquipamentoRepository _equipamentoRepository;
    private ITipoExercicioRepository _tipoExercicioRepository;
    private IExercicioRepository _exercicioRepository;
    private IRelacaoCargasRepository _relacaoCargasRepository;
    private ConfigPadroes configuracao;

    public ExerciciosViewController(IEquipamentoRepository equipamentoRepository, ITipoExercicioRepository tipoExercicioRepository, IExercicioRepository exercicioRepository, IOptions<ConfigPadroes> config, IRelacaoCargasRepository relacaoCargasRepository)
    {
        _equipamentoRepository = equipamentoRepository;
        _tipoExercicioRepository = tipoExercicioRepository;
        _exercicioRepository = exercicioRepository;
        configuracao = new ConfigPadroes();
        configuracao.NumeroRepeticoesPadrao = config.Value.NumeroRepeticoesPadrao;
        _relacaoCargasRepository = relacaoCargasRepository;
    }

    public IActionResult Index()
    {
        List<Exercicio> lista = _exercicioRepository.GetExercicios();
        PreencheViewBag();
        return View(lista);
    }

    public IActionResult Cadastrar()
    {
        PreencheViewBag();
        return View();
    }

    public IActionResult Editar(int id)
    {
        Exercicio? exercicio = _exercicioRepository.GetExerciciosPorId(id);
        PreencheViewBag();
        return View(exercicio);
    }

    public IActionResult EditarExercicio(Exercicio exercicio)
    {
        if (ModelState.IsValid)
        {
            _exercicioRepository.AtualizarExercicio(exercicio);
            return RedirectToAction("Index");
        }
        else
        {
            PreencheViewBag();
            return View("Editar", exercicio);
        }
    }

    public IActionResult Deletar(int id)
    {
        if (_exercicioRepository.DeletarExercicio(id))
        {
            return RedirectToAction("Index");
        }
        //TODO redirecionar para a página de erro
        return RedirectToAction("//");
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
        ViewBag.RelacaoCargas = _relacaoCargasRepository.GetRelacaoCargas()!.Where(rc => rc.Ativo == true).ToList();
        ViewBag.RepeticaoPadrao = configuracao.NumeroRepeticoesPadrao;
        return ViewBag;
    }
}