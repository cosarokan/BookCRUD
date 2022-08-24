using EntityLayer.Entities;
namespace DataAccessLayer
{
    public interface IBookRepository : IRepository<Book, int>
    {
        public List<Book> GetAllBooks();
    }
}
