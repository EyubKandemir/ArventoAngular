using System.ComponentModel.DataAnnotations;

namespace ang.Models
{
    public class Login
    {
        [Key]
        public int objectid { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public int user_type { get; set; }
    }
}
