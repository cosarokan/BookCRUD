namespace BusinessLayer
{
    public interface IService<T, Id>
    {
        bool Add(T model);
        bool Update(T model);
        bool Delete(T model);
        List<T> GetAll();
        T GetById(Id id);
    }
}
