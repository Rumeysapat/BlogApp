
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using Blog.Shared.Entities.Abstract;
using ProgrammersBlog.Blog.Shared.Entities.Abstract;

namespace Blog.Entities.Concrete
{
    public class Article:EntityBase,IEntity
    {
        public string Title { get; set;}="";
        public string Content { get; set;}="content";

        public string Thumbnail { get; set; }="";
        
        public DateTime Date { get; set; }
        public int ViewsCount{ get; set; }

        public int Commentcount{ get; set; }

        public string SeoAuthor { get; set; } = "";

        public string SeoDescription { get; set; } 

        public string SeoTags   { get; set; }="tags";
        public int CategoryId { get; set; }

        public Category Category { get; set; } = new Category();

        public int UserId { get; set; }

        public  User User{ get; set; }=new User();
       
         public ICollection<Comment> Comments { get; set; }
    }
}