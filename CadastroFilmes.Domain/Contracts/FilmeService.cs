using CadastroFilmes.Domain.Dtos;
using CadastroFilmes.Domain.Entities;

namespace CadastroFilmes.Domain.Contracts;
public interface FilmeService : GenericRepoService<FilmeDto, int>
{

}
