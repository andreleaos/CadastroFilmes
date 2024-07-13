using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Domain.Entities;
using CadastroFilmes.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CadastroFilmes.Infrastructure.Repositories;
public class FilmeRepositoryImpl : FilmeRepository
{
    private readonly FilmeDbContext _filmeDbContext;

    public FilmeRepositoryImpl(FilmeDbContext filmeDbContext)
    {
        _filmeDbContext = filmeDbContext;
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
        var filmes = _filmeDbContext.Filmes
            .OrderBy(p => p.Nome)
            .ToList();

        return filmes;
    }

    public Filme PesquisarPorId(int id)
    {
        var filme = _filmeDbContext.Filmes
            .FirstOrDefault(p => p.FilmeId.Equals(id));
        return filme;
    }
}
