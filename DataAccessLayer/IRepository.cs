namespace DataAccessLayer
{
    public interface IRepository<T, Id> where T : class, new()
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll();
        T GetById(Id id);
    }
}
