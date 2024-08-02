using AcademiaFacil.Data.Enums;
using AcademiaFacil.Models.Tipos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AcademiaFacil.Models;

[Owned]
public class Exercicio
{
    public Exercicio() { }

    public Exercicio(int id, bool ativo, string nome, string descricao, int tipoExercicioId, int repeticoes, float carga, string? ajuda, string? observacao, int equipamentoId)
    {
        Id = id;
        Ativo = ativo;
        Nome = nome;
        Descricao = descricao;
        Repeticoes = repeticoes;
        Carga = carga;
        Ajuda = ajuda;
        Observacao = observacao;
        TipoExercicioId = tipoExercicioId;
        EquipamentoId = equipamentoId;
    }

    [Key]
    public int? Id { get; set; }

    public bool Ativo { get; set; }

    [Required(ErrorMessage = "O nome do exercício deve ser informado."), NotNull]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "Nome do exercício incorreto.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A descrição do exercício deve ser informada."), NotNull]
    [StringLength(100, MinimumLength = 10, ErrorMessage = "Descrição do exercício incorreta.")]
    public string? Descricao { get; set; }


    [Required(ErrorMessage = "O número de repetições deve ser informado."), NotNull]
    public int Repeticoes { get; set; }

    [Required(ErrorMessage = "A carga deve ser informado.")]
    public float Carga { get; set; }

    [Required(ErrorMessage = "O nível do treino deve ser informada."), NotNull]
    public Nivel Nivel { get; set; }

    [DataType(DataType.Url, ErrorMessage = "Url inválida.")]
    public string? Ajuda { get; set; }

    public string? Observacao { get; set; }

    [ForeignKey("Equipamento")]
    [Required(ErrorMessage = "O equipamento deve ser informado.")]
    public int? EquipamentoId { get; set; }

    public virtual Equipamento? Equipamento { get; set; }

    [ForeignKey("TipoExercicio")]
    [Required(ErrorMessage = "O tipo do exercício deve ser inforado."), NotNull]
    public int? TipoExercicioId { get; set; }

    public virtual TipoExercicio? TipoExercicio { get; set; }

}