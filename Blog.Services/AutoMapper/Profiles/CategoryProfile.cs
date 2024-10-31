using AutoMapper;
using Blog.Entities.Concrete;
using ProgrammersBlog.Blog.Entities.Dtos;

namespace ProgrammersBlog.Services.AutoMapper.Profiles
{
    public  class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto,Category>().ForMember(dest=>dest.CreatedDate,memberOptions:opt=>opt.MapFrom(x=>DateTime.Now));
            CreateMap<CategoryAddDto,Category>().ForMember(dest=>dest.ModifiedByName,memberOptions:opt=>opt.MapFrom(x=>DateTime.Now));
        }
        
    }
}