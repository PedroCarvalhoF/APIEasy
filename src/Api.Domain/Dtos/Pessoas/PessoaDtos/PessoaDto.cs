﻿using Domain.Enuns.Pessoas;

namespace Domain.Dtos.PessoasDtos.PessoaDtos
{
    public class PessoaDto
    {
        public Guid Id { get; set; }
        public string? NomeNomeFantasia { get; set; }
        public string? SobreNomeRazaoSocial { get; set; }
        public string? RgIE { get; set; }
        public string? CpfCnpj { get; set; }
        public DateTime DataNascimentoFundacao { get; set; }
        public PessoaTipoEnum? PessoaTipo { get; set; }
    }
}
