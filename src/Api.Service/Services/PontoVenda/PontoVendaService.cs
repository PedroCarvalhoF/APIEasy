using Api.Domain.Dtos.PontoVendaDtos;
using Api.Domain.Entities.PontoVenda;
using Api.Domain.Interfaces.Services.Pedido;
using Api.Domain.Interfaces.Services.PontoVenda;
using Api.Domain.Models.PontoVendaModels;
using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.PontoVenda.Dashboards;
using Domain.Dtos.PontoVenda.Filtros;
using Domain.Entities.PedidoSituacao.Ferramentas;
using Domain.Interfaces;
using Domain.Interfaces.Repository.PontoVenda;

namespace Api.Service.Services.PontoVendaService
{
    public class PontoVendaService : IPontoVendaService
    {
        private readonly IBaseRepository<PontoVendaEntity>? _repository;
        private readonly IMapper? _mapper;
        private readonly IPontoVendaRepository? _implementacao;
        private readonly IPedidoService? _pedidoService;

        public PontoVendaService(IBaseRepository<PontoVendaEntity> repository,
                                 IMapper mapper,
                                 IPontoVendaRepository pontoVendaRepository, IPedidoService pedidoService)
        {
            _repository = repository;
            _mapper = mapper;
            _implementacao = pontoVendaRepository;
            _pedidoService = pedidoService;
        }

        public async Task<ResponseDto<List<PontoVendaDto>>> GetPdvs(bool include = false)
        {
            ResponseDto<List<PontoVendaDto>> resposta = new ResponseDto<List<PontoVendaDto>>();
            resposta.Dados = new List<PontoVendaDto>();
            try
            {
                IEnumerable<PontoVendaEntity> entities = await _implementacao.GetPdvs(include);

                if (entities == null)
                {
                    resposta.Status = true;
                    resposta.Mensagem = "Ponto de Venda n�o localizado";
                    return resposta;
                }

                List<PontoVendaDto> dtos = _mapper.Map<List<PontoVendaDto>>(entities);
                resposta.Dados = dtos;
                resposta.Mensagem = $"PDVs Localizados: {dtos.Count} ";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro.Detalhes: {ex.Message}";
                return resposta;
            }
        }
        public async Task<ResponseDto<List<PontoVendaDto>>> GetByIdPdv(Guid pdvId, bool include = false)
        {
            var resposta = new ResponseDto<List<PontoVendaDto>>();

            try
            {
                var entities = await _implementacao.GetByIdPdv(pdvId, include);

                if (entities == null)
                {
                    resposta.Status = true;
                    resposta.Mensagem = "Ponto de Venda n�o localizado";
                    return resposta;
                }

                var dtos = _mapper.Map<PontoVendaDto>(entities);
                resposta.Dados = new List<PontoVendaDto> { dtos };

                return resposta.ConsultaOk();
            }
            catch (Exception ex)
            {
                return resposta.Erro(ex);
            }
        }
        public async Task<ResponseDto<List<PontoVendaDto>>> GetByIdPerfilUsuario(Guid IdPerfilUtilizarPDV, bool include = false)
        {
            var resposta = new ResponseDto<List<PontoVendaDto>>();

            try
            {
                var entities = await _implementacao.GetByIdPerfilUsuario(IdPerfilUtilizarPDV, include);

                if (entities == null)
                {

                    return resposta.EntitiesNull();
                }

                var dtos = _mapper.Map<List<PontoVendaDto>>(entities);
                return resposta.Retorno(dtos);
            }
            catch (Exception ex)
            {
                return resposta.Erro(ex);
            }
        }
        public async Task<ResponseDto<List<PontoVendaDto>>> AbertosFechados(bool abertoFechado, bool include = false)
        {
            var resposta = new ResponseDto<List<PontoVendaDto>>();

            try
            {
                var entities = await _implementacao.AbertosFechados(abertoFechado, include);

                if (entities == null)
                {
                    return resposta.EntitiesNull();
                }

                var dtos = _mapper.Map<List<PontoVendaDto>>(entities);

                return resposta.Retorno(dtos);
            }
            catch (Exception ex)
            {
                return resposta.Erro(ex);
            }
        }
        public async Task<ResponseDto<List<PontoVendaDto>>> FiltrarByData(PontoVendaDtoFiltrarData data, bool include = false)
        {
            var resposta = new ResponseDto<List<PontoVendaDto>>();

            try
            {
                var entities = await _implementacao.FiltrarByData(data, include);

                if (entities == null)
                {
                    return resposta.EntitiesNull();
                }

                var dtos = _mapper.Map<List<PontoVendaDto>>(entities);
                return resposta.Retorno(dtos);
            }
            catch (Exception ex)
            {
                return resposta.Erro(ex);
            }
        }
        public async Task<ResponseDto<List<PontoVendaDto>>> Create(PontoVendaDtoCreate pontoVendaDtoCreate, bool include = false)
        {
            var resposta = new ResponseDto<List<PontoVendaDto>>();

            try
            {
                var model = _mapper.Map<PontoVendaModel>(pontoVendaDtoCreate);
                model.AbrirPDV();
                var entity = _mapper.Map<PontoVendaEntity>(model);

                var result = await _repository.InsertAsync(entity);

                if (result == null)
                {
                    resposta.ErroCadastro();
                    return resposta;
                }

                var pdvCreate = await GetByIdPdv(result.Id);
                pdvCreate.CadastroOk();

                return pdvCreate;
            }
            catch (Exception ex)
            {
                return resposta.Erro(ex);
            }
        }
        public async Task<ResponseDto<List<PontoVendaDto>>> Encerrar(Guid pontoVendaId, bool include = false)
        {
            var resposta = new ResponseDto<List<PontoVendaDto>>();
            resposta.Dados = new List<PontoVendaDto>();
            try
            {
                var pedidos_pdv = await _pedidoService.GetAllBySituacao(pontoVendaId, GuidSituacaoPedido.SituacaoAbertoID);
                if (pedidos_pdv.Status)
                {
                    return resposta.Erro("Finalize todos os pedidos");
                }


                var pdvSelecionado = await _repository.SelectAsync(pontoVendaId);

                var model = _mapper.Map<PontoVendaModel>(pdvSelecionado);

                model.FinalizarPDV();

                var entity = _mapper.Map<PontoVendaEntity>(model);

                var resultUpdate = await _repository.UpdateAsync(entity);

                var verificarUpdate = await _implementacao.GetByIdPdv(pontoVendaId, include);

                if (!verificarUpdate.AbertoFechado)
                {
                    resposta.Mensagem = $"PDV {entity.Id} encerrado com sucesso! {resultUpdate.UpdateAt} ";
                    return resposta;
                }
                else
                {
                    resposta.Status = false;
                    resposta.Mensagem = "N�o foi poss�vel encerrar pdv";
                    return resposta;
                }
            }
            catch (Exception ex)
            {
                return resposta.Erro(ex);
            }
        }
        public async Task<ResponseDto<List<DashPontoVendaResult>>> GetDashPdvById(Guid idPdv, bool include = false)
        {
            try
            {
                var result = (await GetByIdPdv(idPdv, include)).Dados.SingleOrDefault();
                if (result == null)
                {
                    return new ResponseDto<List<DashPontoVendaResult>>().EntitiesNull();
                }

                DashPontoVendaResult dash = new DashPontoVendaResult();
                dash.IdPdv = DashPontoVendaCalculator<PontoVendaDto>.GetIdPdv(result);
                dash.DataAbertura = DashPontoVendaCalculator<PontoVendaDto>.GetDataPdvAbertura(result);
                dash.DataEncerramento = DashPontoVendaCalculator<PontoVendaDto>.GetDataPdvEncerramento(result);
                dash.Periodo = DashPontoVendaCalculator<PontoVendaDto>.GetPeriodoPdv(result);
                dash.Situacao = DashPontoVendaCalculator<PontoVendaDto>.GetSituacaoPdv(result);
                dash.ResponsavelAbertura = DashPontoVendaCalculator<PontoVendaDto>.GetUsuarioResponsavelAberturaCaixa(result);
                dash.ResponsavelOperador = DashPontoVendaCalculator<PontoVendaDto>.GetUsuarioOperadorCaixa(result);
                dash.Faturamento = DashPontoVendaCalculator<PontoVendaDto>.Total(result);
                dash.QuantidadePedidos = DashPontoVendaCalculator<PontoVendaDto>.QtdPedidos(result, true);

                if (dash.Faturamento == 0 || dash.QuantidadePedidos == 0)
                {
                    dash.TicktMedido = 0;
                }
                else
                {
                    dash.TicktMedido = dash.Faturamento / dash.QuantidadePedidos;
                }


                dash.ResumoPagamento = DashPontoVendaCalculator<PontoVendaDto>.ResumoPagamentos(result);
                dash.ResumoProdutos = DashPontoVendaCalculator<PontoVendaDto>.ResumoProdutos(result);

                dash.ResumoVendasByCategoriaPrecoGroupBy = DashPontoVendaCalculator<PontoVendaDto>.PedidosByCategoriaPreco(result);
                dash.ProdutosByCategoriaPrecoGroupBy = DashPontoVendaCalculator<PontoVendaDto>.ProdutosByCategoriaPreco(result);
                dash.PagamentoByCategoriaPrecoGroupBy = DashPontoVendaCalculator<PontoVendaDto>.PagamentosByCategoriaPreco(result);

                dash.ResumoProdutosQtdPrecoTotalByAvulso = DashPontoVendaCalculator<PontoVendaDto>.GetResumoProdutosQtdPrecoTotalByAvulso(result);

                return new ResponseDto<List<DashPontoVendaResult>>().Retorno(new List<DashPontoVendaResult>() { dash });

            }
            catch (DivideByZeroException ex)
            {
                return new ResponseDto<List<DashPontoVendaResult>>().Erro(ex);
            }

            catch (Exception ex)
            {

                return new ResponseDto<List<DashPontoVendaResult>>().Erro(ex);
            }
        }
    }
}