using CadastroFilmes.Domain.Entities;

namespace CadastroFilmes.Domain.Dtos;
public class FilmeDto
{
    public int FilmeId { get; set; }
    public string Nome { get; set; }
    public int Duracao { get; set; }
    public string Genero { get; set; }

    public Filme ConvertToEntity()
    {
        var dto = new Filme();
        dto.FilmeId = FilmeId;
        dto.Nome = Nome;
        dto.Duracao = Duracao;
        dto.Genero = new Genero { Descricao = Genero };
        return dto;
    }
    public static Filme ConvertToEntity(FilmeDto filme)
    {
        var dto = new Filme();
        dto.FilmeId = filme.FilmeId;
        dto.Nome = filme.Nome;
        dto.Duracao = filme.Duracao;
        dto.Genero = new Genero { Descricao = filme.Genero };
        return dto;
    }
    public static List<FilmeDto> ConvertToEntity(List<FilmeDto> filmesDto)
    {
        var filmes = new List<Filme>();

        foreach (var filmeDto in filmesDto)
        {
            var filme = ConvertToEntity(filmeDto);
            filmes.Add(filme);
        }

        return filmesDto;
    }

}
