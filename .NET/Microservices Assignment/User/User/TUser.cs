using System.ComponentModel.DataAnnotations;

namespace User
{
    public class TUser
    {
        [Key]
        public string? username { get; set; }
        public string? password { get; set; }
        public string? role { get; set; }
    }
}
