using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Domain.Dtos;
using CadastroFilmes.Domain.Entities;

namespace CadastroFilmes.Services;

public class FilmeServiceImpl : FilmeService
{
    private readonly FilmeRepository _filmeRepository;

    public FilmeServiceImpl(FilmeRepository filmeRepository)
    {
        _filmeRepository = filmeRepository;
    }

    public void Atualizar(FilmeDto dto)
    {
        try
        {
            var filme = dto.ConvertToEntity();
            _filmeRepository.Atualizar(filme);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Cadastrar(FilmeDto dto)
    {
        try
        {
            var filme = dto.ConvertToEntity();
            _filmeRepository.Cadastrar(filme);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Excluir(int id)
    {
        try
        {
            _filmeRepository.Excluir(id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public List<FilmeDto> Listar()
    {
        try
        {
            var filmes = _filmeRepository.Listar();
            var filmesDto = Filme.ConvertToDto(filmes);
            return filmesDto;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public FilmeDto PesquisarPorId(int id)
    {
        try
        {
            var filmePesquisado = _filmeRepository.PesquisarPorId(id);
            var filmeDto = filmePesquisado.ConvertToDto();
            return filmeDto;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
