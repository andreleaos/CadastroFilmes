using CadastroFilmes.Domain.Entities;

namespace CadastroFilmes.SimpleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;

            switch (op)
            {
                case 1:
                    ValidarCriacaoObjetoFilmes();
                    break;
            }
        }

        private static void ValidarCriacaoObjetoFilmes()
        {
            try
            {
                var filme1 = new Filme { FilmeId = 1, Nome = "Top Gang 2", Duracao = 98, Genero = new Genero { Descricao = "Comédia" } };
                filme1.ValidarPropriedades();

                var filme2 = new Filme { FilmeId = 2, Nome = "As branquelas", Duracao = 88 };
                filme2.ValidarPropriedades();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}