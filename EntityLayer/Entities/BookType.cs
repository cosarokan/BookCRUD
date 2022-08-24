using EntityLayer.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityLayer.Entities
{
    [Table("BookTypes")]
    public class BookType : Base<int>
    {
        public virtual List<Book> Books { get; set; }
    }
}
