namespace iOSDeploymentIssue.Database;

using Microsoft.EntityFrameworkCore;

public class EntityDbContext : DbContext
{
    private readonly string _dbPath;

#pragma warning disable CS8618
    public EntityDbContext()
#pragma warning restore CS8618
    {
        //SQLitePCL.Batteries_V2.Init();
    }

    public EntityDbContext(string dbPath)
    {
        //SQLitePCL.Batteries_V2.Init();
        _dbPath = dbPath;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={_dbPath}");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
