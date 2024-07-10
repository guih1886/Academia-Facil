using AcademiaFacil.Models;

namespace AcademiaFacil.Data.Interfaces.Repository;

public interface IEquipamentoRepository
{
    Equipamento CreateEquipamento(Equipamento equipamento);
    bool DeleteEquipamento(Equipamento equipamento);
    Equipamento? FindById(int id);
    List<Equipamento> GetEquipamentos();
}
