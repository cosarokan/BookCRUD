using EntityLayer.Entities;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        

        public int Page { get; set; }
        public int Price { get; set; }
        public int BookTypeId { get; set; }
        public int AuthorId { get; set; }


        public BookTypeViewModel BookType { get; set; }
        public AuthorViewModel Author { get; set; }



    }
}
