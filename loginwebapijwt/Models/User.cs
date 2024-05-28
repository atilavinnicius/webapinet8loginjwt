using loginwebapijwt.Enums;
using System.ComponentModel.DataAnnotations;

namespace loginwebapijwt.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "O campo Name é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo Name deve ter entre 2 e 100 caracteres.")]
        public string name { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
        public string email { get; set; }

        [Required(ErrorMessage = "O campo Password é obrigatório.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "O campo Password deve ter pelo menos 6 caracteres.")]
        public string password { get; set; }

        [EnumDataType(typeof(EnumRole), ErrorMessage = "O campo Role deve ser um valor válido.")]
        public EnumRole role { get; set; }
    }
}
