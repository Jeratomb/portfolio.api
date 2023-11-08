using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using portfolio.api.Persistence.Entities;

namespace portfolio.api.Persistence.Context
{
    public class PortfolioDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public PortfolioDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Knowledge> Knowledges { get; set; }
        public DbSet<Project> Projects { get; set; }
        //public DbSet<Skill> Skills { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortfolioDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public IQueryable<Project> GetProjectQuery(CancellationToken cancellationToken, bool onlyForReadOperation) => 
        onlyForReadOperation ? Projects.AsNoTracking().Include(x => x.Knowledges) : Projects.Include(x => x.Knowledges);

        public IQueryable<Project> GetProject(Guid projectId, CancellationToken cancellationToken, bool onlyForReadOperation) =>
        onlyForReadOperation ? Projects.AsNoTracking().Include(x => x.Knowledges).Where(x=>x.Id == projectId) : Projects.Include(x => x.Knowledges).Where(x=>x.Id == projectId);
    }
}