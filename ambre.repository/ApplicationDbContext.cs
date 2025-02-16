using Microsoft.EntityFrameworkCore;
using ambre.repository.Entity;

namespace ambre.repository;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) 
    {
    }

    public DbSet<QuestionnaireEntity> Questionnaires { get; set; }
}
