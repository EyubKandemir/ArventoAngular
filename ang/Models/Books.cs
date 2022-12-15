using System.ComponentModel.DataAnnotations;

namespace ang.Models
{
    public class Books
    {
        [Key]
        public int objectid { get; set; }
        public string book_name { get; set; }
        public string isbn_number { get; set; }
        public int author_id { get; set; }
    }
}
