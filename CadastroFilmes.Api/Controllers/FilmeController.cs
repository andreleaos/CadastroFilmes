using CadastroFilmes.Domain.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroFilmes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly FilmeService _filmeService;  

        public FilmeController(FilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var filmes = _filmeService.Listar();
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public ActionResult Pesquisar(int id)
        {
            var filme = _filmeService.PesquisarPorId(id);
            return Ok(filme);
        }

    }
}
