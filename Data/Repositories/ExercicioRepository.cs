using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models;

namespace AcademiaFacil.Data.Repositories
{
    public class ExercicioRepository : IExercicioRepository
    {
        private AcademiaDBContext _dbContext;

        public ExercicioRepository(AcademiaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Exercicio AtualizarExercicio(Exercicio exercicio)
        {
            _dbContext.Exercicios.Update(exercicio);
            _dbContext.SaveChanges();
            return exercicio;
        }

        public Exercicio CadastrarExercicio(Exercicio exercicio)
        {
            exercicio.Ativo = true;
            _dbContext.Exercicios.Add(exercicio);
            _dbContext.SaveChanges();
            return exercicio;
        }

        public bool DeletarExercicio(int id)
        {
            Exercicio exercicio = GetExerciciosPorId(id);
            try
            {
                _dbContext.Exercicios.Remove(exercicio);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Exercicio> GetExercicios()
        {
            return _dbContext.Exercicios.ToList();
        }

        public Exercicio? GetExerciciosPorId(int id)
        {
            return _dbContext.Exercicios.FirstOrDefault(ex => ex.Id == id);
        }
    }
}