using System.ComponentModel.DataAnnotations;

namespace BookAPI
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; } = String.Empty;
        [StringLength(40)]
        public string Author { get; set; } = String.Empty;
        public int StatusId { get; set; }
        public Status? Status { get; set; }
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

        public int BookTypeId { get; set; }

        public BookType? BookType { get; set; }
    }
}
