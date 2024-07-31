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

        public Exercicio CadastrarExercicio(Exercicio exercicio)
        {
            _dbContext.Exercicios.Add(exercicio);
            _dbContext.SaveChanges();
            return exercicio;
        }
    }
}