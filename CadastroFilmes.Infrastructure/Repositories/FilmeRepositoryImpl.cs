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
        _filmeDbContext.Filmes.Update(entidade);
        _filmeDbContext.SaveChanges();
    }

    public void Cadastrar(Filme entidade)
    {
        _filmeDbContext.Filmes.Add(entidade);
        _filmeDbContext.SaveChanges();
    }

    public void Excluir(int id)
    {
        var filme = PesquisarPorId(id);
        if (filme != null)
        {
            _filmeDbContext.Filmes.Remove(filme);
            _filmeDbContext.SaveChanges();
        }
    }

    public List<Filme> Listar()
    {
        var filmes = _filmeDbContext.Filmes
            .Include("Genero")
            .OrderBy(p => p.Nome)
            .ToList();

        return filmes;
    }

    public Filme PesquisarPorId(int id)
    {
        var filme = _filmeDbContext.Filmes
            .Include("Genero")
            .FirstOrDefault(p => p.FilmeId.Equals(id));
        return filme;
    }
}
