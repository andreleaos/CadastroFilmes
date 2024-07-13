namespace CadastroFilmes.Domain.Exceptions;

public class FilmeException : Exception
{
    public FilmeException()
    {

    }

    public FilmeException(string mensagem)
        : base(mensagem) 
    {
        
    }

    public FilmeException(string mensagem, Exception innerException)
        :base(mensagem, innerException)
    {

    }
}
