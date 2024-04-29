﻿using Domain.Entities.FormaPagamento;
using System.Linq.Expressions;

namespace Domain.Interfaces.Repository
{
    public interface IFormaPagamentoRepository
    {
        Task<IEnumerable<FormaPagamentoEntity>> SelectAsync(Expression<Func<FormaPagamentoEntity, bool>> funcao, bool fullConsulta = true);
    }
}