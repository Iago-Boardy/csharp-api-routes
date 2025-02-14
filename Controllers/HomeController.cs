using Microsoft.AspNetCore.Mvc;
using Rotas.Models;

namespace Rotas.Controllers
{
    public class HomeController : BaseController
    {
        //AQUI ESTAMOS TRABALHANDO COM O GET

        [HttpGet("hello-world")]                    //Primeira rota
        public string HelloWorld() => "Hello World";

        [HttpGet("Marvel")]                         //Segunda rota
        public string Marvel() => "Marvel return";

        [HttpGet("ById")]                      //Terceira rota
        public string GetById([FromQuery] HomeByIdRequest request)  //Aqui por causa da FromQuerry, o .Net sempre tenta requerir todos os dados do Model possíveis
        {
            return $"id:{request.Id}, idade:{request.Idade}";
        }


        //AQUI ESTAMOS TRABALHANDO COM POST

        [HttpPut("insere-aluno")] //AQUI PODE SER PUT OU POST, PUT PARA ATUALIZAR
        public HomeInsereAlunoResponse ExemploPost( //São gerados 2 models, um para request e outro para response
            [FromBody] HomeInsereAlunoRequest request
            )
        {
            var novoAluno = new HomeInsereAlunoResponse //Em cada request, é criado um novo aluno, com um novo ID
            {
                Id = Guid.NewGuid().ToString(),
                Nome = request.Nome,
                Idade = request.Idade
            };
            return novoAluno; //Retorno do novo aluno. Em cada operação populamos por um json um model e depois retornamos ele com um id
        }

        [HttpPost("file-receiver")]
        public bool EnviarArquivo([FromForm] HomeFileRequest request)
        {
            var stream = request.File.OpenReadStream(); //Aqui abrimos o arquivo, o explorador de arquivos
            return true;
        }

    }
}

  