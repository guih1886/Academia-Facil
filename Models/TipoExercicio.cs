using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AcademiaFacil.Models;

public class TipoExercicio
{
    public TipoExercicio(int id, bool ativo, string nome, string descricao)
    {
        Id = id;
        Ativo = ativo;
        Nome = nome;
        Descricao = descricao;
    }

    [Key]
    public int Id { get; set; }

    public bool Ativo { get; set; }

    [Required(ErrorMessage = "O nome deve ser informado."), NotNull]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Nome do tipo de exercício incorreto.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição deve ser informada."), NotNull]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Descrição do tippo do exercício incorreto.")]
    public string Descricao { get; set; }
}