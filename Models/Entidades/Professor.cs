using System.ComponentModel.DataAnnotations;

namespace AcademiaFacil.Models.Entidades;

public class Professor
{
    public Professor(int id, bool ativo, string senha, string imagem, string nome, string email, string celular, string cPF, string cREF)
    {
        Id = id;
        Ativo = ativo;
        Senha = senha;
        Imagem = imagem;
        Nome = nome;
        Email = email;
        Celular = celular;
        CPF = cPF;
        CREF = cREF;
    }

    [Key]
    public int Id { get; set; }

    public bool Ativo { get; set; }

    [Required(ErrorMessage = "A senha deve ser informada.")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Required(ErrorMessage = "A foto do equipamento deve ser informada.")]
    [DataType(DataType.Url, ErrorMessage = "Url inválida.")]
    public string Imagem { get; set; }

    [Required(ErrorMessage = "O nome do professor deve ser informado.")]
    [MinLength(10, ErrorMessage = "Nome do professor muito curto.")]
    [MaxLength(50, ErrorMessage = "Nome do professor muito grande, por favor abrevie.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O e-mail do professor deve ser informado.")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required(ErrorMessage = "O celular do professor deve ser informado.")]
    [RegularExpression("^\\d{2}[9]\\d{4}\\d{4}$", ErrorMessage = "Celular inválido.")]
    public string Celular { get; set; }

    [Required(ErrorMessage = "O CPF do professor deve ser informado.")]
    [RegularExpression("^\\d{3}\\.\\d{3}\\.\\d{3}\\.?\\-\\d{2}\\.?$", ErrorMessage = "O CPF inválido.")]
    public string CPF { get; set; }

    [Required(ErrorMessage = "O CREF do professor deve ser informado.")]
    [RegularExpression("^\\d{5}?\\-[a-zA-Z]{1}\\/[a-zA-Z]{2}$", ErrorMessage = "O CPF inválido.")]
    public string CREF { get; set; }
}