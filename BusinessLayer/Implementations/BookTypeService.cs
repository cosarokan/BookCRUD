using AutoMapper;
using DataAccessLayer;
using EntityLayer.Entities;
using EntityLayer.ViewModels;
namespace BusinessLayer.Implementations
{
    public class BookTypeService : Service<BookTypeViewModel, BookType, int>, IBookTypeService
    {
        public BookTypeService(IBookTypeRepository bookTypeRepository, IMapper mapper):base(bookTypeRepository, mapper)
        {

        }
    }
}
