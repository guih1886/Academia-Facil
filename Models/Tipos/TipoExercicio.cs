using AcademiaFacil.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AcademiaFacil.Models.Tipos;

[Owned]
public class TipoExercicio
{
    public TipoExercicio()   {   }

    public TipoExercicio(int id, bool ativo, string nome, string descricao, Nivel nivel)
    {
        Id = id;
        Ativo = ativo;
        Nome = nome;
        Descricao = descricao;
        Nivel = nivel;
    }

    [Key]
    public int Id { get; set; }

    public bool Ativo { get; set; }

    [Required(ErrorMessage = "O nome deve ser informado."), NotNull]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Nome do tipo de exercício incorreto.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A descrição deve ser informada."), NotNull]
    [StringLength(150, MinimumLength = 10, ErrorMessage = "Descrição do tipo do exercício incorreto.")]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "O nível do treino deve ser informada."), NotNull]
    public Nivel Nivel { get; set; }
}