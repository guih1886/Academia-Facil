using AcademiaFacil.Data.Enums.Aluno;
using System.ComponentModel.DataAnnotations;

namespace AcademiaFacil.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Informe o tipo de plano do aluno.")]
        public TipoPlano TipoPlano { get; set; }

        #region "Strings"

        [Required(ErrorMessage = "A foto do equipamento deve ser informada.")]
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

        #endregion

        #region "Datas"

        [Required(ErrorMessage = "A data de nascimento deve ser informada.")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "A data de pagamento deve ser informada.")]
        [DataType(DataType.Date)]
        public DateTime DataPagamentoPlano { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataUltimoPagamento { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataProximoPagamento { get; set; }

        #endregion
    }
}