using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Dtos.PedidoDtos
{
    public class PedidoDtoUpdate
    {

        [DisplayName("Informe o Id do Pedido")]
        [Required(ErrorMessage = "Informe o {0}")]
        public Guid? PedidoId { get; set; }
        //############################################################

        [DisplayName("Número do Pedido")]
        [Required(ErrorMessage = "Informe o {0}")]
        [MaxLength(100, ErrorMessage = "Não pode passar de {0} caracteres")]
        public string? NumeroPedido { get; set; }
        //############################################################

        [DisplayName("Valor de Desconto")]
        [Required(ErrorMessage = "Informe o {0}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ValorDesconto { get; set; } = 0;
        //############################################################

        [DisplayName("Valor de Desconto")]
        [Required(ErrorMessage = "Informe o {0}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ValorPedido { get; set; } = 0;
        //############################################################

        [DisplayName("Observações")]
        [MaxLength(100, ErrorMessage = "Não pode passar de {0} caracteres")]
        public string? Observacoes { get; set; } = string.Empty;
        //############################################################

        [DisplayName("Id Situação")]
        [Required(ErrorMessage = "Informe o {0}")]
        public Guid SituacaoPedidoEntityId { get; set; }
        //############################################################

        [DisplayName("Id PDV")]
        [Required(ErrorMessage = "Informe o {0}")]
        public Guid? PontoVendaEntityId { get; set; }
        //############################################################

        [DisplayName("Id Categoria Preço")]
        [Required(ErrorMessage = "Informe o {0}")]
        public Guid? CategoriaPrecoEntityId { get; set; }

        //############################################################

        [DisplayName("Id PDV")]
        [Required(ErrorMessage = "Informe o {0}")]
        public Guid UserCreatePedidoId { get; set; }
        //############################################################

    }
}
