using System.ComponentModel.DataAnnotations;

namespace Rotas.Models
{
    public class HomeInsereAlunoRequest
    {
        [Required (ErrorMessage ="O nome é requerido"), MinLength(3),]
        public string Nome { get; set; }
        public int Idade { get; set; }

    }
}
