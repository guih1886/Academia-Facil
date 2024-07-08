using AcademiaFacil.Data.DTO;
using AcademiaFacil.Models.Entidades;

namespace AcademiaFacil.Data.Interfaces.Repository;

public interface IAlunoRepository
{
    List<Aluno> GetAlunos();
    Aluno CreateAluno(Aluno aluno);
    bool DeleteAlunoById(int id);
    Aluno? GetAlunoById(int id);
    Aluno UpdateAluno(int id, UpdateAlunoDto aluno);
}
