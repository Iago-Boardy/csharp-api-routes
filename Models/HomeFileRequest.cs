namespace Rotas.Models
{
    public class HomeFileRequest
    {
        public IFormFile File { get; set; } //Assim é como recebemos arquivos no .Net
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
