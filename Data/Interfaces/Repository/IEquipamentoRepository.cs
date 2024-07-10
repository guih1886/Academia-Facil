using AcademiaFacil.Models;

namespace AcademiaFacil.Data.Interfaces.Repository;

public interface IEquipamentoRepository
{
    Equipamento CreateEquipamento(Equipamento equipamento);
    List<Equipamento> GetEquipamentos();
}
