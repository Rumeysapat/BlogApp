using Blog.Data.Concrete.EntityFramework.Mappings;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Concrete.EntityFramework.Context
{
    public class ProgrammersBlogContext:DbContext
   {
    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public  DbSet<Role> Roles { get; set; }
    public  DbSet<Comment> Comments {get; set;}  
     public  DbSet<User> Users {get; set;}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlite("Data Source=blog.db");
}

protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Mapping klasörünüzdeki mapping dosyalarını burada tanımlayın
        modelBuilder.ApplyConfiguration(new ArticleMap());
         modelBuilder.ApplyConfiguration(new CategoryMap());
          modelBuilder.ApplyConfiguration(new CommentMap());
           modelBuilder.ApplyConfiguration(new RoleMap());
          
            modelBuilder.ApplyConfiguration(new UserMap());
    }
}

       
    }














