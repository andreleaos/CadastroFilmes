namespace CadastroFilmes.Domain.Entities;
public class Elenco
{
    public int ElencoId { get; set; }
    public int FilmeId { get; set; }
    public Filme Filme { get; set; }
    public int AtorId { get; set; }
    public Ator Ator { get; set; }
}
