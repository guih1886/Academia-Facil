using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AcademiaFacil.Models;

public class Exercicio
{
    [Key]
    public int Id { get; set; }

    public bool Ativo { get; set; }

    [Required(ErrorMessage = "O nome do exercício deve ser informado."), NotNull]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Nome do exercício incorreto.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição do exercício deve ser informada."), NotNull]
    [StringLength(100, MinimumLength = 10, ErrorMessage = "Descrição do exercício incorreta.")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O tipo do exercício deve ser inforado."), NotNull]
    public TipoExercicio TipoExercicio { get; set; }
}
