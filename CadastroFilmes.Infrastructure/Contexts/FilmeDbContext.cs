using CadastroFilmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadastroFilmes.Infrastructure.Contexts;
public class FilmeDbContext : DbContext
{
    public FilmeDbContext(DbContextOptions<FilmeDbContext> options)
        :base(options)
    {

    }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Ator> Atores { get; set; }
    public DbSet<Elenco> Elencos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ConfigureGenero(modelBuilder);
        ConfigureFilme(modelBuilder);
        ConfigureAtor(modelBuilder);
        ConfigureElenco(modelBuilder);
    }

    private void ConfigureGenero(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genero>()
            .ToTable("Genero")
            .HasKey(p => p.GeneroId);

        modelBuilder.Entity<Genero>()
            .Property(p => p.Descricao)
            .IsRequired()
            .HasMaxLength(150);
    }
    private void ConfigureFilme(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Filme>()
            .ToTable("Filme");

        modelBuilder.Entity<Filme>()
            .HasKey(p => p.FilmeId);

        modelBuilder.Entity<Filme>()
            .Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(150);

        modelBuilder.Entity<Filme>()
            .Property(p => p.Duracao)
            .IsRequired();

        modelBuilder.Entity<Filme>()
            .HasOne(p => p.Genero)
            .WithMany()
            .HasForeignKey(p => p.GeneroId);
    }
    private void ConfigureAtor(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ator>()
            .ToTable("Ator");

        modelBuilder.Entity<Ator>()
            .HasKey(a => a.AtorId);
    }
    private void ConfigureElenco(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Elenco>()
            .ToTable("Elenco");

        modelBuilder.Entity<Elenco>()
            .HasKey(p => new { p.ElencoId, p.FilmeId, p.AtorId });

        modelBuilder.Entity<Elenco>()
            .HasOne(p => p.Filme)
            .WithMany(f => f.Elenco)
            .HasForeignKey(p => p.FilmeId);

        modelBuilder.Entity<Elenco>()
            .HasOne(p => p.Ator)
            .WithMany()
            .HasForeignKey(p => p.AtorId);

    }
}
