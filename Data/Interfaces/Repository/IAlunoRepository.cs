using AcademiaFacil.Models.Entidades;

namespace AcademiaFacil.Data.Interfaces.Repository;

public interface IAlunoRepository
{
    List<Aluno> GetAlunos();
}
