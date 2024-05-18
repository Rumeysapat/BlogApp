
using Blog.Shared.Entities;
using Blog.Shared.Entities.Abstract;
using ProgrammersBlog.Blog.Shared.Entities.Abstract;
namespace Blog.Entities.Concrete
{
public  class User:EntityBase,IEntity
{

public string FirstName { get; set; }="";
public string LastName { get; set;}="";
public string Email { get; set; } = "";

public byte[] PasswordHash { get; set; }=new byte[32];

public string Username { get; set; } ="";

public string Picture { get; set; }

public string Description { get; set; } = "";
public int RoleId { get; set; }

public Role Role { get; set; } 
    
}
}