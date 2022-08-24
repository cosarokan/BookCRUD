using AutoMapper;
using DataAccessLayer;
using EntityLayer.Entities;
using EntityLayer.ViewModels;
namespace BusinessLayer.Implementations
{
    public class AuthorService : Service<AuthorViewModel, Author, int>, IAuthorService
    {
        public AuthorService(IAuthorRepository authorRepository, IMapper mapper) : base(authorRepository, mapper)
        {

        }
    }
}
