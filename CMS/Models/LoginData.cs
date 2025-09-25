using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class LoginData
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }

    }
}
