using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models.Entidades;

namespace AcademiaFacil.Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private AcademiaDBContext _dbContext;

        public AlunoRepository(AcademiaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Aluno> GetAlunos()
        {
            return _dbContext.Alunos.ToList();
        }
    }
}