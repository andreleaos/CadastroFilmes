namespace CadastroFilmes.Domain.Contracts;
public interface GenericRepoService <T, Y> where T : class
{
    void Cadastrar(T entidade);
    void Atualizar(T entidade);
    void Excluir(Y id);
    List<T> Listar();
    T PesquisarPorId(Y id);
}
