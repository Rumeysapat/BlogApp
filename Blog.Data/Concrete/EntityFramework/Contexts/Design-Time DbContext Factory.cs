using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Blog.Data.Concrete.EntityFramework.Context;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProgrammersBlogContext>
{
    public ProgrammersBlogContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ProgrammersBlogContext>();
        optionsBuilder.UseSqlite("Data Source=blog.db");

        return new ProgrammersBlogContext(optionsBuilder.Options);
    }
}
