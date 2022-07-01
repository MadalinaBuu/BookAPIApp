using System.ComponentModel.DataAnnotations;

namespace BookAPI
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Status { get; set; } = string.Empty;
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

        public int BookTypeId { get; set; }

        public BookType? BookType { get; set; }
    }
}
