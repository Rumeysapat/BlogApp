
using System.Threading.Tasks;
using Blog.Shared;
using System.Collections.Generic;
using Blog.Entities.Concrete;

using Blog.Entities;
using Blog.Shared.Entities.Abstract;
using ProgrammersBlog.Blog.Shared.Entities.Abstract;

namespace Blog.Entities.Concrete
{
    public class Category : EntityBase, IEntity
    {


        public string? Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Article>? Articles { get; set; }
    }

}



