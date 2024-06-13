using System.Security.Cryptography;
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
    string connectionString = "Server=(localdb)\\ProjectsV13;Database=ProgrammersBlog;Trusted_Connection=True;AttachDbFilename=/Users/codertayfunpat/Projects/ProrammersBlog/ProgrammersBlog.mdf;";
    optionsBuilder.UseSqlServer(connectionString);
}


       
    }
}













