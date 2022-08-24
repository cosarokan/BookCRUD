using AutoMapper;
using DataAccessLayer;
using EntityLayer.Entities;
using EntityLayer.ViewModels;
namespace BusinessLayer.Implementations
{
    public class BookService : Service<BookViewModel, Book, int>, IBookService
    {
        public BookService(IBookRepository bookRepository, IMapper mapper) :base(bookRepository, mapper)
        {
        }
    }
}
