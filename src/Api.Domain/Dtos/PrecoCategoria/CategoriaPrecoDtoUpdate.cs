using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.CategoriaPrecoDtos
{
    public class CategoriaPrecoDtoUpdate
    {
        [Required(ErrorMessage = "Informe a Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe a {0}")]
        [Display(Name = "Categoria de Pre�o")]
        [MaxLength(80, ErrorMessage = "Quantidade de caracteres deve ser menor ou igual 80")]
        public string? DescricaoCategoria { get; set; }

        [Required(ErrorMessage = "Informe se est� habilitado ou n�o")]
        [Display(Name = "Habilitado")]        
        public bool Habilitado { get; set; }
    }
}