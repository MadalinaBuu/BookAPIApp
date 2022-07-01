using System.ComponentModel.DataAnnotations;

namespace BookAPI
{
    public class BookType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string BookName { get; set; } = string.Empty;
    }
}
