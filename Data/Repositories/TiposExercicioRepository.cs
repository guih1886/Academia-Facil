using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models.Tipos;

namespace AcademiaFacil.Data.Repositories
{
    public class TiposExercicioRepository : ITipoExercicioRepository
    {
        private AcademiaDBContext _dbContext;

        public TiposExercicioRepository(AcademiaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TipoExercicio AtualizarTipoExercicio(TipoExercicio tipoExercicio)
        {
            _dbContext.TiposExercicio.Update(tipoExercicio);
            _dbContext.SaveChanges();
            return tipoExercicio;
        }

        public TipoExercicio? BuscarTipoExercicioPorId(int id)
        {
            TipoExercicio? tipoExercicio = _dbContext.TiposExercicio.FirstOrDefault(te => te.Id == id);
            return tipoExercicio;
        }

        public TipoExercicio CadastrarTipoExercicio(TipoExercicio tipoExercicio)
        {
            tipoExercicio.Ativo = true;
            _dbContext.TiposExercicio.Add(tipoExercicio);
            _dbContext.SaveChanges();
            return tipoExercicio;
        }

        public bool DeletarTipoExercicio(int id)
        {
            TipoExercicio? tipoExercicio = BuscarTipoExercicioPorId(id);
            if (tipoExercicio != null)
            {
                _dbContext.TiposExercicio.Remove(tipoExercicio);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<TipoExercicio> ListaTiposExercicio()
        {
            return _dbContext.TiposExercicio.ToList();
        }
    }
}