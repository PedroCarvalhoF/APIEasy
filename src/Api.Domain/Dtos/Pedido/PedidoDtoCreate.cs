using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.PedidoDtos
{
    public class PedidoDtoCreate
    {
        [DisplayName("N�mero do Pedido")]
        [MaxLength(100, ErrorMessage = "N�o pode passar de {0} caracteres")]
        public string? NumeroPedido { get; set; }
        //############################################################          

        [DisplayName("Observa��es")]
        [MaxLength(100, ErrorMessage = "N�o pode passar de {0} caracteres")]
        public string? Observacoes { get; set; } = string.Empty;

        //############################################################

        [DisplayName("Id PDV")]
        [Required(ErrorMessage = "Informe o {0}")]
        public Guid? PontoVendaEntityId { get; set; }
        //############################################################

        [DisplayName("Id Categoria Pre�o")]
        [Required(ErrorMessage = "Informe o {0}")]
        public Guid? CategoriaPrecoEntityId { get; set; }

        //############################################################

        [DisplayName("Id PDV")]
        //[Required(ErrorMessage = "Informe o {0}")]
        public Guid UserRegistroId { get; set; }
        //############################################################
    }
}
