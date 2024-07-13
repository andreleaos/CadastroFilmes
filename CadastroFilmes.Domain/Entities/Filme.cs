using CadastroFilmes.Domain.Dtos;
using CadastroFilmes.Domain.Exceptions;

namespace CadastroFilmes.Domain.Entities;
public class Filme
{
    public int FilmeId { get; set; }
    public string Nome { get; set; }
    public int Duracao { get; set; }
    public Genero Genero { get; set; }
    public int GeneroId { get; set; }
    public List<Elenco> Elenco { get; set; }

    public void ValidarPropriedades()
    {
        if (string.IsNullOrEmpty(Nome))
            throw new FilmeException("Nome do filme é obrigatório");

        if (Genero == null || string.IsNullOrEmpty(Genero.Descricao))
            throw new FilmeException("Genero do filme é obrigatório");

        if (Duracao == 0)
            throw new FilmeException("Duracao do filme precisa ser maior do que zero");
    }

    public FilmeDto ConvertToDto()
    {
        var dto = new FilmeDto();
        dto.FilmeId = FilmeId;
        dto.Nome = Nome;
        dto.Duracao = Duracao;
        dto.Genero = Genero.Descricao;
        return dto;
    } 
    public static FilmeDto ConvertToDto(Filme filme)
    {
        var dto = new FilmeDto();
        dto.FilmeId = filme.FilmeId;
        dto.Nome = filme.Nome;
        dto.Duracao = filme.Duracao;
        dto.Genero = filme.Genero.Descricao;
        return dto;
    }
    public static List<FilmeDto> ConvertToDto(List<Filme> filmes)
    {
        var filmesDto = new List<FilmeDto>();

        foreach(var filme in filmes)
        {
            var filmeDto = ConvertToDto(filme);
            filmesDto.Add(filmeDto);
        }

        return filmesDto;
    }

}
