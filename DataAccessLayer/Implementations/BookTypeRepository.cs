using DataAccessLayer.Context;
using EntityLayer.Entities;
namespace DataAccessLayer.Implementations
{
    public class BookTypeRepository : Repository<BookType, int>, IBookTypeRepository
    {
        public BookTypeRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
