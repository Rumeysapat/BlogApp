
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

        public string? SeoDescription { get; set; } 

        public string SeoTags   { get; set; }="tags";
        public int CategoryId { get; set; }

        public required Category Category { get; set; }

        public int UserId { get; set; }

        public required User User{ get; set; }




        
    }
}