using AutoMapper;
using Blog.Models;
using Blog.Models.Dtos.Categories;
using Blog.Models.Dtos.Posts;
using Blog.Models.Dtos.Tags;
using Blog.Models.Dtos.Users;

namespace Blog.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            //Auth Mappers
            CreateMap<UserRegisterDto, ApplicationUser>().ReverseMap();
            CreateMap<UserLoginDto, ApplicationUser>().ReverseMap();

            //Category Mappers
            CreateMap<CategoryCreateDto, Category>().ReverseMap();
            CreateMap<CategoryUpdateDto, Category>().ReverseMap();
            CreateMap<CategoryReadDto, Category>().ReverseMap();
            CreateMap<CategoryDetailsDto, Category>().ReverseMap();

            //Tag Mappers
            CreateMap<TagCreateDto, Tag>().ReverseMap();
            CreateMap<TagUpdateDto, Tag>().ReverseMap();
            CreateMap<TagReadDto, Tag>().ReverseMap();
            CreateMap<TagDetailsDto, Tag>().ReverseMap();

            //Post Mappers
            CreateMap<PostCreateDto, Post>().ReverseMap();
            CreateMap<PostUpdateDto, Post>().ReverseMap();
            CreateMap<PostReadDto, Post>().ReverseMap();
            CreateMap<PostDetailsDto, Post>().ReverseMap();
        }
    }
}
