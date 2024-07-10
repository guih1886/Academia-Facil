using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AcademiaFacil.Models.Tipos;

[Owned]
public class RelacaoCargas
{
    public RelacaoCargas() { }

    public RelacaoCargas(int id, bool ativo, string relacaoCargas, string descricao)
    {
        Id = id;
        Ativo = ativo;
        Relacao = relacaoCargas;
        Descricao = descricao;
    }

    [Key]
    public int Id { get; set; }

    public bool Ativo { get; set; }

    [Required(ErrorMessage = "O relação deve ser informada."), NotNull]
    public string? Relacao { get; set; }

    [Required(ErrorMessage = "A descrição deve ser informada."), NotNull]
    [StringLength(150, MinimumLength = 10, ErrorMessage = "Descrição do tippo do exercício incorreto.")]
    public string? Descricao { get; set; }
}