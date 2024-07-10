using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models.Tipos;

namespace AcademiaFacil.Data.Repositories;

public class RelacaoCargasRepository : IRelacaoCargasRepository
{
    private AcademiaDBContext _dbContext;

    public RelacaoCargasRepository(AcademiaDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<RelacaoCargas>? GetRelacaoCargas()
    {
        return _dbContext.RelacaoCargas.ToList();
    }
}
