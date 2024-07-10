using AcademiaFacil.Data.Interfaces.Repository;
using AcademiaFacil.Models;

namespace AcademiaFacil.Data.Repositories;

public class EquipamentoRepository : IEquipamentoRepository
{
    private AcademiaDBContext _dbContext;

    public EquipamentoRepository(AcademiaDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Equipamento CreateEquipamento(Equipamento equipamento)
    {
        equipamento.Ativo = true;
        _dbContext.Equipamentos.Add(equipamento);
        _dbContext.SaveChanges();
        return equipamento;
    }

    public bool DeleteEquipamento(Equipamento equipamento)
    {
        try
        {
            _dbContext.Equipamentos.Remove(equipamento);
            _dbContext.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public Equipamento? FindById(int id)
    {
        return _dbContext.Equipamentos.FirstOrDefault(e => e.Id == id);
    }

    public List<Equipamento> GetEquipamentos()
    {
        return _dbContext.Equipamentos.ToList();
    }

    public Equipamento? UpdateEquipamento(int id, Equipamento equipamentoAlterado)
    {
        Equipamento? equipamento = FindById(id);
        if (equipamento != null)
        {
            equipamento.Ativo = equipamentoAlterado.Ativo;
            equipamento.Nome = equipamentoAlterado.Nome;
            equipamento.Imagem = equipamentoAlterado.Imagem;
            equipamento.Descricao = equipamentoAlterado.Descricao;
            equipamento.RelacaoCargas = equipamentoAlterado.RelacaoCargas;
            equipamento.Ajuda = equipamentoAlterado.Ajuda;
            _dbContext.Equipamentos.Update(equipamento);
            _dbContext.SaveChanges();
            return equipamento;
        }
        else
        {
            return null;
        }
    }
}