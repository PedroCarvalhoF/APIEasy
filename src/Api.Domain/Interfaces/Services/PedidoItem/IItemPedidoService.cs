﻿using Domain.Dtos;
using Domain.Dtos.ItemPedido;
using Domain.Dtos.PedidoItem;

namespace Domain.Interfaces.Services.ItemPedido
{
    public interface IItemPedidoService
    {
        Task<ResponseDto<List<ItemPedidoDto>>> Get(Guid id);
        Task<ResponseDto<List<ItemPedidoDto>>> GetByIdPedido(Guid idPedido);
        Task<ResponseDto<List<ItemPedidoDto>>> GerarItemPedido(ItemPedidoDtoCreate itemPedido);
        Task<ResponseDto<List<ItemPedidoDto>>> CancelarItemPedido(Guid id);
        Task<ResponseDto<List<ItemPedidoDto>>> GetAll();
        Task<ResponseDto<List<ItemPedidoDto>>> EditarObservacao(ItemPedidoDtoEditarObservacao observacao);
    }
}
