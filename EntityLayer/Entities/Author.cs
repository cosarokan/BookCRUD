using EntityLayer.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityLayer.Entities
{
    [Table("Authors")]
    public class Author : Base<int>
    {
        public virtual List<Book> Books { get; set; }
    }
}
