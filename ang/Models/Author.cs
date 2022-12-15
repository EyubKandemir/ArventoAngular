using System.ComponentModel.DataAnnotations;

namespace ang.Models
{
    public class Author
    {
        [Key]
        public int objectid { get; set; }
        public string author_name { get; set; }
        public string author_surname { get; set;}
    }
}
