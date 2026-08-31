using DotNetLearning.Controllers;
using DotNetLearning.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetLearning.Database;

public class DotNetLearningContext : DbContext
{
    protected readonly IConfiguration _configuration;

    public DotNetLearningContext(DbContextOptions<DotNetLearningContext> options,
        IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_configuration.GetConnectionString("db"));
    }

    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Subject> Subjects { get; set; } = null!;
}