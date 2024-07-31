using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models.Tipos;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaFacil.Controllers.TiposExercicio
{
    public class TiposExercicioViewController : Controller
    {
        private ITipoExercicioRepository _tipoExercicioRepository;

        public TiposExercicioViewController(ITipoExercicioRepository tipoExercicioRepository)
        {
            _tipoExercicioRepository = tipoExercicioRepository;
        }

        public IActionResult Index()
        {
            List<TipoExercicio> listaTiposExercicio = _tipoExercicioRepository.ListaTiposExercicio();
            return View(listaTiposExercicio);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            TipoExercicio tipoExercicio = _tipoExercicioRepository.BuscarTipoExercicioPorId(id)!;
            return View(tipoExercicio);
        }

        public IActionResult EditarTipoExercicio(TipoExercicio tipoExercicio)
        {
            if (ModelState.IsValid)
            {
                _tipoExercicioRepository.AtualizarTipoExercicio(tipoExercicio);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Editar", tipoExercicio);
            }
        }

        public IActionResult Deletar(int id)
        {
            if (_tipoExercicioRepository.DeletarTipoExercicio(id))
            {
                return RedirectToAction("Index");
            }
            //TODO Retornar para a pagina de erro
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CadastrarTipoExercicio(TipoExercicio tipoExercicio)
        {
            if (ModelState.IsValid)
            {
                _tipoExercicioRepository.CadastrarTipoExercicio(tipoExercicio);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Cadastrar", tipoExercicio);
            }
        }
    }
}
