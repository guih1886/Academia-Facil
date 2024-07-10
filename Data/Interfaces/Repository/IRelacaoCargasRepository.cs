using AcademiaFacil.Models.Tipos;

namespace AcademiaFacil.Data.Interfaces.Repository;

public interface IRelacaoCargasRepository
{
    List<RelacaoCargas>? GetRelacaoCargas();
}
