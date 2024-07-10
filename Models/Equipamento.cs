using AcademiaFacil.Models.Tipos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AcademiaFacil.Models;

[Owned]
public class Equipamento
{
    public Equipamento() { }

    public Equipamento(int id, bool ativo, string imagem, string nome, string descricao, int relacaoCargas, string? ajuda)
    {
        Id = id;
        Ativo = ativo;
        Imagem = imagem;
        Nome = nome;
        Descricao = descricao;
        RelacaoCargasId = relacaoCargas;
        Ajuda = ajuda;
    }

    [Key]
    public int Id { get; set; }

    public bool Ativo { get; set; }

    [Required(ErrorMessage = "A imagem do equipamento deve ser informada.")]
    [DataType(DataType.Url, ErrorMessage = "Url inválida.")]
    public string? Imagem { get; set; }

    [Required(ErrorMessage = "O nome do equipamento deve ser informado.")]
    [StringLength(100, MinimumLength = 10, ErrorMessage = "Nome muito curto.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A descrição do equipamento deve ser informada.")]
    [StringLength(150, MinimumLength = 20, ErrorMessage = "Descrição muito curta.")]
    public string? Descricao { get; set; }

    [ForeignKey("RelacaoCargas")]
    [Required(ErrorMessage = "A relação das cargas deve ser informada.")]
    public int? RelacaoCargasId { get; set; }

    public virtual RelacaoCargas? RelacaoCargas { get; set; }

    [DataType(DataType.Url, ErrorMessage = "Url inválida.")]
    public string? Ajuda { get; set; }
}