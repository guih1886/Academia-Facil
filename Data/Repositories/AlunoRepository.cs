using AcademiaFacil.Data.DTO;
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

        public Aluno UpdateAluno(int id, UpdateAlunoDto alunoAtualizado)
        {
            Aluno? aluno = _dbContext.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) throw new Exception("Aluno não encontrado.");
            try
            {
                aluno.Ativo = alunoAtualizado.Ativo;
                aluno.Nome = alunoAtualizado.Nome;
                aluno.Email = alunoAtualizado.Email;
                aluno.CPF = alunoAtualizado.CPF;
                aluno.Celular = alunoAtualizado.Celular;
                aluno.DataNascimento = alunoAtualizado.DataNascimento;
                aluno.Imagem = alunoAtualizado.Imagem;
                aluno.TipoPlano = alunoAtualizado.TipoPlano;
                aluno.DiaPagamentoPlano = alunoAtualizado.DiaPagamentoPlano;
                _dbContext.Alunos.Update(aluno);
                _dbContext.SaveChanges();
                return aluno;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar o aluno." + e.Message);
            }
        }
    }
}