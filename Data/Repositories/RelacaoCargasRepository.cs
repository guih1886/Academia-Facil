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

    public RelacaoCargas CreateRelacaoCargas(RelacaoCargas relacao)
    {
        relacao.Ativo = true;
        _dbContext.RelacaoCargas.Add(relacao);
        _dbContext.SaveChanges();
        return relacao;
    }

    public bool DeleteRelacaoCarga(RelacaoCargas relacao)
    {
        try
        {
            _dbContext.RelacaoCargas.Remove(relacao);
            _dbContext.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public RelacaoCargas? FindById(int id)
    {
        return _dbContext.RelacaoCargas.FirstOrDefault(r => r.Id == id);
    }

    public List<RelacaoCargas>? GetRelacaoCargas()
    {
        return _dbContext.RelacaoCargas.ToList();
    }

    public RelacaoCargas? GetRelacaoCargasById(int? relacaoCargasId)
    {
        return _dbContext.RelacaoCargas.FirstOrDefault(r => r.Id == relacaoCargasId);
    }
}
