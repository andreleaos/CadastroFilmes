using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Domain.Entities;

namespace CadastroFilmes.Infrastructure.Repositories;
public class FilmeRepositoryImpl : FilmeRepository
{
    private static List<Filme> _filmes = new List<Filme>();

    public FilmeRepositoryImpl()
    {
        _filmes.Add(new Filme()
        {
            FilmeId = 1,
            Nome = "Top Gang 2",
            Duracao = 88,
            Genero = new Genero { Descricao = "Comédia" }
        });

        _filmes.Add(new Filme()
        {
            FilmeId = 2,
            Nome = "As branquelas",
            Duracao = 83,
            Genero = new Genero { Descricao = "Comédia" }
        });
    }

    public void Atualizar(Filme entidade)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Filme entidade)
    {
        throw new NotImplementedException();
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public List<Filme> Listar()
    {
        var filmes = _filmes
            .OrderBy(p => p.Nome)
            .ToList();

        return filmes;
    }

    public Filme PesquisarPorId(int id)
    {
        throw new NotImplementedException();
    }
}
