using DataAccessLayer.Context;
using EntityLayer.Entities;
namespace DataAccessLayer.Implementations
{
    public class AuthorRepository : Repository<Author, int>, IAuthorRepository
    {
        public AuthorRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
