﻿using AcademiaFacil.Data.Enums.Aluno;
using System.ComponentModel.DataAnnotations;

namespace AcademiaFacil.Models.Entidades
{
    public class Aluno
    {
        public Aluno() { }
        public Aluno(int id, bool ativo, TipoPlano tipoPlano, string senha, string imagem, string nome, string email, string celular, string cPF, DateTime dataNascimento, int dataPagamentoPlano, DateTime dataUltimoPagamento, DateTime dataProximoPagamento)
        {
            Id = id;
            Ativo = ativo;
            TipoPlano = tipoPlano;
            Senha = senha;
            Imagem = imagem;
            Nome = nome;
            Email = email;
            Celular = celular;
            CPF = cPF;
            DataNascimento = dataNascimento;
            DiaPagamentoPlano = dataPagamentoPlano;
            DataUltimoPagamento = dataUltimoPagamento;
            DataProximoPagamento = dataProximoPagamento;
        }

        [Key]
        public int? Id { get; set; }

        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O dia de pagamento deve ser informado.")]
        public int? DiaPagamentoPlano { get; set; }

        [Required(ErrorMessage = "Informe o tipo de plano do aluno.")]
        public TipoPlano? TipoPlano { get; set; }

        #region "Strings"

        [Required(ErrorMessage = "A senha deve ser informada.")]
        [Compare("ConfirmacaoSenha", ErrorMessage = "As senhas não são iguais.")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "A confirmação da senha deve ser informada.")]
        [DataType(DataType.Password)]
        public string? ConfirmacaoSenha { get; set; }

        [Required(ErrorMessage = "A foto do aluno deve ser informada.")]
        [DataType(DataType.Url, ErrorMessage = "Url inválida.")]
        public string? Imagem { get; set; }

        [Required(ErrorMessage = "O nome do aluno deve ser informado.")]
        [MinLength(10, ErrorMessage = "Nome do aluno muito curto.")]
        [MaxLength(50, ErrorMessage = "Nome do aluno muito grande, por favor abrevie.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O e-mail do aluno deve ser informado.")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O celular do aluno deve ser informado.")]
        [RegularExpression("^\\d{2}[9]\\d{4}\\d{4}$", ErrorMessage = "Celular inválido.")]
        public string? Celular { get; set; }

        [Required(ErrorMessage = "O CPF do aluno deve ser informado.")]
        [RegularExpression("^\\d{3}\\d{3}\\d{3}\\d{2}$", ErrorMessage = "O CPF inválido.")]
        public string? CPF { get; set; }

        #endregion

        #region "Datas"

        [Required(ErrorMessage = "A data de nascimento deve ser informada.")]
        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataUltimoPagamento { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataProximoPagamento { get; set; }

        #endregion
    }
}