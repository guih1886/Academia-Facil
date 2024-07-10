using AcademiaFacil.Models.Tipos;

namespace AcademiaFacil.Models.View;

public class EquipamentoViewModel
{
    public EquipamentoViewModel() { }

    public EquipamentoViewModel(Equipamento equipamento, List<RelacaoCargas>? relacaoCargas)
    {
        Equipamento = equipamento;
        RelacaoCargas = relacaoCargas;
    }

    public Equipamento? Equipamento { get; set; }
    public List<RelacaoCargas>? RelacaoCargas { get; set; }
}
