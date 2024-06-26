#region Using
using Api.Domain.Dtos.CategoriaPrecoDtos;
using Api.Domain.Dtos.CategoriaProdutoDtos;
using Api.Domain.Dtos.PedidoDtos;
using Api.Domain.Dtos.PontoVendaDtos;
using Api.Domain.Dtos.PrecoProdutoDtos;
using Api.Domain.Dtos.ProdutoMedidaDtos;
using Api.Domain.Models.CategoriaPreco;
using Api.Domain.Models.CategoriaProdutoModels;
using Api.Domain.Models.PedidoModels;
using Api.Domain.Models.PontoVendaModels;
using Api.Domain.Models.PrecoProdutoModels;
using Api.Domain.Models.ProdutoMedidaModels;
using AutoMapper;
using Domain.Dtos.CategoriaProdutoDtos;
using Domain.Dtos.FormaPagamentoDtos;
using Domain.Dtos.ItemPedido;
using Domain.Dtos.PagamentoPedidoDtos;
using Domain.Dtos.PedidoPagamento;
using Domain.Dtos.PedidoSituacao;
using Domain.Dtos.Pessoa.Funcionario.CTPS;
using Domain.Dtos.Pessoa.Funcionario.Funcao;
using Domain.Dtos.Pessoas.Contato;
using Domain.Dtos.Pessoas.DadosBancarios;
using Domain.Dtos.Pessoas.Endereco;
using Domain.Dtos.PessoasDtos.PessoaDtos;
using Domain.Dtos.PontoVendaPeriodoVendaDtos;
using Domain.Dtos.PontoVendaUser;
using Domain.Dtos.ProdutoDtos;
using Domain.Dtos.ProdutoTipo;
using Domain.Models.FormaPagamentoModels;
using Domain.Models.ItemPedidoModels;
using Domain.Models.PagamentoPedidoModels;
using Domain.Models.PedidoSituacao;
using Domain.Models.PeriodoPontoVenda;
using Domain.Models.Pessoa.Funcionario.CTPS;
using Domain.Models.Pessoa.Funcionario.Funcao;
using Domain.Models.PessoaModels.PessoaModels;
using Domain.Models.Pessoas.Contato;
using Domain.Models.Pessoas.Endereco;
using Domain.Models.Pessoas.Pessoa;
using Domain.Models.PontoVendaUser;
using Domain.Models.ProdutoModels;
using Domain.Models.ProdutoTipo;


#endregion
namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            PagamentoPedidoDtoProfileModel();
            #region Sistema de Vendas
            CreateMap<UsuarioPontoVendaModel, UsuarioPontoVendaDto>().ReverseMap();
            CreateMap<UsuarioPontoVendaModel, UsuarioPontoVendaDtoCreate>().ReverseMap();

            CreateMap<SituacaoPedidoModel, SituacaoPedidoDto>().ReverseMap();
            CreateMap<SituacaoPedidoModel, SituacaoPedidoDtoCreate>().ReverseMap();
            CreateMap<SituacaoPedidoModel, SituacaoPedidoDtoUpdate>().ReverseMap();

            CreateMap<PrecoProdutoModel, PrecoProdutoDto>();
            CreateMap<PrecoProdutoModel, PrecoProdutoDtoCreate>();

            CreateMap<CategoriaProdutoModel, CategoriaProdutoDto>().ReverseMap();
            CreateMap<CategoriaProdutoModel, CategoriaProdutoDtoCreate>().ReverseMap();
            CreateMap<CategoriaProdutoModel, CategoriaProdutoDtoUpdate>().ReverseMap();

            CreateMap<ProdutoModel, ProdutoDto>().ReverseMap();
            CreateMap<ProdutoModel, ProdutoDtoCreate>().ReverseMap();

            CreateMap<ProdutoDto, ProdutoModel>();
            CreateMap<ProdutoDtoCreate, ProdutoModel>();
            CreateMap<ProdutoDtoUpdate, ProdutoModel>();



            CreateMap<PontoVendaModel, PontoVendaDto>().ReverseMap();
            CreateMap<PontoVendaModel, PontoVendaDtoCreate>().ReverseMap();


            CreateMap<PedidoModel, PedidoDto>().ReverseMap();
            CreateMap<PedidoModel, PedidoDtoCreate>().ReverseMap();
            CreateMap<PedidoModel, PedidoDtoUpdate>().ReverseMap();

            CreateMap<CategoriaPrecoModel, CategoriaPrecoDto>().ReverseMap();
            CreateMap<CategoriaPrecoModel, CategoriaPrecoDtoCreate>().ReverseMap();
            CreateMap<CategoriaPrecoModel, CategoriaPrecoDtoUpdate>().ReverseMap();

            CreateMap<PrecoProdutoModel, PrecoProdutoDto>().ReverseMap();
            CreateMap<PrecoProdutoModel, PrecoProdutoDtoCreate>().ReverseMap();
            CreateMap<PrecoProdutoModel, PrecoProdutoDtoUpdate>().ReverseMap();

            CreateMap<ItemPedidoModel, ItemPedidoDto>().ReverseMap();
            CreateMap<ItemPedidoModel, ItemPedidoDtoCreate>().ReverseMap();
            CreateMap<ItemPedidoModel, ItemPedidoDtoUpdate>().ReverseMap();

            CreateMap<FormaPagamentoModel, FormaPagamentoDto>().ReverseMap();
            CreateMap<FormaPagamentoModel, FormaPagamentoDtoCreate>().ReverseMap();
            CreateMap<FormaPagamentoModel, FormaPagamentoDtoUpdate>().ReverseMap();

            CreateMap<ProdutoMedidaModel, ProdutoMedidaDto>().ReverseMap();
            CreateMap<ProdutoMedidaModel, ProdutoMedidaDtoCreate>().ReverseMap();
            CreateMap<ProdutoMedidaModel, ProdutoMedidaDtoUpdate>().ReverseMap();

            CreateMap<ProdutoTipoModel, ProdutoTipoDto>().ReverseMap();
            CreateMap<ProdutoTipoModel, ProdutoTipoDtoCreate>().ReverseMap();
            CreateMap<ProdutoTipoModel, ProdutoTipoDtoUpdate>().ReverseMap();

            CreateMap<ProdutoTipoModel, ProdutoTipoDto>().ReverseMap();
            CreateMap<ProdutoTipoModel, ProdutoTipoDtoCreate>().ReverseMap();
            CreateMap<ProdutoTipoModel, ProdutoTipoDtoUpdate>().ReverseMap();

            CreateMap<PeriodoPontoVendaModel, PeriodoPontoVendaDto>().ReverseMap();
            CreateMap<PeriodoPontoVendaModel, PeriodoPontoVendaDtoCreate>().ReverseMap();
            #endregion
            #region Pessoas

            CreateMap<PessoaDtoCreate, PessoasModel>().ReverseMap();
            CreateMap<DadosBancariosDtoCreate, DadosBancariosModel>().ReverseMap();

            CreateMap<EnderecoDtoCreate, EnderecoModel>().ReverseMap();
            CreateMap<EnderecoDtoUpdate, EnderecoModel>().ReverseMap();

            CreateMap<ContatoDto, ContatoModel>().ReverseMap();
            CreateMap<ContatoDtoCreate, ContatoModel>().ReverseMap();
            CreateMap<ContatoDtoUpdate, ContatoModel>().ReverseMap();

            CreateMap<FuncaoFuncionarioDto, FuncaoFuncionarioModel>().ReverseMap();
            CreateMap<FuncaoFuncionarioDtoCreate, FuncaoFuncionarioModel>().ReverseMap();
            CreateMap<FuncaoFuncionarioDtoUpdate, FuncaoFuncionarioModel>().ReverseMap();

            CreateMap<CtpsDto, CtpsModel>().ReverseMap();
            CreateMap<CtpsDtoCreate, CtpsModel>().ReverseMap();
            CreateMap<CtpsDtoUpdate, CtpsModel>().ReverseMap();
            #endregion
        }

        private void PagamentoPedidoDtoProfileModel()
        {
            CreateMap<PagamentoPedidoDtoCreate, PagamentoPedidoModel>()
             .ConstructUsing(
             dto => new PagamentoPedidoModel(null, dto.PedidoEntityId, dto.FormaPagamentoEntityId, dto.ValorPago));

            CreateMap<PagamentoPedidoDtoUpdate, PagamentoPedidoModel>()
               .ConstructUsing(
               dto => new PagamentoPedidoModel(dto.Id, dto.PedidoEntityId, dto.FormaPagamentoEntityId, dto.ValorPago));
        }
    }
}