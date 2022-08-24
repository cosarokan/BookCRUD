using DataAccessLayer.Context;

namespace DataAccessLayer.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _myContext;

        public UnitOfWork(MyContext myContext)
        {
            _myContext = myContext;
            
        }

        public IBookRepository BookRepository { get; private set; }

        public IAuthorRepository AuthorRepository { get; private set; }

        public IBookTypeRepository BookTypeRepository { get; private set; }
    }
}
