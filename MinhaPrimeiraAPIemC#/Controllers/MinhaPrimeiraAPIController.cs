using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MinhaPrimeiraAPIemC_.Controllers
{
    [Route("api/minhaprimeiraapi")]
    [ApiController]
    public class MinhaPrimeiraAPIController : ControllerBase
    {
        [Route("olamundo")]
        [HttpGet]
        public string olaMundo()
        {
            var nome = "Ola mundo";

            return nome;
        }

        [HttpGet("olamundopersonalizado")]
        public string OlaMundoPersonalizado(string nome)
        {
            return "Olá " + nome;
        }

        [HttpGet("somanotas")]
        public string SomaNotas(int nota1, int nota2)
        {
            var resultado = nota1 + nota2;

            return "O resultado é " + resultado;
        }

        [HttpGet("media")]
        public string Media(int nota1, int nota2)
        {
            var resultado = (nota1 + nota2) / 2;
            return "O resultado é " + resultado;
        }
    }
}
