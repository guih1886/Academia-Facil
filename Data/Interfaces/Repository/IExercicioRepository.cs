using AcademiaFacil.Models;

namespace AcademiaFacil.Data.Interfaces.Repository
{
    public interface IExercicioRepository
    {
        Exercicio AtualizarExercicio(Exercicio exercicio);
        Exercicio CadastrarExercicio(Exercicio exercicio);
        bool DeletarExercicio(int id);
        List<Exercicio> GetExercicios();
        Exercicio? GetExerciciosPorId(int id);
    }
}
