using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using Blog.Entities.Concrete;
using ProgrammersBlog.Blog.Entities.Dtos;

namespace ProgrammersBlog.Services.AutoMapper.Profiles
{
    public class ArticleProfile:Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto,Article>().ForMember(dest=>dest.CreatedDate,memberOptions:opt=>opt.MapFrom(x=>DateTime.Now));
            CreateMap<ArticleUpdateDto,Article>().ForMember(dest => dest.ModifiedByName,memberOptions:opt=>opt.MapFrom(x=>DateTime.Now));


        }

    }
}