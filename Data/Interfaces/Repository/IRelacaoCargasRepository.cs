using AcademiaFacil.Models.Tipos;

namespace AcademiaFacil.Data.Interfaces.Repository;

public interface IRelacaoCargasRepository
{
    RelacaoCargas CreateRelacaoCargas(RelacaoCargas relacao);
    bool DeleteRelacaoCarga(RelacaoCargas relacao);
    RelacaoCargas? FindById(int id);
    List<RelacaoCargas>? GetRelacaoCargas();
}
