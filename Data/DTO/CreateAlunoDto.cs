using AcademiaFacil.Data.Enums.Aluno;
using System.ComponentModel.DataAnnotations;

namespace AcademiaFacil.Data.DTO;

public class CreateAlunoDto
{
    public CreateAlunoDto(int diaPagamentoPlano, TipoPlano tipoPlano, string senha, string imagem, string nome, string email, string celular, string cPF, DateTime dataNascimento)
    {
        DiaPagamentoPlano = diaPagamentoPlano;
        TipoPlano = tipoPlano;
        Senha = senha;
        Imagem = imagem;
        Nome = nome;
        Email = email;
        Celular = celular;
        CPF = cPF;
        DataNascimento = dataNascimento;
    }

    [Required(ErrorMessage = "O dia de pagamento deve ser informado.")]
    public int DiaPagamentoPlano { get; set; }

    [Required(ErrorMessage = "Informe o tipo de plano do aluno.")]
    public TipoPlano TipoPlano { get; set; }

    [Required(ErrorMessage = "A senha deve ser informada.")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Required(ErrorMessage = "A foto do aluno deve ser informada.")]
    [DataType(DataType.Url, ErrorMessage = "Url inválida.")]
    public string Imagem { get; set; }

    [Required(ErrorMessage = "O nome do aluno deve ser informado.")]
    [MinLength(10, ErrorMessage = "Nome do aluno muito curto.")]
    [MaxLength(50, ErrorMessage = "Nome do aluno muito grande, por favor abrevie.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O e-mail do aluno deve ser informado.")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required(ErrorMessage = "O celular do aluno deve ser informado.")]
    [RegularExpression("^\\d{2}[9]\\d{4}\\d{4}$", ErrorMessage = "Celular inválido.")]
    public string Celular { get; set; }

    [Required(ErrorMessage = "O CPF do aluno deve ser informado.")]
    [RegularExpression("^\\d{3}\\.\\d{3}\\.\\d{3}\\.?\\-\\d{2}\\.?$", ErrorMessage = "O CPF inválido.")]
    public string CPF { get; set; }

    [Required(ErrorMessage = "A data de nascimento deve ser informada.")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }
}
