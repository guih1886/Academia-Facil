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

        public Aluno CreateAluno(Aluno aluno)
        {
            aluno.Ativo = true;
            _dbContext.Alunos.Add(aluno);
            _dbContext.SaveChanges();
            return aluno;
        }

        public bool DeleteAlunoById(int id)
        {
            Aluno? aluno = GetAlunoById(id);
            if (aluno != null)
            {
                _dbContext.Alunos.Remove(aluno);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public Aluno? GetAlunoById(int id)
        {
            Aluno? aluno = _dbContext.Alunos.FirstOrDefault(a => a.Id == id);
            return aluno;
        }

        public List<Aluno> GetAlunos()
        {
            return _dbContext.Alunos.ToList();
        }
    }
}