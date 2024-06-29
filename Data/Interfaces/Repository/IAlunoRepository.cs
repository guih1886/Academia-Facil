using AcademiaFacil.Models.Entidades;

namespace AcademiaFacil.Data.Interfaces.Repository;

public interface IAlunoRepository
{
    List<Aluno> GetAlunos();
    Aluno CadastrarAluno(Aluno aluno);
}
