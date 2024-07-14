using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Domain.Dtos;
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

        [HttpPost]
        public ActionResult Cadastrar(FilmeDto filmeDto)
        {
            _filmeService.Cadastrar(filmeDto);
            return Ok("Cadastro efuetuado com sucesso!");
        }

        [HttpPut]
        public ActionResult Atualizar(FilmeDto filmeDto)
        {
            _filmeService.Atualizar(filmeDto);
            return Ok("Atualizacao efuetuada com sucesso!");
        }

        [HttpDelete("{id}")]
        public ActionResult Excluir(int id)
        {
            _filmeService.Excluir(id);
            return Ok("Exclusao efetuada com sucesso!");
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
