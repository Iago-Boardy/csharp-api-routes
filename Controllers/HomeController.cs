using Microsoft.AspNetCore.Mvc;
using Rotas.Models;

namespace Rotas.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet("hello-world")]                    //Primeira rota
        public string HelloWorld() => "Hello World";

        [HttpGet("Marvel")]                         //Segunda rota
        public string Marvel() => "Marvel return";

        [HttpGet("ById")]                      //Terceira rota
        public string GetById([FromQuery] HomeByIdRequest request)  //Aqui por causa da FromQuerry, o .Net sempre tenta requerir todos os dados do Model possíveis
        {
            return $"id:{request.Id}, idade:{request.Idade}";
        }
         
    }
}

  