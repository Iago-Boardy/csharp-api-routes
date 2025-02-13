using System.ComponentModel.DataAnnotations;

namespace Rotas.Models
{
    public class HomeByIdRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(10, ErrorMessage ="Falta escrever caracteres")]
        public string Id { get; set; }

        [Required(ErrorMessage ="Escreve a idade rapa")]
        public int? Idade { get; set; }

    }
}
