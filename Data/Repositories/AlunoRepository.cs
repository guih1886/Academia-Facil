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

        public Aluno CadastrarAluno(Aluno aluno)
        {
            aluno.Ativo = true;
            _dbContext.Alunos.Add(aluno);
            _dbContext.SaveChanges();
            return aluno;
        }

        public List<Aluno> GetAlunos()
        {
            return _dbContext.Alunos.ToList();
        }
    }
}