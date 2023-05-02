using FilmesApi.Molds;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {

        private static List<Filme> filmes = new List<Filme>();


        [HttpPost] //Estamos postando um informação nova
        public void AdicionaFilme( [FromBody] Filme filme) //From body - Parametro 
        {
                        
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Duracao);

        }

    }
}