using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Implementations
{
    public class BookRepository : Repository<Book, int>, IBookRepository
    {
        private readonly MyContext _myContext;
        public BookRepository(MyContext myContext) : base(myContext)
        {
            _myContext = myContext;
        }
        public List<Book> GetAllBooks()
        {
            var books = _myContext.Books.Include(x => x.Author).Include(x => x.Type).ToList();

            return books;
        }
        public void Delete(int id)
        {
            var book = _myContext.Books.Find(id);
            _myContext.Books.Remove(book);
        }

    }
}
