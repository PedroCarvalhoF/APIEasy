﻿using Domain.Entities.Pessoa.Contato;
using Domain.Entities.Pessoa.Pessoas;

namespace Domain.Models.Pessoas.PessoaContato
{
    public class PessoaContatoModel
    {
        public Guid PessoaEntityId { get; set; }
        public PessoaEntity? PessoaEntity { get; set; }
        public Guid ContatoEntityId { get; set; }
        public ContatoEntity? ContatoEntity { get; set; }
    }
}
