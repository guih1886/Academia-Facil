using AcademiaFacil.Data.Enums;
using AcademiaFacil.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AcademiaFacil.Models;

[Owned]
public class Treino
{
    public Treino() { }

    public Treino(int id, bool ativo, bool publico, string nome, string descricao, Nivel nivel, IEnumerable<Exercicio> exercicios, int professorId, Professor professor)
    {
        Id = id;
        Ativo = ativo;
        Publico = publico;
        Nome = nome;
        Descricao = descricao;
        Nivel = nivel;
        Exercicios = exercicios;
        ProfessorId = professorId;
        Professor = professor;
    }

    [Key]
    public int Id { get; set; }

    [NotNull]
    public bool Ativo { get; set; }

    public bool Publico { get; set; }

    [Required(ErrorMessage = "O nome do treino deve ser informado."), NotNull]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Nome do treino incorreto.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A descrição do treino deve ser informada."), NotNull]
    [StringLength(100, MinimumLength = 10, ErrorMessage = "Descrição do treino incorreta.")]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "O nível do treino deve ser informada."), NotNull]
    public Nivel Nivel { get; set; }

    [Required(ErrorMessage = "Pelo menos um exercício deve ser adicionado."), NotNull]
    public IEnumerable<Exercicio>? Exercicios { get; set; }

    [ForeignKey("ProfessorId")]
    public int ProfessorId { get; set; }

    public virtual Professor? Professor { get; set; }
}