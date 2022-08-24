namespace DataAccessLayer
{
    public interface IUnitOfWork
    {
        IBookRepository BookRepository { get; }
        IAuthorRepository AuthorRepository { get; }
        IBookTypeRepository BookTypeRepository { get; }
    }
}
