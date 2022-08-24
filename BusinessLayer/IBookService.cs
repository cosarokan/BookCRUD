using EntityLayer.Entities;
using EntityLayer.ViewModels;
namespace BusinessLayer
{
    public interface IBookService : IService<BookViewModel, int>
    {
    }
}
