using AutoMapper;
using EntityLayer.Entities;
using EntityLayer.ViewModels;
namespace EntityLayer.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Book, BookViewModel>().ReverseMap();
            CreateMap<Author, AuthorViewModel>().ReverseMap();
            CreateMap<BookType, BookTypeViewModel>().ReverseMap();
        }
    }
}
