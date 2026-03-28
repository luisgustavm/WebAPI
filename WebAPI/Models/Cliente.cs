using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O email do cliente é obrigatório.")]
        [EmailAddress(ErrorMessage = "O Formato do email deve ser email válido.")]
        public string Email { get; set; }
    }
}
