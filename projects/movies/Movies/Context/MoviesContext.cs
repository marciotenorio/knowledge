using Microsoft.EntityFrameworkCore;
using Movies.Model;

namespace Movies.Context;

public class MoviesContext : DbContext
{
    private IConfiguration _configuration;
    //TODO na hora de salvar com o ef ver se tem id ou não e gerar usando TSID pra salvar
    public DbSet<Movie> Movies { get; set; }
    public DbSet<CastMember> CastMembers { get; set; }
    public DbSet<Theater> Theaters { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<User> Users { get; set; }
    
    public MoviesContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbConnectionString = _configuration.GetConnectionString("movies-db");
        optionsBuilder.UseNpgsql(dbConnectionString);
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        optionsBuilder.EnableSensitiveDataLogging(); //not for production
        base.OnConfiguring(optionsBuilder);
    }
}