using EntityLayer.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("Books")]
    public class Book : Base<int>
    {
        public int Page { get; set; }
        public int Price { get; set; }
        public int BookTypeId { get; set; }
        public int AuthorId { get; set; }


        [ForeignKey("BookTypeId")]
        public virtual BookType? Type { get; set; }


        [ForeignKey("AuthorId")]
        public virtual Author? Author { get; set; }


    }
}
