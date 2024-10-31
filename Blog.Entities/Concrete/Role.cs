using Blog.Shared.Entities;
using Blog.Shared.Entities.Abstract;
using ProgrammersBlog.Blog.Shared.Entities.Abstract;
namespace Blog.Entities.Concrete
{
public  class Role:EntityBase,IEntity
{

public string Name { get; set; }="";
public string Description { get; set; } = "";

   public ICollection<User> Users { get; set; } 

    
    
}
}